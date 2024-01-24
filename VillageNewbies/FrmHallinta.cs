using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using MySqlConnector;
using MySqlX.XDevAPI.Common;


namespace VillageNewbies
{
    public partial class FrmHallinta : Form
    {
        public FrmHallinta()
        {
            InitializeComponent();
        }
        MySqlConnection yhteys = new MySqlConnection("server=127.0.0.1; port=3307; Database=vn; uid=root; pwd=Ruutti");

        private void Takaisin_bt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmHallinta_Load(object sender, EventArgs e)
        {
            yhteys.Open();

            MySqlCommand msq2 = new MySqlCommand("select toimipaikka from posti", yhteys);
            MySqlDataReader msdr2 = msq2.ExecuteReader();
            while (msdr2.Read())
            {
                cb_Kaupunki.Items.Add(msdr2["toimipaikka"].ToString());
            }
            msdr2.Close();

            LataaTiedot(); // Funktio alhaalla
        }

        private void btn_PoistaVaraus_Click(object sender, EventArgs e)
        {
            string sqlstatement = "DELETE FROM varauksen_palvelut WHERE varaus_id =@varaus_id";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sqlstatement, yhteys);
                cmd.Parameters.AddWithValue("@varaus_id", cb_VarausID.Text);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

          string sqlstatement3 = "DELETE FROM lasku WHERE varaus_id =@varaus_id";
            try
            {
                MySqlCommand cmd3 = new MySqlCommand(sqlstatement3, yhteys);
                cmd3.Parameters.AddWithValue("@varaus_id", cb_VarausID.Text);
                cmd3.CommandType = CommandType.Text;
                cmd3.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string sqlstatement2 = "DELETE FROM varaus WHERE varaus_id =@varaus_id";
            try
            {
                MySqlCommand cmd2 = new MySqlCommand(sqlstatement2, yhteys);
                cmd2.Parameters.AddWithValue("@varaus_id", cb_VarausID.Text);
                cmd2.CommandType = CommandType.Text;
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LataaTiedot(); // Funktio alhaalla
        }

        private void btn_PoistaKohde_Click(object sender, EventArgs e)
        {
            //Poista mökki nappi koodi
            string sqlstatement = "DELETE FROM mokki WHERE mokki_id =@mokki_id";
            try
            {
                MySqlCommand cmd5 = new MySqlCommand(sqlstatement, yhteys);
                cmd5.Parameters.AddWithValue("@mokki_id", cb_MokkiID.Text);
                cmd5.CommandType = CommandType.Text;
                cmd5.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LataaTiedot();
        }

        private void cb_MokkiID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Kun kohteen mokki_id vaihdetaan päivitetään mokkitiedot textbox.
            MySqlCommand msq9 = new MySqlCommand("SELECT kuvaus FROM mokki WHERE mokki_id =@mokki_id", yhteys);
            msq9.Parameters.AddWithValue("@mokki_id", cb_MokkiID.Text);
            MySqlDataReader msdri = msq9.ExecuteReader();
            while (msdri.Read())
            {
                tb_Mokintiedot.Text = msdri.GetValue(0).ToString();
            }
            msq9.Dispose();
            msdri.Close();

            //Päivitetään tb_Mokkisijainti 
            MySqlCommand msq10 = new MySqlCommand("select nimi from alue left join mokki on mokki.alue_id = alue.alue_id where mokki_id =@mokki_id", yhteys);
            msq10.Parameters.AddWithValue("@mokki_id", cb_MokkiID.Text);
            MySqlDataReader msdr10 = msq10.ExecuteReader();
            while (msdr10.Read())
            {
                tb_Mokkisijainti.Text = msdr10["nimi"].ToString();
            }
            msq10.Dispose();
            msdr10.Close();

            //Päivitetään tb_Mokki
            MySqlCommand msq11 = new MySqlCommand("select mokkinimi from mokki where mokki_id =@mokki_id", yhteys);
            msq11.Parameters.AddWithValue("@mokki_id", cb_MokkiID.Text);
            MySqlDataReader msdr11 = msq11.ExecuteReader();
            while (msdr11.Read())
            {
                tb_Mokki.Text = msdr11["mokkinimi"].ToString();
            }
            msq11.Dispose();
            msdr11.Close();
        }

        private void btn_LisaaKohde_Click(object sender, EventArgs e)
        {
            // Lisätään uusi mökki tietokantaa
            try
            {
                string alueid = string.Empty;
                MySqlCommand testi = new MySqlCommand("Select alue_id from alue where nimi = @kaupunki", yhteys);
                testi.Parameters.AddWithValue("@kaupunki", cb_Kaupunki.Text);
                MySqlDataReader msdr = testi.ExecuteReader();
                while (msdr.Read())
                {
                    alueid = msdr.GetValue(0).ToString();
                }

                msdr.Close();
                msdr.Dispose();

                string insertmokki = "Insert into mokki(alue_id, postinro, mokkinimi, katuosoite, hinta, kuvaus, henkilomaara, varustelu)" +
                "Values('" + alueid + "','" + tb_postinro.Text + "','" + tb_Nimi.Text + "','" + tb_mokkiosoite.Text + "','" + tb_MokkiHinta.Text + "','" + tb_kuvaus.Text + "','" + tb_Henkmaara.Text + "','" + tb_varustelu.Text + "')";

                MySqlDataAdapter da1 = new MySqlDataAdapter();
                // Lisätään tauluun insertmokki komento
                da1.InsertCommand = new MySqlCommand(insertmokki, yhteys);
                da1.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Mökki lisätty");

                cb_Kaupunki.Text = string.Empty;

                // Tyhjennetään textboxit jotta uusi mökki voidaan lisätä sulavasti.
                foreach (Control b in gb_LisaaMokki.Controls)
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
            } catch 
            {
                MessageBox.Show("Jokin tieto puttuu!");
            }
        }

        private void cb_VarausID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Täyttää asiakas id tb:n poista varaus kohdasta
            MySqlCommand msq2 = new MySqlCommand("select asiakas_id from varaus where varaus_id =@varaus_id", yhteys);
            msq2.Parameters.AddWithValue("@varaus_id", cb_VarausID.Text);
            MySqlDataReader msdr2 = msq2.ExecuteReader();
            while (msdr2.Read())
            {
                tb_Asiakasid.Text = msdr2["asiakas_id"].ToString();
            }
            msq2.Dispose();
            msdr2.Close();

            // Täyttää tb_AsiakasEnimi nimen varaus_id perusteella
            MySqlCommand msc7 = new MySqlCommand("SELECT etunimi FROM asiakas WHERE asiakas_id =@asiakas_id", yhteys);
            msc7.Parameters.AddWithValue("@asiakas_id", tb_Asiakasid.Text);
            MySqlDataReader sdr1 = msc7.ExecuteReader();    
            while (sdr1.Read())
            {
                tb_AsiakasEnimi.Text = sdr1["etunimi"].ToString();
            }
            msc7.Dispose();
            sdr1.Close();

            // Täyttää tb_asiakasSnimi nimen varaus_id perusteella
            MySqlCommand msc8 = new MySqlCommand("SELECT sukunimi FROM asiakas WHERE asiakas_id =@asiakas_id", yhteys);
            msc8.Parameters.AddWithValue("@asiakas_id", tb_Asiakasid.Text);
            MySqlDataReader sdr2 = msc8.ExecuteReader();
            while (sdr2.Read())
            {
                tb_AsiakasSnimi.Text = sdr2["sukunimi"].ToString();
            }
            msc8.Dispose();
            sdr2.Close();
        }

