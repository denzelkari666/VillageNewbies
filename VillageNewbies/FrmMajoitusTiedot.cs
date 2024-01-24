using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VillageNewbies
{
    public partial class FrmMajoitustiedot : Form
    {
        public FrmMajoitustiedot()
        {
            InitializeComponent();
        }
        MySqlConnection yhteys = new MySqlConnection("server=127.0.0.1; port=3307; Database=vn; uid=root; pwd=Ruutti");
        private void Takaisin_bt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void paivitatiedot()
        {


            
            MySqlCommand Sqlcomm1 = new MySqlCommand("SELECT asiakas_id FROM asiakas", yhteys);
            MySqlDataAdapter data1 = new MySqlDataAdapter();
            data1.SelectCommand = Sqlcomm1;
            DataTable datatb1 = new DataTable();
            data1.Fill(datatb1);
            cb_AsiakasId.DataSource = datatb1;
            cb_AsiakasId.ValueMember = "asiakas_id";
           
            MySqlCommand msq1 = new MySqlCommand("Select * from asiakas LEFT JOIN varaus ON asiakas.asiakas_id = varaus.asiakas_id LEFT JOIN mokki ON varaus.mokki_mokki_id = mokki.mokki_id LEFT JOIN alue ON mokki.alue_id = alue.alue_id LEFT JOIN lasku ON varaus.varaus_id = lasku.varaus_id LEFT JOIN palvelu on alue.alue_id = palvelu.alue_id where asiakas.asiakas_id =@asiakas_id", yhteys);
            msq1.Parameters.AddWithValue("@asiakas_id", cb_AsiakasId.Text);
            MySqlDataReader msdr1 = msq1.ExecuteReader();

            while (msdr1.Read())
            {
                tb_Nimi.Text = msdr1["etunimi"].ToString();
                tb_Sahkoposti.Text = msdr1["email"].ToString();
                tb_Osoite.Text = msdr1["lahiosoite"].ToString();
                tb_Posti.Text = msdr1["postinro"].ToString();
                tb_PuhNo.Text = msdr1["puhelinnro"].ToString();
                tb_VarausID.Text = msdr1["varaus_id"].ToString();
                tb_MokkiID.Text = msdr1["mokki_id"].ToString();
                tb_Mokki.Text = msdr1["mokkinimi"].ToString();
                tb_MokkiOsoite.Text = msdr1["katuosoite"].ToString();
                tb_Sijainti.Text = msdr1["nimi"].ToString();
                tb_VarausPvm.Text = msdr1["varattu_pvm"].ToString();
                tb_AlkuPvm.Text = msdr1["varattu_alkupvm"].ToString();
                tb_LoppuPvm.Text = msdr1["varattu_loppupvm"].ToString();
                tb_Henklkm.Text = msdr1["henkilomaara"].ToString();
                tb_LaskuID.Text = msdr1["lasku_id"].ToString();
                tb_kuvaus.Text = msdr1["kuvaus"].ToString();
                tb_LaskuHinta.Text = msdr1["summa"].ToString();
             

            }
            msq1.Dispose();
            msdr1.Close();
        }


        // Avaa tekstikentät muokkausta varten
        private void btn_MuutaTietoja_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.BackColor = Color.LightSalmon;
                    tb_Nimi.BackColor = Color.LightSalmon;
                    tb_Sijainti.BackColor = Color.LightSalmon;
                    tb_kuvaus.BackColor = Color.LightSalmon;
                    c.Enabled = true;
                    tb_Nimi.Enabled = true;
                    // Koska jokaisen asiakkaan ID on uniikki, käyttäjä ei voi muuttaa sitä tässä formissa.
                    cb_AsiakasId.Enabled = false;

                }
            }
        }

        // Tallentaa tehdyt muutokset
        private void btn_TallennaMuutokset_Click(object sender, EventArgs e)
        {

            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.BackColor = Color.Snow;
                    tb_Nimi.BackColor = Color.Snow;
                    tb_Sijainti.BackColor = Color.Snow;
                    tb_kuvaus.BackColor = Color.Snow;
                    c.Enabled = false;
                    // Avataan taas AsiakasID Combobox jotta käyttäjä voi tarkastaa tietoja sen perusteella.
                    cb_AsiakasId.Enabled = true;
                }
            }
            // Annetaan varmistusilmoitus käyttäjälle

            String muutokset = "Haluatko varmasti tallentaa tehdyt muutokset?";
            String otsikko = "Huomio!";
            DialogResult jatketaanko = MessageBox.Show(muutokset, otsikko, MessageBoxButtons.YesNo);
            if (jatketaanko == DialogResult.Yes)
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                string updateemail = "update asiakas set email = ('" + tb_Sahkoposti.Text + "') WHERE asiakas_id =@asiakasid";
                string updatenimi = "update asiakas set etunimi = ('" + tb_Nimi.Text + "') Where asiakas_id =@asiakasid";
                string updateosoite = "update asiakas set lahiosoite = ('" + tb_Osoite.Text + "') Where asiakas_id =@asiakasid";
                string updateposti = "update asiakas set postinro = ('" + tb_Posti.Text + "') Where asiakas_id = @asiakasid";
                string updatepuh = "update asiakas set puhelinnro = ('" + tb_PuhNo.Text + "') Where asiakas_id = @asiakasid";
                string updatemokkinimi = "update mokki set mokkinimi = ('" + tb_Mokki.Text + "')Where mokki_id = @mokkiid";
                string updatemokkiosoite = "update mokki set katuosoite = ('" + tb_MokkiOsoite.Text + "')Where mokki_id = @mokkiid";
                string updatehenkilomaara = "update mokki set henkilomaara = ('" + tb_Henklkm.Text + "')Where mokki_id = @mokkiid";
                string updatelaskumaara = "update lasku set summa =('" + tb_LaskuHinta.Text + "')Where lasku_id = @laskuid";
                string updatekuvaus = "update mokki set kuvaus =('" + tb_kuvaus.Text + "')where mokki_id = @mokkiid";
                if (tb_VarausID.Text != String.Empty)
                {
                    DateTime varauspvm = Convert.ToDateTime(tb_VarausPvm.Text);
                    DateTime alkupvm = Convert.ToDateTime(tb_AlkuPvm.Text);
                    DateTime loppupvm = Convert.ToDateTime(tb_LoppuPvm.Text);

                    string updatevarauspvm = "update varaus set varattu_pvm = @varauspvm where varaus_id = @varausid";
                    string updatealku = "update varaus set varattu_alkupvm = @alkupvm where varaus_id = @varausid";
                    string updateloppu = "update varaus set varattu_loppupvm = @loppupvm where varaus_id = @varausid";

                    MySqlCommand mycom8 = new MySqlCommand(updatevarauspvm, yhteys);
                    MySqlCommand mycom9 = new MySqlCommand(updatealku, yhteys);
                    MySqlCommand mycom10 = new MySqlCommand(updateloppu, yhteys);

                    mycom8.Parameters.AddWithValue("@varausid", tb_VarausID.Text);
                    mycom8.Parameters.AddWithValue("@varauspvm", varauspvm);
                    mycom9.Parameters.AddWithValue("@varausid", tb_VarausID.Text);
                    mycom9.Parameters.AddWithValue("@alkupvm", alkupvm);
                    mycom10.Parameters.AddWithValue("@varausid", tb_VarausID.Text);
                    mycom10.Parameters.AddWithValue("@loppupvm", loppupvm);
                    
                    mycom8.ExecuteNonQuery();
                    mycom9.ExecuteNonQuery();
                    mycom10.ExecuteNonQuery();
                }

                MySqlCommand mycom = new MySqlCommand(updateemail, yhteys);
                MySqlCommand mycom2 = new MySqlCommand(updatenimi, yhteys);
                MySqlCommand mycom3 = new MySqlCommand(updateosoite, yhteys);
                MySqlCommand mycom4 = new MySqlCommand(updateposti, yhteys);
                MySqlCommand mycom5 = new MySqlCommand(updatepuh, yhteys);
                MySqlCommand mycom6 = new MySqlCommand(updatemokkinimi, yhteys);
                MySqlCommand mycom7 = new MySqlCommand(updatemokkiosoite, yhteys);

                MySqlCommand mycom11 = new MySqlCommand(updatehenkilomaara, yhteys);
                MySqlCommand mycom12 = new MySqlCommand(updatelaskumaara, yhteys);
                MySqlCommand mycom13 = new MySqlCommand(updatekuvaus, yhteys);

                mycom.Parameters.AddWithValue("@asiakasid", cb_AsiakasId.Text);
                mycom2.Parameters.AddWithValue("@asiakasid", cb_AsiakasId.Text);
                mycom3.Parameters.AddWithValue("@asiakasid", cb_AsiakasId.Text);
                mycom4.Parameters.AddWithValue("@asiakasid", cb_AsiakasId.Text);
                mycom5.Parameters.AddWithValue("@asiakasid", cb_AsiakasId.Text);

                mycom6.Parameters.AddWithValue("@mokkiid", tb_MokkiID.Text);
                mycom7.Parameters.AddWithValue("@mokkiid", tb_MokkiID.Text);
                mycom11.Parameters.AddWithValue("@mokkiid", tb_Mokki.Text);
                mycom12.Parameters.AddWithValue("@laskuid", tb_LaskuID.Text);
                mycom13.Parameters.AddWithValue("@mokkiid", tb_MokkiID.Text);

                mycom.ExecuteNonQuery();
                mycom2.ExecuteNonQuery();
                mycom3.ExecuteNonQuery();
                mycom4.ExecuteNonQuery();
                mycom5.ExecuteNonQuery();
                mycom6.ExecuteNonQuery();
                mycom7.ExecuteNonQuery();
                mycom11.ExecuteNonQuery();
                mycom12.ExecuteNonQuery();
                mycom13.ExecuteNonQuery();

                MessageBox.Show("Tiedot tallennettu onnistuneesti!");
            }

            else
            {
                MessageBox.Show("Tietoja ei tallennettu.");
            }        
        }
        private void FrmMajoitustiedot_Load(object sender, EventArgs e)
        {    
            try
            {
                yhteys.Open();
                //MessageBox.Show("Yhteys toimii");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            paivitatiedot();            
        }

        private void btn_PoistaAsiakas_Click(object sender, EventArgs e)
        {
            // Poistetaan asiakkkaaseeen liittyvät taulut tietokannasta

            string poistapalvelut = "DELETE FROM varauksen_palvelut WHERE varaus_id =@varausid";
            string poistavaraus = "DELETE FROM varaus WHERE asiakas_id =@asiakasid";
            string poistalasku = "DELETE FROM lasku WHERE varaus_id =@varausid";
            string poistaasiakas = "DELETE FROM asiakas WHERE asiakas_id = @asiakasid";

            MySqlCommand msq = new MySqlCommand(poistapalvelut,yhteys);
            MySqlCommand msq2 = new MySqlCommand(poistavaraus, yhteys);
            MySqlCommand msq3 = new MySqlCommand(poistalasku, yhteys);
            MySqlCommand msq4 = new MySqlCommand(poistaasiakas, yhteys);

            msq2.Parameters.AddWithValue("@asiakasid", cb_AsiakasId.Text); 
            msq.Parameters.AddWithValue("@varausid",tb_VarausID.Text);
            msq3.Parameters.AddWithValue("@varausid", tb_VarausID.Text);
            msq4.Parameters.AddWithValue("@asiakasid", cb_AsiakasId.Text);

            msq.ExecuteNonQuery();
            msq3.ExecuteNonQuery();
            msq2.ExecuteNonQuery();
            msq4.ExecuteNonQuery();


            paivitatiedot();
            Paivitaf();
        }


        private void cb_AsiakasId_SelectedIndexChanged(object sender, EventArgs e)
        {
               MySqlCommand msq = new MySqlCommand("Select * from asiakas LEFT JOIN varaus ON asiakas.asiakas_id = varaus.asiakas_id LEFT JOIN mokki ON varaus.mokki_mokki_id = mokki.mokki_id LEFT JOIN alue ON mokki.alue_id = alue.alue_id LEFT JOIN lasku ON varaus.varaus_id = lasku.varaus_id LEFT JOIN palvelu on alue.alue_id = palvelu.alue_id where asiakas.asiakas_id =@asiakasid", yhteys);
               msq.Parameters.AddWithValue("@asiakasid", cb_AsiakasId.Text);
               MySqlDataReader msdr = msq.ExecuteReader();

               while (msdr.Read())
               {
                       tb_Nimi.Text = msdr["etunimi"].ToString();
                       tb_Sahkoposti.Text = msdr["email"].ToString();
                       tb_Osoite.Text = msdr["lahiosoite"].ToString();
                       tb_Posti.Text = msdr["postinro"].ToString();
                       tb_PuhNo.Text = msdr["puhelinnro"].ToString();
                       tb_VarausID.Text = msdr["varaus_id"].ToString();
                       tb_MokkiID.Text = msdr["mokki_id"].ToString();
                       tb_Mokki.Text = msdr["mokkinimi"].ToString();
                       tb_MokkiOsoite.Text = msdr["katuosoite"].ToString();
                       tb_Sijainti.Text = msdr["nimi"].ToString();
                       tb_VarausPvm.Text = msdr["varattu_pvm"].ToString();
                       tb_AlkuPvm.Text = msdr["varattu_alkupvm"].ToString();
                       tb_LoppuPvm.Text = msdr["varattu_loppupvm"].ToString();
                       tb_Henklkm.Text = msdr["henkilomaara"].ToString();
                       tb_LaskuID.Text = msdr["lasku_id"].ToString();
                       tb_kuvaus.Text = msdr["kuvaus"].ToString();
                       tb_LaskuHinta.Text = msdr["summa"].ToString();
               }
               msq.Dispose();
               msdr.Close();      
        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        private void Paivitaf()
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            Timer timer = new Timer();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            timer.Interval = 100;
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            timer.Start();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            FrmMajoitustiedot frmm = new FrmMajoitustiedot();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            frmm.Show();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            Close();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        }

        private void tb_Nimi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_Posti_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_PuhNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_MokkiID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_VarausID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_LaskuID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
