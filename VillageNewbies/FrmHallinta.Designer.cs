namespace VillageNewbies
{
    partial class FrmHallinta
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
            this.btn_Takaisin = new System.Windows.Forms.Button();
            this.gb_VarausID = new System.Windows.Forms.GroupBox();
            this.tb_Asiakasid = new System.Windows.Forms.TextBox();
            this.lbl_AsiakasSnimi = new System.Windows.Forms.Label();
            this.lbl_AsiakasEnimi = new System.Windows.Forms.Label();
            this.tb_AsiakasSnimi = new System.Windows.Forms.TextBox();
            this.tb_AsiakasEnimi = new System.Windows.Forms.TextBox();
            this.cb_VarausID = new System.Windows.Forms.ComboBox();
            this.lbl_AsiakasID = new System.Windows.Forms.Label();
            this.lbl_VarausID = new System.Windows.Forms.Label();
            this.btn_PoistaVaraus = new System.Windows.Forms.Button();
            this.gb_LisaaMokki = new System.Windows.Forms.GroupBox();
            this.cb_Kaupunki = new System.Windows.Forms.ComboBox();
            this.tb_varustelu = new System.Windows.Forms.TextBox();
            this.tb_kuvaus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Henkmaara = new System.Windows.Forms.TextBox();
            this.lb_Henkmaara = new System.Windows.Forms.Label();
            this.tb_mokkiosoite = new System.Windows.Forms.TextBox();
            this.lb_osoite = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_postinro = new System.Windows.Forms.TextBox();
            this.tb_Kaupunki = new System.Windows.Forms.Label();
            this.btn_LisaaKohde = new System.Windows.Forms.Button();
            this.tb_MokkiHinta = new System.Windows.Forms.TextBox();
            this.Kuvaus_lb = new System.Windows.Forms.Label();
            this.lbl_Hinta = new System.Windows.Forms.Label();
            this.lbl_Nimi = new System.Windows.Forms.Label();
            this.tb_Nimi = new System.Windows.Forms.TextBox();
            this.gb_PoistaKohde = new System.Windows.Forms.GroupBox();
            this.lbl_Sijainti = new System.Windows.Forms.Label();
            this.tb_Mokkisijainti = new System.Windows.Forms.TextBox();
            this.tb_Mokki = new System.Windows.Forms.TextBox();
            this.tb_Mokintiedot = new System.Windows.Forms.TextBox();
            this.lbl_MokkID = new System.Windows.Forms.Label();
            this.cb_MokkiID = new System.Windows.Forms.ComboBox();
            this.lbl_Mokki = new System.Windows.Forms.Label();
            this.PoistaMokkiSijainti_lb = new System.Windows.Forms.Label();
            this.btn_PoistaKohde = new System.Windows.Forms.Button();
            this.lbl_Mokintiedot = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_VapaatMokit = new System.Windows.Forms.Label();
            this.lb_VillageNewbies = new System.Windows.Forms.Label();
            this.gb_VarausID.SuspendLayout();
            this.gb_LisaaMokki.SuspendLayout();
            this.gb_PoistaKohde.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Takaisin
            // 
            this.btn_Takaisin.BackColor = System.Drawing.Color.Sienna;
            this.btn_Takaisin.FlatAppearance.BorderSize = 0;
            this.btn_Takaisin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Takaisin.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Takaisin.Location = new System.Drawing.Point(13, 475);
            this.btn_Takaisin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Takaisin.Name = "btn_Takaisin";
            this.btn_Takaisin.Size = new System.Drawing.Size(109, 46);
            this.btn_Takaisin.TabIndex = 20;
            this.btn_Takaisin.Text = "Takaisin";
            this.btn_Takaisin.UseVisualStyleBackColor = false;
            this.btn_Takaisin.Click += new System.EventHandler(this.Takaisin_bt_Click);
            // 
            // gb_VarausID
            // 
            this.gb_VarausID.BackColor = System.Drawing.Color.MistyRose;
            this.gb_VarausID.Controls.Add(this.tb_Asiakasid);
            this.gb_VarausID.Controls.Add(this.lbl_AsiakasSnimi);
            this.gb_VarausID.Controls.Add(this.lbl_AsiakasEnimi);
            this.gb_VarausID.Controls.Add(this.tb_AsiakasSnimi);
            this.gb_VarausID.Controls.Add(this.tb_AsiakasEnimi);
            this.gb_VarausID.Controls.Add(this.cb_VarausID);
            this.gb_VarausID.Controls.Add(this.lbl_AsiakasID);
            this.gb_VarausID.Controls.Add(this.lbl_VarausID);
            this.gb_VarausID.Controls.Add(this.btn_PoistaVaraus);
            this.gb_VarausID.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_VarausID.Location = new System.Drawing.Point(480, 64);
            this.gb_VarausID.Name = "gb_VarausID";
            this.gb_VarausID.Size = new System.Drawing.Size(484, 228);
            this.gb_VarausID.TabIndex = 16;
            this.gb_VarausID.TabStop = false;
            this.gb_VarausID.Text = "Poista varaus";
            this.gb_VarausID.Enter += new System.EventHandler(this.gb_VarausID_Enter);
            // 
            // tb_Asiakasid
            // 
            this.tb_Asiakasid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Asiakasid.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Asiakasid.Location = new System.Drawing.Point(134, 75);
            this.tb_Asiakasid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Asiakasid.Name = "tb_Asiakasid";
            this.tb_Asiakasid.Size = new System.Drawing.Size(150, 26);
            this.tb_Asiakasid.TabIndex = 12;
            // 
            // lbl_AsiakasSnimi
            // 
            this.lbl_AsiakasSnimi.AutoSize = true;
            this.lbl_AsiakasSnimi.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AsiakasSnimi.Location = new System.Drawing.Point(29, 163);
            this.lbl_AsiakasSnimi.Name = "lbl_AsiakasSnimi";
            this.lbl_AsiakasSnimi.Size = new System.Drawing.Size(78, 22);
            this.lbl_AsiakasSnimi.TabIndex = 30;
            this.lbl_AsiakasSnimi.Text = "Sukunimi";
            // 
            // lbl_AsiakasEnimi
            // 
            this.lbl_AsiakasEnimi.AutoSize = true;
            this.lbl_AsiakasEnimi.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AsiakasEnimi.Location = new System.Drawing.Point(29, 119);
            this.lbl_AsiakasEnimi.Name = "lbl_AsiakasEnimi";
            this.lbl_AsiakasEnimi.Size = new System.Drawing.Size(67, 22);
            this.lbl_AsiakasEnimi.TabIndex = 29;
            this.lbl_AsiakasEnimi.Text = "Etunimi";
            // 
            // tb_AsiakasSnimi
            // 
            this.tb_AsiakasSnimi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_AsiakasSnimi.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_AsiakasSnimi.Location = new System.Drawing.Point(134, 160);
            this.tb_AsiakasSnimi.Name = "tb_AsiakasSnimi";
            this.tb_AsiakasSnimi.Size = new System.Drawing.Size(150, 26);
            this.tb_AsiakasSnimi.TabIndex = 14;
            // 
            // tb_AsiakasEnimi
            // 
            this.tb_AsiakasEnimi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_AsiakasEnimi.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_AsiakasEnimi.Location = new System.Drawing.Point(134, 115);
            this.tb_AsiakasEnimi.Name = "tb_AsiakasEnimi";
            this.tb_AsiakasEnimi.Size = new System.Drawing.Size(150, 26);
            this.tb_AsiakasEnimi.TabIndex = 13;
            // 
            // cb_VarausID
            // 
            this.cb_VarausID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_VarausID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_VarausID.FormattingEnabled = true;
            this.cb_VarausID.Location = new System.Drawing.Point(134, 37);
            this.cb_VarausID.Name = "cb_VarausID";
            this.cb_VarausID.Size = new System.Drawing.Size(151, 24);
            this.cb_VarausID.TabIndex = 11;
            this.cb_VarausID.SelectedIndexChanged += new System.EventHandler(this.cb_VarausID_SelectedIndexChanged);
            // 
            // lbl_AsiakasID
            // 
            this.lbl_AsiakasID.AutoSize = true;
            this.lbl_AsiakasID.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AsiakasID.Location = new System.Drawing.Point(26, 77);
            this.lbl_AsiakasID.Name = "lbl_AsiakasID";
            this.lbl_AsiakasID.Size = new System.Drawing.Size(86, 22);
            this.lbl_AsiakasID.TabIndex = 12;
            this.lbl_AsiakasID.Text = "AsiakasID";
            // 
            // lbl_VarausID
            // 
            this.lbl_VarausID.AutoSize = true;
            this.lbl_VarausID.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VarausID.Location = new System.Drawing.Point(26, 37);
            this.lbl_VarausID.Name = "lbl_VarausID";
            this.lbl_VarausID.Size = new System.Drawing.Size(80, 22);
            this.lbl_VarausID.TabIndex = 11;
            this.lbl_VarausID.Text = "VarausID";
            // 
            // btn_PoistaVaraus
            // 
            this.btn_PoistaVaraus.BackColor = System.Drawing.Color.Sienna;
            this.btn_PoistaVaraus.FlatAppearance.BorderSize = 0;
            this.btn_PoistaVaraus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PoistaVaraus.Location = new System.Drawing.Point(325, 163);
            this.btn_PoistaVaraus.Name = "btn_PoistaVaraus";
            this.btn_PoistaVaraus.Size = new System.Drawing.Size(143, 38);
            this.btn_PoistaVaraus.TabIndex = 15;
            this.btn_PoistaVaraus.Text = "Poista varaus";
            this.btn_PoistaVaraus.UseVisualStyleBackColor = false;
            this.btn_PoistaVaraus.Click += new System.EventHandler(this.btn_PoistaVaraus_Click);
            // 
            // gb_LisaaMokki
            // 
            this.gb_LisaaMokki.BackColor = System.Drawing.Color.MistyRose;
            this.gb_LisaaMokki.Controls.Add(this.cb_Kaupunki);
            this.gb_LisaaMokki.Controls.Add(this.tb_varustelu);
            this.gb_LisaaMokki.Controls.Add(this.tb_kuvaus);
            this.gb_LisaaMokki.Controls.Add(this.label3);
            this.gb_LisaaMokki.Controls.Add(this.btn_Takaisin);
            this.gb_LisaaMokki.Controls.Add(this.tb_Henkmaara);
            this.gb_LisaaMokki.Controls.Add(this.lb_Henkmaara);
            this.gb_LisaaMokki.Controls.Add(this.tb_mokkiosoite);
            this.gb_LisaaMokki.Controls.Add(this.lb_osoite);
            this.gb_LisaaMokki.Controls.Add(this.label2);
            this.gb_LisaaMokki.Controls.Add(this.tb_postinro);
            this.gb_LisaaMokki.Controls.Add(this.tb_Kaupunki);
            this.gb_LisaaMokki.Controls.Add(this.btn_LisaaKohde);
            this.gb_LisaaMokki.Controls.Add(this.tb_MokkiHinta);
            this.gb_LisaaMokki.Controls.Add(this.Kuvaus_lb);
            this.gb_LisaaMokki.Controls.Add(this.lbl_Hinta);
            this.gb_LisaaMokki.Controls.Add(this.lbl_Nimi);
            this.gb_LisaaMokki.Controls.Add(this.tb_Nimi);
            this.gb_LisaaMokki.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_LisaaMokki.Location = new System.Drawing.Point(12, 64);
            this.gb_LisaaMokki.Name = "gb_LisaaMokki";
            this.gb_LisaaMokki.Size = new System.Drawing.Size(462, 535);
            this.gb_LisaaMokki.TabIndex = 17;
            this.gb_LisaaMokki.TabStop = false;
            this.gb_LisaaMokki.Text = "Lisää mökki";
            // 
            // cb_Kaupunki
            // 
            this.cb_Kaupunki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Kaupunki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Kaupunki.FormattingEnabled = true;
            this.cb_Kaupunki.Location = new System.Drawing.Point(221, 47);
            this.cb_Kaupunki.Name = "cb_Kaupunki";
            this.cb_Kaupunki.Size = new System.Drawing.Size(182, 24);
            this.cb_Kaupunki.TabIndex = 31;
            this.cb_Kaupunki.SelectedIndexChanged += new System.EventHandler(this.cb_Kaupunki_SelectedIndexChanged);
            // 
            // tb_varustelu
            // 
            this.tb_varustelu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_varustelu.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_varustelu.Location = new System.Drawing.Point(221, 375);
            this.tb_varustelu.Name = "tb_varustelu";
            this.tb_varustelu.Size = new System.Drawing.Size(182, 26);
            this.tb_varustelu.TabIndex = 9;
            // 
            // tb_kuvaus
            // 
            this.tb_kuvaus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_kuvaus.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_kuvaus.Location = new System.Drawing.Point(221, 328);
            this.tb_kuvaus.Name = "tb_kuvaus";
            this.tb_kuvaus.Size = new System.Drawing.Size(182, 26);
            this.tb_kuvaus.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Varustelu";
            // 
            // tb_Henkmaara
            // 
            this.tb_Henkmaara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Henkmaara.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Henkmaara.Location = new System.Drawing.Point(221, 281);
            this.tb_Henkmaara.Name = "tb_Henkmaara";
            this.tb_Henkmaara.Size = new System.Drawing.Size(182, 26);
            this.tb_Henkmaara.TabIndex = 7;
            this.tb_Henkmaara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Henkmaara_KeyPress);
            // 
            // lb_Henkmaara
            // 
            this.lb_Henkmaara.AutoSize = true;
            this.lb_Henkmaara.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Henkmaara.Location = new System.Drawing.Point(20, 280);
            this.lb_Henkmaara.Name = "lb_Henkmaara";
            this.lb_Henkmaara.Size = new System.Drawing.Size(142, 24);
            this.lb_Henkmaara.TabIndex = 22;
            this.lb_Henkmaara.Text = "Henkmaara max";
            // 
            // tb_mokkiosoite
            // 
            this.tb_mokkiosoite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_mokkiosoite.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mokkiosoite.Location = new System.Drawing.Point(221, 187);
            this.tb_mokkiosoite.Name = "tb_mokkiosoite";
            this.tb_mokkiosoite.Size = new System.Drawing.Size(182, 26);
            this.tb_mokkiosoite.TabIndex = 5;
            // 
            // lb_osoite
            // 
            this.lb_osoite.AutoSize = true;
            this.lb_osoite.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_osoite.Location = new System.Drawing.Point(20, 186);
            this.lb_osoite.Name = "lb_osoite";
            this.lb_osoite.Size = new System.Drawing.Size(61, 24);
            this.lb_osoite.TabIndex = 20;
            this.lb_osoite.Text = "Osoite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Postinro";
            // 
            // tb_postinro
            // 
            this.tb_postinro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_postinro.Enabled = false;
            this.tb_postinro.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_postinro.Location = new System.Drawing.Point(221, 93);
            this.tb_postinro.Name = "tb_postinro";
            this.tb_postinro.Size = new System.Drawing.Size(182, 26);
            this.tb_postinro.TabIndex = 3;
            // 
            // tb_Kaupunki
            // 
            this.tb_Kaupunki.AutoSize = true;
            this.tb_Kaupunki.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Kaupunki.Location = new System.Drawing.Point(18, 46);
            this.tb_Kaupunki.Name = "tb_Kaupunki";
            this.tb_Kaupunki.Size = new System.Drawing.Size(88, 24);
            this.tb_Kaupunki.TabIndex = 16;
            this.tb_Kaupunki.Text = "Kaupunki";
            // 
            // btn_LisaaKohde
            // 
            this.btn_LisaaKohde.BackColor = System.Drawing.Color.Sienna;
            this.btn_LisaaKohde.FlatAppearance.BorderSize = 0;
            this.btn_LisaaKohde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LisaaKohde.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LisaaKohde.Location = new System.Drawing.Point(269, 475);
            this.btn_LisaaKohde.Name = "btn_LisaaKohde";
            this.btn_LisaaKohde.Size = new System.Drawing.Size(168, 46);
            this.btn_LisaaKohde.TabIndex = 10;
            this.btn_LisaaKohde.Text = "Lisää uusi kohde";
            this.btn_LisaaKohde.UseVisualStyleBackColor = false;
            this.btn_LisaaKohde.Click += new System.EventHandler(this.btn_LisaaKohde_Click);
            // 
            // tb_MokkiHinta
            // 
            this.tb_MokkiHinta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_MokkiHinta.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MokkiHinta.Location = new System.Drawing.Point(221, 234);
            this.tb_MokkiHinta.Name = "tb_MokkiHinta";
            this.tb_MokkiHinta.Size = new System.Drawing.Size(182, 26);
            this.tb_MokkiHinta.TabIndex = 6;
            this.tb_MokkiHinta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_MokkiHinta_KeyPress);
            // 
            // Kuvaus_lb
            // 
            this.Kuvaus_lb.AutoSize = true;
            this.Kuvaus_lb.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kuvaus_lb.Location = new System.Drawing.Point(22, 327);
            this.Kuvaus_lb.Name = "Kuvaus_lb";
            this.Kuvaus_lb.Size = new System.Drawing.Size(68, 24);
            this.Kuvaus_lb.TabIndex = 11;
            this.Kuvaus_lb.Text = "Kuvaus";
            // 
            // lbl_Hinta
            // 
            this.lbl_Hinta.AutoSize = true;
            this.lbl_Hinta.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hinta.Location = new System.Drawing.Point(20, 233);
            this.lbl_Hinta.Name = "lbl_Hinta";
            this.lbl_Hinta.Size = new System.Drawing.Size(96, 24);
            this.lbl_Hinta.TabIndex = 10;
            this.lbl_Hinta.Text = "Hinta/pvä";
            // 
            // lbl_Nimi
            // 
            this.lbl_Nimi.AutoSize = true;
            this.lbl_Nimi.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nimi.Location = new System.Drawing.Point(20, 139);
            this.lbl_Nimi.Name = "lbl_Nimi";
            this.lbl_Nimi.Size = new System.Drawing.Size(49, 24);
            this.lbl_Nimi.TabIndex = 2;
            this.lbl_Nimi.Text = "Nimi";
            // 
            // tb_Nimi
            // 
            this.tb_Nimi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Nimi.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Nimi.Location = new System.Drawing.Point(221, 140);
            this.tb_Nimi.Name = "tb_Nimi";
            this.tb_Nimi.Size = new System.Drawing.Size(182, 26);
            this.tb_Nimi.TabIndex = 4;
            // 
            // gb_PoistaKohde
            // 
            this.gb_PoistaKohde.BackColor = System.Drawing.Color.MistyRose;
            this.gb_PoistaKohde.Controls.Add(this.lbl_Sijainti);
            this.gb_PoistaKohde.Controls.Add(this.tb_Mokkisijainti);
            this.gb_PoistaKohde.Controls.Add(this.tb_Mokki);
            this.gb_PoistaKohde.Controls.Add(this.tb_Mokintiedot);
            this.gb_PoistaKohde.Controls.Add(this.lbl_MokkID);
            this.gb_PoistaKohde.Controls.Add(this.cb_MokkiID);
            this.gb_PoistaKohde.Controls.Add(this.lbl_Mokki);
            this.gb_PoistaKohde.Controls.Add(this.PoistaMokkiSijainti_lb);
            this.gb_PoistaKohde.Controls.Add(this.btn_PoistaKohde);
            this.gb_PoistaKohde.Controls.Add(this.lbl_Mokintiedot);
            this.gb_PoistaKohde.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_PoistaKohde.Location = new System.Drawing.Point(480, 298);
            this.gb_PoistaKohde.Name = "gb_PoistaKohde";
            this.gb_PoistaKohde.Size = new System.Drawing.Size(484, 301);
            this.gb_PoistaKohde.TabIndex = 18;
            this.gb_PoistaKohde.TabStop = false;
            this.gb_PoistaKohde.Text = "Poista kohde";
            // 
            // lbl_Sijainti
            // 
            this.lbl_Sijainti.AutoSize = true;
            this.lbl_Sijainti.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sijainti.Location = new System.Drawing.Point(18, 66);
            this.lbl_Sijainti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Sijainti.Name = "lbl_Sijainti";
            this.lbl_Sijainti.Size = new System.Drawing.Size(62, 22);
            this.lbl_Sijainti.TabIndex = 34;
            this.lbl_Sijainti.Text = "Sijainti";
            // 
            // tb_Mokkisijainti
            // 
            this.tb_Mokkisijainti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Mokkisijainti.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mokkisijainti.Location = new System.Drawing.Point(134, 64);
            this.tb_Mokkisijainti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Mokkisijainti.Name = "tb_Mokkisijainti";
            this.tb_Mokkisijainti.Size = new System.Drawing.Size(151, 26);
            this.tb_Mokkisijainti.TabIndex = 17;
            // 
            // tb_Mokki
            // 
            this.tb_Mokki.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Mokki.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mokki.Location = new System.Drawing.Point(134, 102);
            this.tb_Mokki.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Mokki.Name = "tb_Mokki";
            this.tb_Mokki.Size = new System.Drawing.Size(151, 26);
            this.tb_Mokki.TabIndex = 18;
            // 
            // tb_Mokintiedot
            // 
            this.tb_Mokintiedot.Location = new System.Drawing.Point(106, 141);
            this.tb_Mokintiedot.Multiline = true;
            this.tb_Mokintiedot.Name = "tb_Mokintiedot";
            this.tb_Mokintiedot.Size = new System.Drawing.Size(338, 83);
            this.tb_Mokintiedot.TabIndex = 0;
            // 
            // lbl_MokkID
            // 
            this.lbl_MokkID.AutoSize = true;
            this.lbl_MokkID.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MokkID.Location = new System.Drawing.Point(16, 30);
            this.lbl_MokkID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MokkID.Name = "lbl_MokkID";
            this.lbl_MokkID.Size = new System.Drawing.Size(74, 22);
            this.lbl_MokkID.TabIndex = 14;
            this.lbl_MokkID.Text = "MökkiID";
            // 
            // cb_MokkiID
            // 
            this.cb_MokkiID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_MokkiID.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_MokkiID.FormattingEnabled = true;
            this.cb_MokkiID.Location = new System.Drawing.Point(134, 31);
            this.cb_MokkiID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_MokkiID.Name = "cb_MokkiID";
            this.cb_MokkiID.Size = new System.Drawing.Size(151, 24);
            this.cb_MokkiID.TabIndex = 16;
            this.cb_MokkiID.SelectedIndexChanged += new System.EventHandler(this.cb_MokkiID_SelectedIndexChanged);
            // 
            // lbl_Mokki
            // 
            this.lbl_Mokki.AutoSize = true;
            this.lbl_Mokki.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mokki.Location = new System.Drawing.Point(16, 103);
            this.lbl_Mokki.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Mokki.Name = "lbl_Mokki";
            this.lbl_Mokki.Size = new System.Drawing.Size(56, 22);
            this.lbl_Mokki.TabIndex = 12;
            this.lbl_Mokki.Text = "Mökki";
            // 
            // PoistaMokkiSijainti_lb
            // 
            this.PoistaMokkiSijainti_lb.Location = new System.Drawing.Point(16, 32);
            this.PoistaMokkiSijainti_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PoistaMokkiSijainti_lb.Name = "PoistaMokkiSijainti_lb";
            this.PoistaMokkiSijainti_lb.Size = new System.Drawing.Size(62, 22);
            this.PoistaMokkiSijainti_lb.TabIndex = 10;
            // 
            // btn_PoistaKohde
            // 
            this.btn_PoistaKohde.BackColor = System.Drawing.Color.Sienna;
            this.btn_PoistaKohde.FlatAppearance.BorderSize = 0;
            this.btn_PoistaKohde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PoistaKohde.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PoistaKohde.Location = new System.Drawing.Point(325, 248);
            this.btn_PoistaKohde.Name = "btn_PoistaKohde";
            this.btn_PoistaKohde.Size = new System.Drawing.Size(143, 40);
            this.btn_PoistaKohde.TabIndex = 19;
            this.btn_PoistaKohde.Text = "Poista kohde";
            this.btn_PoistaKohde.UseVisualStyleBackColor = false;
            this.btn_PoistaKohde.Click += new System.EventHandler(this.btn_PoistaKohde_Click);
            // 
            // lbl_Mokintiedot
            // 
            this.lbl_Mokintiedot.AutoSize = true;
            this.lbl_Mokintiedot.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mokintiedot.Location = new System.Drawing.Point(4, 172);
            this.lbl_Mokintiedot.Name = "lbl_Mokintiedot";
            this.lbl_Mokintiedot.Size = new System.Drawing.Size(101, 22);
            this.lbl_Mokintiedot.TabIndex = 0;
            this.lbl_Mokintiedot.Text = "Mökin tiedot";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Sienna;
            this.panel2.Controls.Add(this.lbl_VapaatMokit);
            this.panel2.Controls.Add(this.lb_VillageNewbies);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 58);
            this.panel2.TabIndex = 20;
            // 
            // lbl_VapaatMokit
            // 
            this.lbl_VapaatMokit.AutoSize = true;
            this.lbl_VapaatMokit.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VapaatMokit.Location = new System.Drawing.Point(19, 9);
            this.lbl_VapaatMokit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_VapaatMokit.Name = "lbl_VapaatMokit";
            this.lbl_VapaatMokit.Size = new System.Drawing.Size(250, 36);
            this.lbl_VapaatMokit.TabIndex = 22;
            this.lbl_VapaatMokit.Text = "Kohteiden Hallinta";
            // 
            // lb_VillageNewbies
            // 
            this.lb_VillageNewbies.AutoSize = true;
            this.lb_VillageNewbies.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_VillageNewbies.Location = new System.Drawing.Point(11, 9);
            this.lb_VillageNewbies.Name = "lb_VillageNewbies";
            this.lb_VillageNewbies.Size = new System.Drawing.Size(0, 36);
            this.lb_VillageNewbies.TabIndex = 21;
            // 
            // FrmHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(977, 608);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gb_VarausID);
            this.Controls.Add(this.gb_PoistaKohde);
            this.Controls.Add(this.gb_LisaaMokki);
            this.Name = "FrmHallinta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mökkien hallinta";
            this.Load += new System.EventHandler(this.FrmHallinta_Load);
            this.gb_VarausID.ResumeLayout(false);
            this.gb_VarausID.PerformLayout();
            this.gb_LisaaMokki.ResumeLayout(false);
            this.gb_LisaaMokki.PerformLayout();
            this.gb_PoistaKohde.ResumeLayout(false);
            this.gb_PoistaKohde.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Takaisin;
        private System.Windows.Forms.GroupBox gb_VarausID;
        private System.Windows.Forms.Button btn_PoistaVaraus;
        private System.Windows.Forms.GroupBox gb_LisaaMokki;
        private System.Windows.Forms.Label lbl_Nimi;
        private System.Windows.Forms.TextBox tb_Nimi;
        private System.Windows.Forms.Label Kuvaus_lb;
        private System.Windows.Forms.Label lbl_Hinta;
        private System.Windows.Forms.TextBox tb_MokkiHinta;
        private System.Windows.Forms.Button btn_LisaaKohde;
        private System.Windows.Forms.GroupBox gb_PoistaKohde;
        private System.Windows.Forms.Button btn_PoistaKohde;
        private System.Windows.Forms.Label lbl_Mokintiedot;
        private System.Windows.Forms.Label lbl_VarausID;
        private System.Windows.Forms.Label lbl_Mokki;
        private System.Windows.Forms.Label PoistaMokkiSijainti_lb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_VillageNewbies;
        private System.Windows.Forms.Label lbl_MokkID;
        private System.Windows.Forms.ComboBox cb_MokkiID;
        private System.Windows.Forms.ComboBox cb_VarausID;
        private System.Windows.Forms.Label lbl_AsiakasID;
        private System.Windows.Forms.Label tb_Kaupunki;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_postinro;
        private System.Windows.Forms.TextBox tb_mokkiosoite;
        private System.Windows.Forms.Label lb_osoite;
        private System.Windows.Forms.TextBox tb_Henkmaara;
        private System.Windows.Forms.Label lb_Henkmaara;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_varustelu;
        private System.Windows.Forms.TextBox tb_kuvaus;
        private System.Windows.Forms.TextBox tb_Mokintiedot;
        private System.Windows.Forms.TextBox tb_AsiakasSnimi;
        private System.Windows.Forms.TextBox tb_AsiakasEnimi;
        private System.Windows.Forms.Label lbl_AsiakasSnimi;
        private System.Windows.Forms.Label lbl_AsiakasEnimi;
        private System.Windows.Forms.TextBox tb_Asiakasid;
        private System.Windows.Forms.TextBox tb_Mokkisijainti;
        private System.Windows.Forms.TextBox tb_Mokki;
        private System.Windows.Forms.Label lbl_Sijainti;
        private System.Windows.Forms.Label lbl_VapaatMokit;
        private System.Windows.Forms.ComboBox cb_Kaupunki;
    }
}