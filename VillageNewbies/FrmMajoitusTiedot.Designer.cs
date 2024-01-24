namespace VillageNewbies
{
    partial class FrmMajoitustiedot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.lbl_Majoitustiedot = new System.Windows.Forms.Label();
            this.Takaisin_bt = new System.Windows.Forms.Button();
            this.cb_AsiakasId = new System.Windows.Forms.ComboBox();
            this.lbl_AsiakasId = new System.Windows.Forms.Label();
            this.lbl_Etunimi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Sahkoposti = new System.Windows.Forms.TextBox();
            this.tb_Osoite = new System.Windows.Forms.TextBox();
            this.tb_PuhNo = new System.Windows.Forms.TextBox();
            this.lbl_Mokki = new System.Windows.Forms.Label();
            this.lbl_Sijainti = new System.Windows.Forms.Label();
            this.tb_Mokki = new System.Windows.Forms.TextBox();
            this.tb_AlkuPvm = new System.Windows.Forms.TextBox();
            this.lbl_Alku = new System.Windows.Forms.Label();
            this.tb_LoppuPvm = new System.Windows.Forms.TextBox();
            this.lbl_Loppu = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lbl_Lisapalvelut = new System.Windows.Forms.Label();
            this.tb_Posti = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_VarausPvm = new System.Windows.Forms.TextBox();
            this.tb_VarausID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_VarausID = new System.Windows.Forms.Label();
            this.tb_MokkiID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Henklkm = new System.Windows.Forms.TextBox();
            this.lbl_Henklkm = new System.Windows.Forms.Label();
            this.tb_LaskuID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_MokkiOsoite = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_LaskuHinta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_TallennaMuutokset = new System.Windows.Forms.Button();
            this.btn_MuutaTietoja = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_PoistaAsiakas = new System.Windows.Forms.Button();
            this.tb_Nimi = new System.Windows.Forms.TextBox();
            this.tb_Sijainti = new System.Windows.Forms.TextBox();
            this.tb_kuvaus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_Logo
            // 
            this.pb_Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_Logo.Image = global::VillageNewbies.Properties.Resources.VN_Icon;
            this.pb_Logo.Location = new System.Drawing.Point(0, 67);
            this.pb_Logo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(160, 141);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Logo.TabIndex = 15;
            this.pb_Logo.TabStop = false;
            // 
            // lbl_Majoitustiedot
            // 
            this.lbl_Majoitustiedot.AutoSize = true;
            this.lbl_Majoitustiedot.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Majoitustiedot.Location = new System.Drawing.Point(11, 13);
            this.lbl_Majoitustiedot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Majoitustiedot.Name = "lbl_Majoitustiedot";
            this.lbl_Majoitustiedot.Size = new System.Drawing.Size(333, 36);
            this.lbl_Majoitustiedot.TabIndex = 16;
            this.lbl_Majoitustiedot.Text = "Asiakas- ja Majoitustiedot";
            // 
            // Takaisin_bt
            // 
            this.Takaisin_bt.BackColor = System.Drawing.Color.Sienna;
            this.Takaisin_bt.FlatAppearance.BorderSize = 0;
            this.Takaisin_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Takaisin_bt.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Takaisin_bt.Location = new System.Drawing.Point(8, 493);
            this.Takaisin_bt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Takaisin_bt.Name = "Takaisin_bt";
            this.Takaisin_bt.Size = new System.Drawing.Size(134, 65);
            this.Takaisin_bt.TabIndex = 21;
            this.Takaisin_bt.Text = "Takaisin";
            this.Takaisin_bt.UseVisualStyleBackColor = false;
            this.Takaisin_bt.Click += new System.EventHandler(this.Takaisin_bt_Click);
            // 
            // cb_AsiakasId
            // 
            this.cb_AsiakasId.BackColor = System.Drawing.Color.Snow;
            this.cb_AsiakasId.FormattingEnabled = true;
            this.cb_AsiakasId.Location = new System.Drawing.Point(332, 96);
            this.cb_AsiakasId.Name = "cb_AsiakasId";
            this.cb_AsiakasId.Size = new System.Drawing.Size(166, 21);
            this.cb_AsiakasId.Sorted = true;
            this.cb_AsiakasId.TabIndex = 1;
            this.cb_AsiakasId.SelectedIndexChanged += new System.EventHandler(this.cb_AsiakasId_SelectedIndexChanged);
            // 
            // lbl_AsiakasId
            // 
            this.lbl_AsiakasId.AutoSize = true;
            this.lbl_AsiakasId.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AsiakasId.Location = new System.Drawing.Point(164, 95);
            this.lbl_AsiakasId.Name = "lbl_AsiakasId";
            this.lbl_AsiakasId.Size = new System.Drawing.Size(89, 22);
            this.lbl_AsiakasId.TabIndex = 19;
            this.lbl_AsiakasId.Text = "Asiakas ID";
            // 
            // lbl_Etunimi
            // 
            this.lbl_Etunimi.AutoSize = true;
            this.lbl_Etunimi.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Etunimi.Location = new System.Drawing.Point(165, 132);
            this.lbl_Etunimi.Name = "lbl_Etunimi";
            this.lbl_Etunimi.Size = new System.Drawing.Size(46, 22);
            this.lbl_Etunimi.TabIndex = 20;
            this.lbl_Etunimi.Text = "Nimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Sähköposti";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Osoite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "Puhelinnumero";
            // 
            // tb_Sahkoposti
            // 
            this.tb_Sahkoposti.BackColor = System.Drawing.Color.Snow;
            this.tb_Sahkoposti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Sahkoposti.Enabled = false;
            this.tb_Sahkoposti.Location = new System.Drawing.Point(332, 169);
            this.tb_Sahkoposti.Name = "tb_Sahkoposti";
            this.tb_Sahkoposti.Size = new System.Drawing.Size(166, 20);
            this.tb_Sahkoposti.TabIndex = 3;
            // 
            // tb_Osoite
            // 
            this.tb_Osoite.BackColor = System.Drawing.Color.Snow;
            this.tb_Osoite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Osoite.Enabled = false;
            this.tb_Osoite.Location = new System.Drawing.Point(332, 206);
            this.tb_Osoite.Name = "tb_Osoite";
            this.tb_Osoite.Size = new System.Drawing.Size(166, 20);
            this.tb_Osoite.TabIndex = 4;
            // 
            // tb_PuhNo
            // 
            this.tb_PuhNo.BackColor = System.Drawing.Color.Snow;
            this.tb_PuhNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_PuhNo.Enabled = false;
            this.tb_PuhNo.Location = new System.Drawing.Point(332, 282);
            this.tb_PuhNo.Name = "tb_PuhNo";
            this.tb_PuhNo.Size = new System.Drawing.Size(166, 20);
            this.tb_PuhNo.TabIndex = 6;
            this.tb_PuhNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_PuhNo_KeyPress);
            // 
            // lbl_Mokki
            // 
            this.lbl_Mokki.AutoSize = true;
            this.lbl_Mokki.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mokki.Location = new System.Drawing.Point(166, 318);
            this.lbl_Mokki.Name = "lbl_Mokki";
            this.lbl_Mokki.Size = new System.Drawing.Size(56, 22);
            this.lbl_Mokki.TabIndex = 31;
            this.lbl_Mokki.Text = "Mökki";
            // 
            // lbl_Sijainti
            // 
            this.lbl_Sijainti.AutoSize = true;
            this.lbl_Sijainti.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sijainti.Location = new System.Drawing.Point(166, 428);
            this.lbl_Sijainti.Name = "lbl_Sijainti";
            this.lbl_Sijainti.Size = new System.Drawing.Size(62, 22);
            this.lbl_Sijainti.TabIndex = 32;
            this.lbl_Sijainti.Text = "Sijainti";
            // 
            // tb_Mokki
            // 
            this.tb_Mokki.BackColor = System.Drawing.Color.Snow;
            this.tb_Mokki.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Mokki.Enabled = false;
            this.tb_Mokki.Location = new System.Drawing.Point(332, 318);
            this.tb_Mokki.Name = "tb_Mokki";
            this.tb_Mokki.Size = new System.Drawing.Size(166, 20);
            this.tb_Mokki.TabIndex = 7;
            // 
            // tb_AlkuPvm
            // 
            this.tb_AlkuPvm.BackColor = System.Drawing.Color.Snow;
            this.tb_AlkuPvm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_AlkuPvm.Enabled = false;
            this.tb_AlkuPvm.Location = new System.Drawing.Point(699, 171);
            this.tb_AlkuPvm.Name = "tb_AlkuPvm";
            this.tb_AlkuPvm.Size = new System.Drawing.Size(166, 20);
            this.tb_AlkuPvm.TabIndex = 13;
            this.tb_AlkuPvm.Tag = "1";
            // 
            // lbl_Alku
            // 
            this.lbl_Alku.AutoSize = true;
            this.lbl_Alku.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Alku.Location = new System.Drawing.Point(533, 169);
            this.lbl_Alku.Name = "lbl_Alku";
            this.lbl_Alku.Size = new System.Drawing.Size(154, 22);
            this.lbl_Alku.TabIndex = 35;
            this.lbl_Alku.Text = "Varauksen alkupvm";
            // 
            // tb_LoppuPvm
            // 
            this.tb_LoppuPvm.BackColor = System.Drawing.Color.Snow;
            this.tb_LoppuPvm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_LoppuPvm.Enabled = false;
            this.tb_LoppuPvm.Location = new System.Drawing.Point(699, 206);
            this.tb_LoppuPvm.Name = "tb_LoppuPvm";
            this.tb_LoppuPvm.Size = new System.Drawing.Size(166, 20);
            this.tb_LoppuPvm.TabIndex = 14;
            this.tb_LoppuPvm.Tag = "1";
            // 
            // lbl_Loppu
            // 
            this.lbl_Loppu.AutoSize = true;
            this.lbl_Loppu.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Loppu.Location = new System.Drawing.Point(533, 204);
            this.lbl_Loppu.Name = "lbl_Loppu";
            this.lbl_Loppu.Size = new System.Drawing.Size(162, 22);
            this.lbl_Loppu.TabIndex = 37;
            this.lbl_Loppu.Text = "Varauksen loppupvm";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1070, 24);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lbl_Lisapalvelut
            // 
            this.lbl_Lisapalvelut.AutoSize = true;
            this.lbl_Lisapalvelut.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lisapalvelut.Location = new System.Drawing.Point(533, 353);
            this.lbl_Lisapalvelut.Name = "lbl_Lisapalvelut";
            this.lbl_Lisapalvelut.Size = new System.Drawing.Size(102, 22);
            this.lbl_Lisapalvelut.TabIndex = 40;
            this.lbl_Lisapalvelut.Text = "Lisäpalvelut:";
            // 
            // tb_Posti
            // 
            this.tb_Posti.BackColor = System.Drawing.Color.Snow;
            this.tb_Posti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Posti.Enabled = false;
            this.tb_Posti.Location = new System.Drawing.Point(332, 245);
            this.tb_Posti.Name = "tb_Posti";
            this.tb_Posti.Size = new System.Drawing.Size(166, 20);
            this.tb_Posti.TabIndex = 5;
            this.tb_Posti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Posti_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 22);
            this.label1.TabIndex = 42;
            this.label1.Text = "Posti";
            // 
            // tb_VarausPvm
            // 
            this.tb_VarausPvm.BackColor = System.Drawing.Color.Snow;
            this.tb_VarausPvm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_VarausPvm.Enabled = false;
            this.tb_VarausPvm.Location = new System.Drawing.Point(699, 134);
            this.tb_VarausPvm.Name = "tb_VarausPvm";
            this.tb_VarausPvm.Size = new System.Drawing.Size(166, 20);
            this.tb_VarausPvm.TabIndex = 12;
            this.tb_VarausPvm.Tag = "1";
            // 
            // tb_VarausID
            // 
            this.tb_VarausID.BackColor = System.Drawing.Color.Snow;
            this.tb_VarausID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_VarausID.Enabled = false;
            this.tb_VarausID.Location = new System.Drawing.Point(699, 95);
            this.tb_VarausID.Name = "tb_VarausID";
            this.tb_VarausID.Size = new System.Drawing.Size(166, 20);
            this.tb_VarausID.TabIndex = 11;
            this.tb_VarausID.Tag = "";
            this.tb_VarausID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_VarausID_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(533, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 22);
            this.label5.TabIndex = 45;
            this.label5.Text = "Varauspvm";
            // 
            // lbl_VarausID
            // 
            this.lbl_VarausID.AutoSize = true;
            this.lbl_VarausID.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VarausID.Location = new System.Drawing.Point(533, 95);
            this.lbl_VarausID.Name = "lbl_VarausID";
            this.lbl_VarausID.Size = new System.Drawing.Size(83, 22);
            this.lbl_VarausID.TabIndex = 44;
            this.lbl_VarausID.Text = "Varaus ID";
            // 
            // tb_MokkiID
            // 
            this.tb_MokkiID.BackColor = System.Drawing.Color.Snow;
            this.tb_MokkiID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_MokkiID.Enabled = false;
            this.tb_MokkiID.Location = new System.Drawing.Point(332, 391);
            this.tb_MokkiID.Name = "tb_MokkiID";
            this.tb_MokkiID.Size = new System.Drawing.Size(166, 20);
            this.tb_MokkiID.TabIndex = 9;
            this.tb_MokkiID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_MokkiID_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(166, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 22);
            this.label6.TabIndex = 48;
            this.label6.Text = "Mökki ID";
            // 
            // tb_Henklkm
            // 
            this.tb_Henklkm.BackColor = System.Drawing.Color.Snow;
            this.tb_Henklkm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Henklkm.Enabled = false;
            this.tb_Henklkm.Location = new System.Drawing.Point(699, 249);
            this.tb_Henklkm.Name = "tb_Henklkm";
            this.tb_Henklkm.Size = new System.Drawing.Size(52, 20);
            this.tb_Henklkm.TabIndex = 15;
            this.tb_Henklkm.Tag = "1";
            // 
            // lbl_Henklkm
            // 
            this.lbl_Henklkm.AutoSize = true;
            this.lbl_Henklkm.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Henklkm.Location = new System.Drawing.Point(533, 249);
            this.lbl_Henklkm.Name = "lbl_Henklkm";
            this.lbl_Henklkm.Size = new System.Drawing.Size(147, 22);
            this.lbl_Henklkm.TabIndex = 50;
            this.lbl_Henklkm.Text = "Henkilöiden määrä";
            // 
            // tb_LaskuID
            // 
            this.tb_LaskuID.BackColor = System.Drawing.Color.Snow;
            this.tb_LaskuID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_LaskuID.Enabled = false;
            this.tb_LaskuID.Location = new System.Drawing.Point(699, 285);
            this.tb_LaskuID.Name = "tb_LaskuID";
            this.tb_LaskuID.Size = new System.Drawing.Size(166, 20);
            this.tb_LaskuID.TabIndex = 16;
            this.tb_LaskuID.Tag = "";
            this.tb_LaskuID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_LaskuID_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(533, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 22);
            this.label8.TabIndex = 52;
            this.label8.Text = "LaskuID";
            // 
            // tb_MokkiOsoite
            // 
            this.tb_MokkiOsoite.BackColor = System.Drawing.Color.Snow;
            this.tb_MokkiOsoite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_MokkiOsoite.Enabled = false;
            this.tb_MokkiOsoite.Location = new System.Drawing.Point(332, 353);
            this.tb_MokkiOsoite.Name = "tb_MokkiOsoite";
            this.tb_MokkiOsoite.Size = new System.Drawing.Size(166, 20);
            this.tb_MokkiOsoite.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(166, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 22);
            this.label7.TabIndex = 54;
            this.label7.Text = "Mökin osoite";
            // 
            // tb_LaskuHinta
            // 
            this.tb_LaskuHinta.BackColor = System.Drawing.Color.Snow;
            this.tb_LaskuHinta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_LaskuHinta.Enabled = false;
            this.tb_LaskuHinta.Location = new System.Drawing.Point(716, 434);
            this.tb_LaskuHinta.Name = "tb_LaskuHinta";
            this.tb_LaskuHinta.Size = new System.Drawing.Size(166, 20);
            this.tb_LaskuHinta.TabIndex = 57;
            this.tb_LaskuHinta.Tag = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(533, 432);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 22);
            this.label9.TabIndex = 56;
            this.label9.Text = "Laskutettava summa(?)";
            // 
            // btn_TallennaMuutokset
            // 
            this.btn_TallennaMuutokset.BackColor = System.Drawing.Color.Sienna;
            this.btn_TallennaMuutokset.FlatAppearance.BorderSize = 0;
            this.btn_TallennaMuutokset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TallennaMuutokset.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TallennaMuutokset.Location = new System.Drawing.Point(914, 471);
            this.btn_TallennaMuutokset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_TallennaMuutokset.Name = "btn_TallennaMuutokset";
            this.btn_TallennaMuutokset.Size = new System.Drawing.Size(145, 87);
            this.btn_TallennaMuutokset.TabIndex = 19;
            this.btn_TallennaMuutokset.Text = "Tallenna muutokset";
            this.btn_TallennaMuutokset.UseVisualStyleBackColor = false;
            this.btn_TallennaMuutokset.Click += new System.EventHandler(this.btn_TallennaMuutokset_Click);
            // 
            // btn_MuutaTietoja
            // 
            this.btn_MuutaTietoja.BackColor = System.Drawing.Color.Sienna;
            this.btn_MuutaTietoja.FlatAppearance.BorderSize = 0;
            this.btn_MuutaTietoja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MuutaTietoja.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MuutaTietoja.Location = new System.Drawing.Point(914, 384);
            this.btn_MuutaTietoja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_MuutaTietoja.Name = "btn_MuutaTietoja";
            this.btn_MuutaTietoja.Size = new System.Drawing.Size(145, 66);
            this.btn_MuutaTietoja.TabIndex = 18;
            this.btn_MuutaTietoja.Text = "Muuta tietoja";
            this.btn_MuutaTietoja.UseVisualStyleBackColor = false;
            this.btn_MuutaTietoja.Click += new System.EventHandler(this.btn_MuutaTietoja_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Controls.Add(this.lbl_Majoitustiedot);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 62);
            this.panel1.TabIndex = 62;
            // 
            // btn_PoistaAsiakas
            // 
            this.btn_PoistaAsiakas.BackColor = System.Drawing.Color.Sienna;
            this.btn_PoistaAsiakas.FlatAppearance.BorderSize = 0;
            this.btn_PoistaAsiakas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PoistaAsiakas.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PoistaAsiakas.Location = new System.Drawing.Point(736, 494);
            this.btn_PoistaAsiakas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_PoistaAsiakas.Name = "btn_PoistaAsiakas";
            this.btn_PoistaAsiakas.Size = new System.Drawing.Size(128, 64);
            this.btn_PoistaAsiakas.TabIndex = 20;
            this.btn_PoistaAsiakas.Text = "Poista asiakas";
            this.btn_PoistaAsiakas.UseVisualStyleBackColor = false;
            this.btn_PoistaAsiakas.Click += new System.EventHandler(this.btn_PoistaAsiakas_Click);
            // 
            // tb_Nimi
            // 
            this.tb_Nimi.BackColor = System.Drawing.Color.Snow;
            this.tb_Nimi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Nimi.Enabled = false;
            this.tb_Nimi.Location = new System.Drawing.Point(332, 134);
            this.tb_Nimi.Name = "tb_Nimi";
            this.tb_Nimi.Size = new System.Drawing.Size(166, 20);
            this.tb_Nimi.TabIndex = 65;
            this.tb_Nimi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Nimi_KeyPress);
            // 
            // tb_Sijainti
            // 
            this.tb_Sijainti.BackColor = System.Drawing.Color.Snow;
            this.tb_Sijainti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Sijainti.Enabled = false;
            this.tb_Sijainti.Location = new System.Drawing.Point(332, 432);
            this.tb_Sijainti.Name = "tb_Sijainti";
            this.tb_Sijainti.Size = new System.Drawing.Size(166, 20);
            this.tb_Sijainti.TabIndex = 66;
            // 
            // tb_kuvaus
            // 
            this.tb_kuvaus.Location = new System.Drawing.Point(680, 318);
            this.tb_kuvaus.Multiline = true;
            this.tb_kuvaus.Name = "tb_kuvaus";
            this.tb_kuvaus.Size = new System.Drawing.Size(213, 93);
            this.tb_kuvaus.TabIndex = 67;
            // 
            // FrmMajoitustiedot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1070, 569);
            this.Controls.Add(this.tb_kuvaus);
            this.Controls.Add(this.tb_Sijainti);
            this.Controls.Add(this.tb_Nimi);
            this.Controls.Add(this.btn_PoistaAsiakas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_TallennaMuutokset);
            this.Controls.Add(this.btn_MuutaTietoja);
            this.Controls.Add(this.tb_LaskuHinta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_MokkiOsoite);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_LaskuID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_Henklkm);
            this.Controls.Add(this.lbl_Henklkm);
            this.Controls.Add(this.tb_MokkiID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_VarausPvm);
            this.Controls.Add(this.tb_VarausID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_VarausID);
            this.Controls.Add(this.tb_Posti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Lisapalvelut);
            this.Controls.Add(this.tb_LoppuPvm);
            this.Controls.Add(this.lbl_Loppu);
            this.Controls.Add(this.tb_AlkuPvm);
            this.Controls.Add(this.lbl_Alku);
            this.Controls.Add(this.tb_Mokki);
            this.Controls.Add(this.lbl_Sijainti);
            this.Controls.Add(this.lbl_Mokki);
            this.Controls.Add(this.tb_PuhNo);
            this.Controls.Add(this.tb_Osoite);
            this.Controls.Add(this.tb_Sahkoposti);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Etunimi);
            this.Controls.Add(this.lbl_AsiakasId);
            this.Controls.Add(this.cb_AsiakasId);
            this.Controls.Add(this.Takaisin_bt);
            this.Controls.Add(this.pb_Logo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmMajoitustiedot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asiakas- ja majoitustiedot";
            this.Load += new System.EventHandler(this.FrmMajoitustiedot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Label lbl_Majoitustiedot;
        private System.Windows.Forms.Button Takaisin_bt;
        private System.Windows.Forms.ComboBox cb_AsiakasId;
        private System.Windows.Forms.Label lbl_AsiakasId;
        private System.Windows.Forms.Label lbl_Etunimi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Sahkoposti;
        private System.Windows.Forms.TextBox tb_Osoite;
        private System.Windows.Forms.TextBox tb_PuhNo;
        private System.Windows.Forms.Label lbl_Mokki;
        private System.Windows.Forms.Label lbl_Sijainti;
        private System.Windows.Forms.TextBox tb_Mokki;
        private System.Windows.Forms.TextBox tb_AlkuPvm;
        private System.Windows.Forms.Label lbl_Alku;
        private System.Windows.Forms.TextBox tb_LoppuPvm;
        private System.Windows.Forms.Label lbl_Loppu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lbl_Lisapalvelut;
        private System.Windows.Forms.TextBox tb_Posti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_VarausPvm;
        private System.Windows.Forms.TextBox tb_VarausID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_VarausID;
        private System.Windows.Forms.TextBox tb_MokkiID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Henklkm;
        private System.Windows.Forms.Label lbl_Henklkm;
        private System.Windows.Forms.TextBox tb_LaskuID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_MokkiOsoite;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_LaskuHinta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_TallennaMuutokset;
        private System.Windows.Forms.Button btn_MuutaTietoja;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_PoistaAsiakas;
        private System.Windows.Forms.TextBox tb_Nimi;
        private System.Windows.Forms.TextBox tb_Sijainti;
        private System.Windows.Forms.TextBox tb_kuvaus;
    }
}