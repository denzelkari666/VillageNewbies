using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using MySqlX.XDevAPI.Common;


namespace VillageNewbies
{
    public partial class FrmPaaValikko : Form
    {
        public FrmPaaValikko()
        {
            InitializeComponent();
        }
        // Luodaan sql yhteys

        MySqlConnection yhteys = new MySqlConnection("server=127.0.0.1; port=3307; Database=vn; uid=root; pwd=Ruutti");

        private void FrmPaaValikko_Load(object sender, EventArgs e)
        {
            yhteys.Open();
        }

    
     

        private void btn_Laskutustiedot_Click(object sender, EventArgs e)
        {
            // Avaa laskutustiedot formin
            FrmLaskutusTiedot frmLaskutusTiedot = new FrmLaskutusTiedot();
            frmLaskutusTiedot.Show();
        }

        private void btn_Majoitustiedot_Click(object sender, EventArgs e)
        {
            // Avaa Majoitustiedot formin
            FrmMajoitustiedot frmMajoitusTiedot = new FrmMajoitustiedot();
            frmMajoitusTiedot.Show();
        }


        private void btn_MokinVaraus_Click(object sender, EventArgs e)
        {
            // Avaa FrmVapaaMokit formin
            yhteys.Close();
            FrmVaraus frmVapaatmokit = new FrmVaraus();
            frmVapaatmokit.Show();
        }

        private void btn_Hallinta_Click(object sender, EventArgs e)
        {
            // Avaa hallinta formin
            FrmHallinta frmHallinta = new FrmHallinta();
            frmHallinta.Show();
        }

        private void btn_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void pl_vasen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Avaa hyväksymis formin siirtyy tästä.

            FrmHyvaksyVaraus frmvaraus = new FrmHyvaksyVaraus();
            frmvaraus.Show();
        }
    }
   
}
