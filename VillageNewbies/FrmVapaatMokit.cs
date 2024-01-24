using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI.Common;
using MySqlConnector;
using Google.Protobuf.WellKnownTypes;
using Org.BouncyCastle.Utilities.Zlib;

namespace VillageNewbies
{
    public partial class FrmVaraus : Form
    {
        public FrmVaraus()
        {
            InitializeComponent();
        }

        MySqlConnection yhteys = new MySqlConnection("server=127.0.0.1; port=3307; Database=vn; uid=root; pwd=Ruutti");

        
        public string PALVELU_HINTA = string.Empty;
        public string PALVELU_ALV = string.Empty;
        public int LASKU_ID;


        private void FrmVapaatmokit_Load(object sender, EventArgs e)
        {
           btn_HyvaksyVarays.Enabled = false;  
        }

        // Kun kalenterista valitaan tai maalataan päivämääriä, karsitaan kaikki varatut kohteet pois jotta 
        // päällekkäisiä varauksia ei ole mahdollista tehdä
        private void mc_Varaus_DateSelected(object sender, DateRangeEventArgs e)
        {
            using (MySqlConnection yhteys = new MySqlConnection("server=127.0.0.1; port=3307; Database=vn; uid=root; pwd=Ruutti"))
            {
                yhteys.Open();

                //Tallennetaan stringeihin monthcalendarista valitut päivämäärät

                string varausAlku = mc_Varaus.SelectionStart.ToString("yyyy'-'MM'-'dd' '02':'00':'01");
                string varausLoppu = mc_Varaus.SelectionEnd.ToString("yyyy'-'MM'-'dd' '22':'59':'59");

                dtp_Lahtopvm.Text = varausLoppu;
                dtp_Saapumispvm.Text = varausAlku;

                // Täytetään comboboxiin kaikki tietokannan mökit

                MySqlCommand msc = new MySqlCommand("SELECT distinct mokkinimi FROM mokki", yhteys);

                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter();
                sqlDataAdapter.SelectCommand = msc;
                DataTable dt = new DataTable();
                dt.Clear();
                sqlDataAdapter.Fill(dt);
                cb_VapaatMokit.DataSource = dt;
                cb_VapaatMokit.DisplayMember = "mokkinimi";

                // Valitaan kaikki mökit jotka ovat varattu valittuna ajankohtana

                MySqlCommand mscdelete = new MySqlCommand("Select mokkinimi from mokki m INNER JOIN varaus v ON m.mokki_id = v.mokki_mokki_id where" + "'" + varausAlku + "'" + "and" + "'" + varausLoppu + "'" + " between varattu_alkupvm AND varattu_loppupvm or varattu_alkupvm AND varattu_loppupvm between" + "'" + varausAlku + "'" + "and" + "'" + varausLoppu + "'", yhteys);

                MySqlDataReader msdr = mscdelete.ExecuteReader();

                // Jos valittujen päivien välissä on varattuja mökkejä, varatut kohteet poistetaan näkyvistä jotta niitä ei voi varata
                while (msdr.Read())
                {
                    for (int i = dt.Rows.Count - 1; i >= 0; i--)
                    {
                        // Käydään Comboboxin jokaiden rivi läpi ja tutkitaan onko varatuissa mökeissä samannimisiä mökkejä kuin comboboxissa
                        DataRow dr = dt.Rows[i];
                        if (dr["mokkinimi"].ToString() == msdr.GetValue(0).ToString())
                        {
                            // Jos on niin poistetaan ja hyväksytään muutos
                            dr.Delete();
                            dt.AcceptChanges();
                        }
                    }
                }
            }
        }

        // Lisätään formiin mökin tiedot sen nimen ja sijainnin perusteella.
        private void cb_VapaatMokit_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Jos kohteita ei ole valittu ei voida luoda asiakastietojakaan

            foreach (Control b in gb_Asiakastiedot.Controls)

            {
                TextBox c;
                if (b is TextBox)
                {
                    c = b as TextBox;
                    c.Enabled = true;
                }
            }

            using (MySqlConnection yhteys = new MySqlConnection("server=127.0.0.1; port=3307; Database=vn; uid=root; pwd=Ruutti"))
            {
                yhteys.Open();

                // Päivittää valitun mökin tiedot näkyviin sen nimen perusteella

                MySqlCommand msc = new MySqlCommand("Select m.kuvaus, m.varustelu,m.henkilomaara, m.mokki_id, m.alue_id , m.hinta, a.nimi FROM mokki m INNER JOIN alue a ON m.alue_id = a.alue_id where mokkinimi =@mokki", yhteys);
                msc.Parameters.AddWithValue("@mokki", cb_VapaatMokit.Text);
                MySqlDataReader msdr = msc.ExecuteReader();

                while (msdr.Read())
                {
                    rtb_MokkiTiedot.Text = msdr.GetValue(0).ToString();
                    rtb_Mokkivarustelu.Text = msdr.GetValue(1).ToString();
                    tb_Henklkm.Text = msdr.GetValue(2).ToString();
                    tb_MokkiID.Text = msdr.GetValue(3).ToString();
                    tb_AlueID.Text = msdr.GetValue(4).ToString();
                    tb_hinta.Text = msdr.GetValue(5).ToString();
                    tb_Sijainti.Text = msdr.GetValue(6).ToString();
                    
                }
                msdr.Close();

            }
        }

