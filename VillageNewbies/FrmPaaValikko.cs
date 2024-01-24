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
            MessageBox.Show
            (" Olen lisännyt tämän kyseisen viestin projektiin jälkeenpäin \n \n" +
            "Tämä sovellus tehtiin ensimmäisen vuoden lopputyönä yhteistyössä neljän hengen ryhmässä.\n \n" +
            "Sovelluksen tarkoituksena oli perehdyttää opiskelijoita miten offline-sovellus saadaan toimimaan yhteistyössä paikallisen tietokannan kanssa," +
            "kuinka tietoa saadaan lisättyä, poistettua ja muokattua sovelluksessa. \n \n" +
            "Sovellus toteutettiin ohjelmistotuotannon kurssina,jonka vaatimuksina oli tuottaa vaatimustenmukainen sovellus eri toiminnallisuuksilla.\n" +
            "Lisäksi kurssivaatimuksina oli tuottaa tarvittavat dokumentit kuten vaatimusmäärittely, loppuraportti, projektikortti ja toiminnallinen määrittely. \n \n" +
            "Kuten sovellusta testatessa voi huomata se ei ole täydellinen. Kurssin yhtenä tarkoituksena oli perehdyttää opiskelijoita\n" +
            "arvioimaan ja toteuttamaan 'asiakkaan' edellyttämät vaatimukset tietyssä ajassa. Aikataulusta ei voinut tehdä poikkeusta. \n \n" +
            "Projektiryhmällämme, kuten monilla muillakin, loppui aika kesken ennen kuin asiakkaan asettamat vaatimukset oli täydellisesti toteutettu.\n \n" +
            "Ryhmämme sai tästä työstä arvosanaksi 4. Sovelluksesta puuttuu muutamia toiminnallisuuksia joiden suorittamiseksi ryhmältämme loppui aika kesken" +
            "(kuten esimerkiksi laskutustietoja ei saa tulostettua ja sovellus saattaa kaatua testauksen vähyyden vuoksi). \n \n" +
            "Projektissa jaoimme vastuualueet siten, että jokainen ryhmän jäsen työsti vähintäänkin yhtä toiminnallisuutta. Minun vastuuna oli huolehtia " +
            "'FrmVapaatMokit' formista joka avautuu 'Luo uusi varaus' napista. Formin toiminnallisuuksissa vaadittiin, että varauksista  menee tietokantaan vaaditut tiedot," +
            "kuten asiakkaan syöttämät tiedot, halutut palvelut, laskun summa ja ajankohta varaukselle. Lisäksi päällekkäiset varaukset kohteisiin eivät saaneet ole mahdollisia.\n \n" +
            "Mikäli sovellusta haluaa koeajaa tietokannan kanssa, tietokannan saa toimimaan 'server=127.0.0.1; port=3307; Database=vn; uid=root; pwd=Ruutti' tiedoilla.\n \n" +
            "Sovellusta koeajettiin HeidiSQL:ää, MariaDB:tä ja VisualStudio 2022 MySqlConnector NuGet:ia käyttäen.");
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
        private void button1_Click(object sender, EventArgs e)
        {
            //Avaa hyväksymis formin siirtyy tästä.

            FrmHyvaksyVaraus frmvaraus = new FrmHyvaksyVaraus();
            frmvaraus.Show();
        }
    }
   
}
