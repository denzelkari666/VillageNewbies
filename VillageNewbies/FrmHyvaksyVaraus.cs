using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VillageNewbies
{
    public partial class FrmHyvaksyVaraus : Form
    {
        public FrmHyvaksyVaraus()
        {
            InitializeComponent();
        }
        MySqlConnection yhteys = new MySqlConnection("server=127.0.0.1; port=3307; Database=vn; uid=root; pwd=Ruutti");
       
        private void FrmHyvaksyVaraus_Load(object sender, EventArgs e)
        {

  
       
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //UPDATE varaus SET  mokki_mokki_id = 3 WHERE varaus_id = 5;

            //päivitetään hyväksymis pvm mökille

            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                string lisaahyvaksymispvm = "UPDATE varaus SET vahvistus_pvm = ('" + DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss") + "') WHERE asiakas_id =@asiakasid";
                MySqlCommand mycom = new MySqlCommand(lisaahyvaksymispvm, yhteys);
                mycom.Parameters.AddWithValue("@asiakasid", asiakasidcb.Text);
                mycom.ExecuteNonQuery();

                MessageBox.Show("Varuas Hyväksytty");
            }
            catch
            {
                MessageBox.Show("Varauksen hyväksyminen epäonnistui");
            }
            
        }

        private void FrmHyvaksyVaraus_Load_1(object sender, EventArgs e)
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
            //täyttää asiakas id comboboxin


            MySqlCommand Sqlcomm = new MySqlCommand("SELECT asiakas.asiakas_id FROM asiakas LEFT JOIN varaus on varaus.asiakas_id = asiakas.asiakas_id WHERE vahvistus_pvm IS null and varattu_pvm IS NOT null", yhteys);
            MySqlDataAdapter data = new MySqlDataAdapter();
            data.SelectCommand = Sqlcomm;
            DataTable datatb = new DataTable();
            data.Fill(datatb);
            asiakasidcb.DataSource = datatb;
            asiakasidcb.ValueMember = "asiakas_id";

            asiakasidcb.Text = asiakasid.asiakaid;

            //täyttää mökki id comboboxin

            MySqlCommand Sqlcomm2 = new MySqlCommand("SELECT mokki_id FROM mokki left join varaus on varaus.mokki_mokki_id = mokki.mokki_id left join asiakas on asiakas.asiakas_id = varaus.asiakas_id where asiakas.asiakas_id = @asiakasid ", yhteys);

            Sqlcomm2.Parameters.AddWithValue("@asiakasid", asiakasidcb.Text);
            MySqlDataReader msdr1 = Sqlcomm2.ExecuteReader();
            while (msdr1.Read())
            {
                cbmokkitiedot.Text = msdr1["mokki_id"].ToString();
            }
            msdr1.Close();
            msdr1.Dispose();
                cbmokkitiedot.Text = asiakasid.mokkiid; 
        }

        private void asiakasidcb_TextUpdate(object sender, EventArgs e)
        {
            

          
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            // täyttää ja tyhjentää asiakas listboxin

            lbasiakastiedot.Items.Clear();
        

            MySqlCommand msq = new MySqlCommand("Select * from asiakas where asiakas_id =@asiakasid ", yhteys);
            msq.Parameters.AddWithValue("@asiakasid", asiakasidcb.Text);
            MySqlDataReader msdr = msq.ExecuteReader();

            while (msdr.Read())
            {
                lbasiakastiedot.Items.Add(msdr["etunimi"]);
                lbasiakastiedot.Items.Add(msdr["sukunimi"]);
                lbasiakastiedot.Items.Add(msdr["postinro"]);
                lbasiakastiedot.Items.Add(msdr["lahiosoite"]);
                lbasiakastiedot.Items.Add(msdr["email"]);
                lbasiakastiedot.Items.Add(msdr["puhelinnro"]);

            }
            msq.Dispose();
            msdr.Close();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void paivitamokkitiedot_Click(object sender, EventArgs e)
        {
            //täyttää / tyhjentää mökki listboxin

            lbmokkitiedot.Items.Clear();

            MySqlCommand msq = new MySqlCommand("Select * from mokki where mokki_id =@mokkiid ", yhteys);
            msq.Parameters.AddWithValue("@mokkiid", cbmokkitiedot.Text);
            MySqlDataReader msdr = msq.ExecuteReader();

            while (msdr.Read())
            {
                lbmokkitiedot.Items.Add(msdr["mokkinimi"]);
                lbmokkitiedot.Items.Add(msdr["katuosoite"]);
                lbmokkitiedot.Items.Add(msdr["postinro"]);
                lbmokkitiedot.Items.Add(msdr["hinta"]);
                lbmokkitiedot.Items.Add(msdr["henkilomaara"]);
                lbmokkitiedot.Items.Add(msdr["varustelu"]);

            }
            msq.Dispose();
            msdr.Close();
        }

        private void lbmokkitiedot_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void asiakasidcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbmokkitiedot.Items.Clear();
            cbmokkitiedot.Text = String.Empty;

            lbasiakastiedot.Items.Clear();


            MySqlCommand msq1 = new MySqlCommand("Select * from asiakas where asiakas_id =@asiakasid ", yhteys);
            msq1.Parameters.AddWithValue("@asiakasid", asiakasidcb.Text);
            MySqlDataReader msdr1 = msq1.ExecuteReader();

            while (msdr1.Read())
            {
                lbasiakastiedot.Items.Add(msdr1["etunimi"]);
                lbasiakastiedot.Items.Add(msdr1["sukunimi"]);
                lbasiakastiedot.Items.Add(msdr1["postinro"]);
                lbasiakastiedot.Items.Add(msdr1["lahiosoite"]);
                lbasiakastiedot.Items.Add(msdr1["email"]);
                lbasiakastiedot.Items.Add(msdr1["puhelinnro"]);

            }
            msq1.Dispose();
            msdr1.Close();

       


            MySqlCommand Sqlcomm2 = new MySqlCommand("SELECT mokki_id FROM mokki left join varaus on varaus.mokki_mokki_id = mokki.mokki_id left join asiakas on asiakas.asiakas_id = varaus.asiakas_id where asiakas.asiakas_id = @asiakasid", yhteys);

            Sqlcomm2.Parameters.AddWithValue("@asiakasid", asiakasidcb.Text);
            MySqlDataReader msdr2 = Sqlcomm2.ExecuteReader();
            while (msdr2.Read())
            {
                cbmokkitiedot.Text = msdr2["mokki_id"].ToString();
            }

            msdr2.Close();
            msdr2.Dispose();

            MySqlCommand msq = new MySqlCommand("Select * from mokki where mokki_id =@mokkiid ", yhteys);
            msq.Parameters.AddWithValue("@mokkiid", cbmokkitiedot.Text);
            MySqlDataReader msdr = msq.ExecuteReader();

            while (msdr.Read())
            {
                lbmokkitiedot.Items.Add(msdr["mokkinimi"]);
                lbmokkitiedot.Items.Add(msdr["katuosoite"]);
                lbmokkitiedot.Items.Add(msdr["postinro"]);
                lbmokkitiedot.Items.Add(msdr["hinta"]);
                lbmokkitiedot.Items.Add(msdr["henkilomaara"]);
                lbmokkitiedot.Items.Add(msdr["varustelu"]);

            }
            msq.Dispose();
            msdr.Close(); 


        }
    }

       
     
    
}