        // Tämä funktio lataa kaikki tiedot poista varaus kohtaan
        private void LataaTiedot()
        {
            // Täyttää varaus id cb:n poista varaus kohdasta
            MySqlDataAdapter sda = new MySqlDataAdapter();
            MySqlCommand msc = new MySqlCommand("SELECT varaus_id FROM varaus", yhteys);
            sda.SelectCommand = msc;
            DataTable dt3 = new DataTable();
            sda.Fill(dt3);
            cb_VarausID.DataSource = dt3;
            cb_VarausID.ValueMember = "varaus_id";

            // Täyttää kohdan MökkiID cb:n poista mökki
            MySqlCommand msc5 = new MySqlCommand("SELECT mokki_id FROM mokki", yhteys);
            MySqlDataAdapter sda5 = new MySqlDataAdapter();
            sda5.SelectCommand = msc5;
            DataTable dt6 = new DataTable();
            sda5.Fill(dt6);
            cb_MokkiID.DataSource = dt6;
            cb_MokkiID.ValueMember = "mokki_id";

            //Päivitetään tb_Mokkisijainti 
            MySqlCommand msq10 = new MySqlCommand("select nimi from alue left join mokki on mokki.alue_id = alue.alue_id where mokki_id =@mokki_id", yhteys);
            msq10.Parameters.AddWithValue("@mokki_id", cb_MokkiID.Text);
            MySqlDataReader msdr10 = msq10.ExecuteReader();
            while (msdr10.Read())
            {
                tb_Mokkisijainti.Text = msdr10["nimi"].ToString();
            }
            msq10.Dispose();
            msdr10.Close();

            //Päivitetään tb_Mokki
            MySqlCommand msq11 = new MySqlCommand("select mokkinimi from mokki where mokki_id =@mokki_id", yhteys);
            msq11.Parameters.AddWithValue("@mokki_id", cb_MokkiID.Text);
            MySqlDataReader msdr11 = msq11.ExecuteReader();
            while (msdr11.Read())
            {
                tb_Mokki.Text = msdr11["mokkinimi"].ToString();
            }
            msq11.Dispose();
            msdr11.Close();
        }

        private void cb_Kaupunki_SelectedIndexChanged(object sender, EventArgs e)
        {
           MySqlCommand msq2 = new MySqlCommand("select postinro from posti where toimipaikka =@toimipaikka", yhteys);
           msq2.Parameters.AddWithValue("@toimipaikka", cb_Kaupunki.Text);
           MySqlDataReader msdr2 = msq2.ExecuteReader();
           while (msdr2.Read())
           {
               tb_postinro.Text = msdr2["postinro"].ToString();
           }
           msq2.Dispose();
           msdr2.Close();
        }

        private void tb_MokkiHinta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void tb_Henkmaara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gb_VarausID_Enter(object sender, EventArgs e)
        {

        }
    }
}