        // Päivitetään checkedlistboxiin saatavilla olevat palvelut mökin sijainnin perusteella.
        private void tb_Sijainti_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection yhteys = new MySqlConnection("server=127.0.0.1; port=3307; Database=vn; uid=root; pwd=Ruutti"))
            {
                yhteys.Open();
                clb_Lisapalvelut.Items.Clear();

                // Valitaan sijainnin perusteella saatavilla olevat palvelut

                MySqlCommand msc = new MySqlCommand("SELECT nimi, hinta FROM palvelu where alue_id = @sijainti", yhteys);

                msc.Parameters.AddWithValue("@sijainti", tb_AlueID.Text);

                MySqlDataReader msdr = msc.ExecuteReader();

                while (msdr.Read())
                {
                    // Lisätään palvelut listalle

                    clb_Lisapalvelut.Items.Add(msdr.GetValue(0).ToString()+ " " +msdr.GetValue(1).ToString() + "€");

                }
                msdr.Close();

            }

        }
            // Näillä komennoilla estetään käyttäjää tekemästä virheellistä varausta, jokaisessa tekstikentässä pitää olla vaadittavat tekstit eikä 
            // Käyttäjä voi syöttää väärää tietoa kenttiin
        private void tb_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_Email.Text) || string.IsNullOrEmpty(tb_Etunimi.Text)
                || string.IsNullOrEmpty(tb_Postinro.Text) || string.IsNullOrEmpty(tb_PuhNo.Text) ||
                string.IsNullOrEmpty(tb_Sukunimi.Text) || string.IsNullOrEmpty(tb_Osoite.Text))
            {
                btn_HyvaksyVarays.Enabled = false;
            }
            else
            {
                btn_HyvaksyVarays.Enabled = true;
            }

        }

        private void tb_Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_Kirjain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_Osoite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Kun varaus hyväksytään varmistetaan vielä että tiedot ovat oikeellisia
        private void btn_HyvaksyVarays_Click(object sender, EventArgs e)
        {
            // Jos tietoja puuttuu niin pyydetään tarkistamaan tiedot

            if (string.IsNullOrEmpty(tb_Email.Text) || string.IsNullOrEmpty(tb_Etunimi.Text)
               || string.IsNullOrEmpty(tb_Postinro.Text) || string.IsNullOrEmpty(tb_PuhNo.Text) || string.IsNullOrEmpty(tb_Sukunimi.Text) || string.IsNullOrEmpty(tb_Osoite.Text))
            {
                MessageBox.Show("Tarkistathan että asiakkaan kaikki tiedot ovat oikein täytetty.");

                foreach (Control c in gb_Asiakastiedot.Controls)
                {
                    if (c is TextBox)
                    {
                        c.BackColor = Color.IndianRed;

                    }
                }
            }

            // Jos tiedot ovat oikein niin kutsutaan TeeVaraus() funktiota ja muutetaan tekstilaatikot valkoiseksi
            else
            {

                foreach (Control c in gb_Asiakastiedot.Controls)
                {
                    if (c is TextBox)
                    {
                        c.BackColor = Color.White;

                    }
                }

                TeeVaraus();

            }

        }

        // Päivittää varauksen tiedot tietokantaan
        private void TeeVaraus()
        {
            using (MySqlConnection yhteys = new MySqlConnection("server=127.0.0.1; port=3307; Database=vn; uid=root; pwd=Ruutti"))
            {
                yhteys.Open();

                MySqlDataAdapter da = new MySqlDataAdapter();


                // Asetetaan insert komento joka sisällyttää asiakastiedot stringiin

                string insertAsiakas = "Insert into asiakas(etunimi,sukunimi, lahiosoite, email, puhelinnro, postinro)" +
                "Values('" + tb_Etunimi.Text + "','" + tb_Sukunimi.Text + "','" + tb_Osoite.Text + "','" + tb_Email.Text + "','" + tb_PuhNo.Text + "','" + tb_Postinro.Text + "')";



                // Lisätään asiakastiedot asiakastauluun

                da.InsertCommand = new MySqlCommand(insertAsiakas, yhteys);
                da.InsertCommand.ExecuteNonQuery();




                // Tässä valitaan juuri luodun asiakkaan asiakasID, jotta sitä voidaan käyttää varaustaulussa

                MySqlCommand msq = new MySqlCommand("Select asiakas_id from asiakas where etunimi =@nimi and sukunimi =@sukunimi and puhelinnro =@puhno", yhteys);
                msq.Parameters.AddWithValue("@nimi", tb_Etunimi.Text);
                msq.Parameters.AddWithValue("@sukunimi", tb_Sukunimi.Text);
                msq.Parameters.AddWithValue("@puhno", tb_PuhNo.Text);

                MySqlDataReader msdr3 = msq.ExecuteReader();
                string asiakasID = null;

                while (msdr3.Read())
                {
                    //Getvalue(0) viittaa asiakas_id:hen

                    asiakasID = msdr3.GetValue(0).ToString();
                }
                asiakasid.asiakaid = asiakasID; // tähän asiakas id joka luodaan mökin varauksen yhteydessä
                asiakasid.mokkiid = tb_MokkiID.Text;

                msdr3.Close();





                // Tallennetaan lisaapvm stringiin tiedot saapumis/lähtemispäivistä sekä äsken tallennetusta asiakasID:stä

                string lisaapvm = "Insert into varaus(mokki_mokki_id,varattu_pvm,varattu_alkupvm,varattu_loppupvm, asiakas_id)" +
                 "Values('" + int.Parse(tb_MokkiID.Text) + "','" + DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss")
                 + "','" + dtp_Saapumispvm.Value.ToString("yyyy'-'MM'-'dd' '01':'00':'00") + "','"
                 + dtp_Lahtopvm.Value.ToString("yyyy'-'MM'-'dd' '23':'59':'59") + "','" + asiakasID + "')";

                da.InsertCommand = new MySqlCommand(lisaapvm, yhteys);
                da.InsertCommand.ExecuteNonQuery();





     
                // Tallennetaan juuri tehdyn asikasID:n perusteella hänen varaus ID jotta sitä voidaan käyttää varauksen palveluiden dokumentoinnissa

                MySqlCommand palvelu = new MySqlCommand("Select varaus_id from varaus where asiakas_id="+"'"+ asiakasID+ "'", yhteys);
                MySqlDataReader msdrr = palvelu.ExecuteReader();
                string VARAUS_ID = "0";

                while (msdrr.Read())
                {
                    VARAUS_ID=msdrr.GetValue(0).ToString();
       
                }   
                msdrr.Close();

                // Lisätään varauksen_palvelut tauluun tieto asiakkaan palveluista ja hinnoista mikäli niitä on varattu


                if (clb_Lisapalvelut.CheckedItems.Count > 0)
                {

                    MySqlCommand palveluid = new MySqlCommand("Select distinct palvelu_id, hinta, alv from palvelu where alue_id=@alue", yhteys);
                    palveluid.Parameters.AddWithValue("@alue", tb_AlueID.Text.ToString());

                    MySqlDataReader msdrpalvelu = palveluid.ExecuteReader();
                    string PALVELU_ID = string.Empty;

                    while (msdrpalvelu.Read())
                    {
                        PALVELU_ID = msdrpalvelu.GetValue(0).ToString();
                        PALVELU_HINTA = msdrpalvelu.GetValue(1).ToString();
                        PALVELU_ALV = msdrpalvelu.GetValue(2).ToString();
                          
                    }
                    msdrpalvelu.Close();
                    Int32.Parse(PALVELU_ID);
                    

                    string insertvaraus1 = "insert into varauksen_palvelut(varaus_id, palvelu_id,lkm) values (" + "'" + VARAUS_ID + "'" + "," + "'" + PALVELU_ID + "'" + "," + "'"+ clb_Lisapalvelut.CheckedItems.Count+ "'"  + ")"; 
                    da.InsertCommand = new MySqlCommand(insertvaraus1, yhteys);
                    da.InsertCommand.ExecuteNonQuery();
                }
                else
                {
                    PALVELU_HINTA = "0";
                    PALVELU_ALV = "0";
                }

                //Luodaan satunnainen luku jota käytetään lasku_ID:nä.

                Random rnd=new Random();
                for(int i = 0; i <=0; i++)
                {
                     LASKU_ID=rnd.Next(99999999);
                }

                // Sijoitetaan palveluiden hinnat integereihin, jotta voidaan laskuttaa oikea summa.

                int loppusumma = (Int32.Parse(PALVELU_HINTA) + Int32.Parse(tb_hinta.Text));
                int alv = Int32.Parse(PALVELU_ALV);

                // Lisätään laskuun juuri luotu LASKU_ID, VARAUS_ID ja palveluiden ja mökin hinnat.

                MySqlCommand testi = new MySqlCommand("insert into lasku(lasku_id,varaus_id,summa,alv) Values(" + LASKU_ID + "," + "'" +VARAUS_ID + "'" + "," + "'" + loppusumma+ "'" + "," + "'" + alv + "')", yhteys);
                da.InsertCommand = testi;
                da.InsertCommand.ExecuteNonQuery();

                // Ilmoitetaan että varaus on onnistunut.

                MessageBox.Show("Varaus on luotu onnistuneesti!");
            }

            // Tyhjennetään textboxit jotta uusi käyttäjä voidaan lisätä sulavasti.

            foreach (Control b in gb_Asiakastiedot.Controls)

            {
                TextBox c;
                if (b is TextBox)
                {
                    c = b as TextBox;
                    if (c != null)
                    {
                        c.Text = String.Empty;

                    }
                }
            }

        }

        private void btn_HyvaksyVarauksia_Click(object sender, EventArgs e)
        {
            FrmHyvaksyVaraus frmvaraus = new FrmHyvaksyVaraus();
            frmvaraus.Show();
        }

        private void btn_Takaisin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mc_Varaus_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}

