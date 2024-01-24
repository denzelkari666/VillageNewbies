using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Google.Protobuf.WellKnownTypes;
using MySqlConnector;
using MySqlX.XDevAPI.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VillageNewbies
{
    public partial class FrmLaskutusTiedot : Form
    {
        public FrmLaskutusTiedot()
        {
            InitializeComponent();
           
        }
        MySqlConnection yhteys = new MySqlConnection("server=127.0.0.1; port=3307; Database=vn; uid=root; pwd=Ruutti; AllowUserVariables = True");
        
        private void Takaisin_bt_Click(object sender, EventArgs e)
        {
            Close();
        }
        

        private void FrmLaskutusTiedot_Load(object sender, EventArgs e)
        {
            yhteys.Open();
            cb_täyttö();





            // Täyttää varaus id cb:n 
            MySqlDataAdapter sda = new MySqlDataAdapter();
            MySqlCommand msc3 = new MySqlCommand("SELECT varaus_id FROM varaus", yhteys);
            sda.SelectCommand = msc3;
            DataTable dt4 = new DataTable();
            sda.Fill(dt4);
            cb_VarausID.DataSource = dt4;
            cb_VarausID.ValueMember = "varaus_id";



            //Luo laskut kansion tuleville laskuille
            string fileName = @"c:\laskut\";
            string directory = Path.GetDirectoryName(fileName);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
           


            

        }
        public void cb_täyttö()
        {

            //Täyttää ja päivittää olemassa olevat laskut valikkoa kun tehdään muutoksia.

            cb_File.Items.Clear();


            string[] textFiles = System.IO.Directory.GetFiles(@"c:\laskut", "*.txt");
            foreach (string file in textFiles)
            {

                string filename = file.Substring(file.LastIndexOf(@"\") + 1);
                string name = filename.Substring(0, filename.LastIndexOf(@"."));
                cb_File.Items.Add(name);
            }

        }


       

        private void cb_VarausID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Kun kohteen varaus id vaihdetaan päivitetään laskutiedot textbox.
            //Vaihtaa laskuun oikeat tiedot kun varaus id:ta vaihdetaan

            lb_lasku.Items.Clear();
            bt_PoistaLasku.Visible = false;
            bt_tulostalasku.Visible = false;







            // Täyttää laskuun "lasku" taulun tiedot tietokannasta
            MySqlCommand msq99 = new MySqlCommand("SELECT * FROM lasku WHERE varaus_id =@varaus_id", yhteys);
            msq99.Parameters.AddWithValue("@varaus_id", cb_VarausID.Text);
            MySqlDataReader msdri = msq99.ExecuteReader();

            while (msdri.Read())
            {
                lb_lasku.Items.Add("VillageNewbies");
                lb_lasku.Items.Add("Lasku");
                lb_lasku.Items.Add("Laskun ID : " + msdri["lasku_id"]);
                lb_lasku.Items.Add("Varauksen id : " + msdri["Varaus_id"]);
                lb_lasku.Items.Add("Tilinumero : F178 6470 6969 0787 24");
                lb_lasku.Items.Add("Viitenumero : 564651546");
                lb_lasku.Items.Add("Saaja : VillageNewbies");
                lb_lasku.Items.Add("Eräpäivä : " + DateTime.Now.AddDays(30));
                lb_lasku.Items.Add("Alv : " + msdri["alv"]);
                lb_lasku.Items.Add("Maksettava määrä : " + msdri["summa"] + " " + "euroa");
                lb_lasku.Items.Add("-------");

            }
            msq99.Dispose();
            msdri.Close();


            // Täyttää laskuun "asiakas" taulun tiedot tietokannasta
            MySqlCommand msq992 = new MySqlCommand("SELECT * FROM asiakas WHERE asiakas_id =@asiakas_id", yhteys);
            msq992.Parameters.AddWithValue("@asiakas_id", cb_VarausID.Text);
            MySqlDataReader msdriq = msq992.ExecuteReader();
            while (msdriq.Read())
            {
                
                lb_lasku.Items.Add("Maksaja : ");
                lb_lasku.Items.Add("Asiakas id : " + msdriq["asiakas_id"]);
                lb_lasku.Items.Add("Nimi : " + msdriq["etunimi"] + " " + msdriq["sukunimi"]);
                lb_lasku.Items.Add("Osoite : " + msdriq["lahiosoite"] + " , " + msdriq["postinro"]);
                lb_lasku.Items.Add("Puhelinnumero : " + msdriq["puhelinnro"]);
                lb_lasku.Items.Add("Email : " + msdriq["email"]);
                lb_lasku.Items.Add("-------");
                

            }
            msq992.Dispose();
            msdriq.Close();


            // Täyttää laskuun lisäpalvelut tiedot tietokannasta
            MySqlCommand msq999 = new MySqlCommand("SELECT * FROM varauksen_palvelut WHERE varaus_id =@varaus_id ", yhteys);
            msq999.Parameters.AddWithValue("@varaus_id", cb_VarausID.Text);
            MySqlDataReader msdrii = msq999.ExecuteReader();
            while (msdrii.Read())
            {
                lb_lasku.Items.Add("Lisäpalvelut : ");
                lb_lasku.Items.Add("Palvelu id : " + msdrii["palvelu_id"]);
                lb_lasku.Items.Add("varaus id : " + msdrii["varaus_id"]);
                lb_lasku.Items.Add("Palveluiden määrä : " + msdrii["lkm"]);
            }
            msq999.Dispose();
            msdrii.Close();








        }
        private void cb_File_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Voidaan katsoa olemassa olevia laskuja

            lb_lasku.Items.Clear();
            bt_PoistaLasku.Visible = true;
            bt_tulostalasku.Visible = true;

            lb_lasku.Items.Clear();

            
            string[] lines = File.ReadAllLines(@"c:\laskut\" + cb_File.SelectedItem.ToString() + ".txt");
            lb_lasku.Items.Add("Laskun tunnus : " + cb_File.SelectedItem.ToString());
            lb_lasku.Items.AddRange(lines);



        }

        private void bt_PoistaLasku_Click(object sender, EventArgs e)
        {
            //Poistaa valitun laskun tietokannasta
            //Poistaa valitun laskun kansiosta
            //Poistetut laskut menevät "roskakori" kansioon
            //Ei anna poistaa jos ei ole valittu laskua

            lb_lasku.Items.Clear();

            string sqlstatement = "DELETE FROM lasku WHERE varaus_id =@varaus_id";
            MySqlCommand cmd = new MySqlCommand(sqlstatement, yhteys);
            cmd.Parameters.AddWithValue("@varaus_id", cb_VarausID.Text);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();




            try
            {
                    if (string.IsNullOrEmpty(cb_File.Text))
                    {
                        MessageBox.Show("Valitse lasku!");
                    }
                    else
                    {

                        //poistaa laskun ja tallentaa varmuus kopion "roskakoriin"
                        MySqlCommand cmd5 = new MySqlCommand(sqlstatement, yhteys);
                        cmd5.Parameters.AddWithValue("@varaus_id", cb_VarausID.Text);
                        cmd5.CommandType = CommandType.Text;
                        cmd5.ExecuteNonQuery();

                        string f = @"c:\laskut\" + cb_File.SelectedItem.ToString() + ".txt";
                        File.Delete(f);

                        string fileName = @"c:\Roskakori\" + cb_File.SelectedItem.ToString() + ".txt";
                        string directory = Path.GetDirectoryName(fileName);
                        if (!Directory.Exists(directory))
                        {
                            Directory.CreateDirectory(directory);
                        }
                        FileStream FS = new FileStream(fileName, FileMode.Append);
                        using (StreamWriter sw = new StreamWriter(FS))
                        {
                            foreach (var item in lb_lasku.Items)
                            {
                                sw.WriteLine(item.ToString());
                            }

                        }
                        FS.Close();


                        //Poistaa laskun comboboxista
                        cb_File.Items.Remove(cb_File.SelectedItem);
                    }
            }
            catch(Exception ex)
            {
                    MessageBox.Show(ex.Message);
            }


        }

        

        private void bt_tallenna_Click(object sender, EventArgs e)
        {
      
            // Tallennetaan asiakkaan lasku 
            //Tallennetaan laskut "Laskut" kansioon
            //Luo jokaiselle laskulle uniikin nimen
            //Ja päivittää tallennetun laskun cb_file comboboxiin

            cb_File.Items.Clear();
            cb_File.Refresh();
            cb_täyttö();

            string fileName = @"c:\laskut\Lasku.txt";

            if (!File.Exists(fileName))
            {
                FileStream FS = new FileStream(fileName, FileMode.Append);
                using (StreamWriter sw = new StreamWriter(FS))
                {
                    foreach (var item in lb_lasku.Items)
                    {
                        sw.WriteLine(item.ToString());
                        
                    }

                }
                FS.Close();
            }
            else
            {
                // Luo laskuille joka kerta uniikin nimen Lasku.xxxxxxx.txt

                string result = Path.GetRandomFileName();
                Console.WriteLine(result);
                string fileName1 = @"c:\laskut\lasku." + result + ".txt";
                FileStream FS = new FileStream(fileName1, FileMode.Append);
                using (StreamWriter sw = new StreamWriter(FS))
                {
                    foreach (var item in lb_lasku.Items)
                    {
                        sw.WriteLine(item.ToString());
                       
                    }

                }
                FS.Close();

                

            }
        }
        private void bt_tulostalasku_Click(object sender, EventArgs e)
        {

            cb_File.Refresh();

           

            //Tulostetaan PDF lasku
            //Ei anna tulostaa jos ei ole valittu laskua
            //Cb_file combobox listasta voidaan valita mikä lasku halutaan tulostaa

            try
            {
                if (string.IsNullOrEmpty(cb_File.Text))
                {
                    MessageBox.Show("Valitse lasku!");
                }
                else
                {
                    Process p = new Process();
                    p.StartInfo = new ProcessStartInfo()
                    {

                        CreateNoWindow = true,
                        Verb = "print",
                        FileName = @"c:\laskut\" + cb_File.SelectedItem.ToString() + ".txt"

                    };
                    p.Start();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
           



        }

       
    }
}
