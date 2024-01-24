namespace VillageNewbies
{
    partial class FrmVaraus
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
            this.lbl_VapaatMokit = new System.Windows.Forms.Label();
            this.cb_VapaatMokit = new System.Windows.Forms.ComboBox();
            this.Mokit_lb = new System.Windows.Forms.Label();
            this.rtb_MokkiTiedot = new System.Windows.Forms.RichTextBox();
            this.btn_HyvaksyVarays = new System.Windows.Forms.Button();
            this.gb_Asiakastiedot = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Sukunimi = new System.Windows.Forms.TextBox();
            this.dtp_Lahtopvm = new System.Windows.Forms.DateTimePicker();
            this.lbl_Postinro = new System.Windows.Forms.Label();
            this.dtp_Saapumispvm = new System.Windows.Forms.DateTimePicker();
            this.tb_Postinro = new System.Windows.Forms.TextBox();
            this.lbl_LahtoPvm = new System.Windows.Forms.Label();
            this.lbl_SaapumisPvm = new System.Windows.Forms.Label();
            this.lbl_PuhNo = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Osoite = new System.Windows.Forms.Label();
            this.lbl_Nimi = new System.Windows.Forms.Label();
            this.tb_PuhNo = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_Osoite = new System.Windows.Forms.TextBox();
            this.tb_Etunimi = new System.Windows.Forms.TextBox();
            this.tb_Henklkm = new System.Windows.Forms.TextBox();
            this.lbl_HenkMaara = new System.Windows.Forms.Label();
            this.clb_Lisapalvelut = new System.Windows.Forms.CheckedListBox();
            this.lb_Sijainti = new System.Windows.Forms.Label();
            this.mc_Varaus = new System.Windows.Forms.MonthCalendar();
            this.lbl_MokkiID = new System.Windows.Forms.Label();
            this.tb_MokkiID = new System.Windows.Forms.TextBox();
            this.lbl_Ajankohta = new System.Windows.Forms.Label();
            this.gb_KohteenLisatiedot = new System.Windows.Forms.GroupBox();
            this.lbl_Varustelu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtb_Mokkivarustelu = new System.Windows.Forms.RichTextBox();
            this.tb_AlueID = new System.Windows.Forms.TextBox();
            this.gb_Ajankohta = new System.Windows.Forms.GroupBox();
            this.tb_Sijainti = new System.Windows.Forms.TextBox();
            this.lbl_Lisapalvelut = new System.Windows.Forms.Label();
            this.btn_Takaisin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_HyvaksyVarauksia = new System.Windows.Forms.Button();
            this.tb_hinta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_Asiakastiedot.SuspendLayout();
            this.gb_KohteenLisatiedot.SuspendLayout();
            this.gb_Ajankohta.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_VapaatMokit
            // 
            this.lbl_VapaatMokit.AutoSize = true;
            this.lbl_VapaatMokit.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VapaatMokit.Location = new System.Drawing.Point(10, 11);
            this.lbl_VapaatMokit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_VapaatMokit.Name = "lbl_VapaatMokit";
            this.lbl_VapaatMokit.Size = new System.Drawing.Size(270, 36);
            this.lbl_VapaatMokit.TabIndex = 0;
            this.lbl_VapaatMokit.Text = "Mökkien varaaminen";
            // 
            // cb_VapaatMokit
            // 
            this.cb_VapaatMokit.FormattingEnabled = true;
            this.cb_VapaatMokit.Location = new System.Drawing.Point(34, 245);
            this.cb_VapaatMokit.Margin = new System.Windows.Forms.Padding(2);
            this.cb_VapaatMokit.Name = "cb_VapaatMokit";
            this.cb_VapaatMokit.Size = new System.Drawing.Size(175, 32);
            this.cb_VapaatMokit.Sorted = true;
            this.cb_VapaatMokit.TabIndex = 2;
            this.cb_VapaatMokit.SelectedIndexChanged += new System.EventHandler(this.cb_VapaatMokit_SelectedIndexChanged);
            // 
            // Mokit_lb
            // 
            this.Mokit_lb.AutoSize = true;
            this.Mokit_lb.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mokit_lb.Location = new System.Drawing.Point(30, 210);
            this.Mokit_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Mokit_lb.Name = "Mokit_lb";
            this.Mokit_lb.Size = new System.Drawing.Size(192, 22);
            this.Mokit_lb.TabIndex = 4;
            this.Mokit_lb.Text = "Saatavilla olevat kohteet:";
            // 
            // rtb_MokkiTiedot
            // 
            this.rtb_MokkiTiedot.BackColor = System.Drawing.Color.Snow;
            this.rtb_MokkiTiedot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_MokkiTiedot.Enabled = false;
            this.rtb_MokkiTiedot.Location = new System.Drawing.Point(5, 23);
            this.rtb_MokkiTiedot.Margin = new System.Windows.Forms.Padding(2);
            this.rtb_MokkiTiedot.Name = "rtb_MokkiTiedot";
            this.rtb_MokkiTiedot.Size = new System.Drawing.Size(410, 125);
            this.rtb_MokkiTiedot.TabIndex = 5;
            this.rtb_MokkiTiedot.Text = "";
            // 
            // btn_HyvaksyVarays
            // 
            this.btn_HyvaksyVarays.BackColor = System.Drawing.Color.Sienna;
            this.btn_HyvaksyVarays.FlatAppearance.BorderSize = 0;
            this.btn_HyvaksyVarays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HyvaksyVarays.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HyvaksyVarays.Location = new System.Drawing.Point(634, 593);
            this.btn_HyvaksyVarays.Margin = new System.Windows.Forms.Padding(2);
            this.btn_HyvaksyVarays.Name = "btn_HyvaksyVarays";
            this.btn_HyvaksyVarays.Size = new System.Drawing.Size(211, 64);
            this.btn_HyvaksyVarays.TabIndex = 10;
            this.btn_HyvaksyVarays.Text = "Luo varaus ";
            this.btn_HyvaksyVarays.UseVisualStyleBackColor = false;
            this.btn_HyvaksyVarays.Click += new System.EventHandler(this.btn_HyvaksyVarays_Click);
            // 
            // gb_Asiakastiedot
            // 
            this.gb_Asiakastiedot.Controls.Add(this.label1);
            this.gb_Asiakastiedot.Controls.Add(this.tb_Sukunimi);
            this.gb_Asiakastiedot.Controls.Add(this.dtp_Lahtopvm);
            this.gb_Asiakastiedot.Controls.Add(this.lbl_Postinro);
            this.gb_Asiakastiedot.Controls.Add(this.dtp_Saapumispvm);
            this.gb_Asiakastiedot.Controls.Add(this.tb_Postinro);
            this.gb_Asiakastiedot.Controls.Add(this.lbl_LahtoPvm);
            this.gb_Asiakastiedot.Controls.Add(this.lbl_SaapumisPvm);
            this.gb_Asiakastiedot.Controls.Add(this.lbl_PuhNo);
            this.gb_Asiakastiedot.Controls.Add(this.lbl_Email);
            this.gb_Asiakastiedot.Controls.Add(this.lbl_Osoite);
            this.gb_Asiakastiedot.Controls.Add(this.lbl_Nimi);
            this.gb_Asiakastiedot.Controls.Add(this.tb_PuhNo);
            this.gb_Asiakastiedot.Controls.Add(this.tb_Email);
            this.gb_Asiakastiedot.Controls.Add(this.tb_Osoite);
            this.gb_Asiakastiedot.Controls.Add(this.tb_Etunimi);
            this.gb_Asiakastiedot.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Asiakastiedot.Location = new System.Drawing.Point(282, 83);
            this.gb_Asiakastiedot.Margin = new System.Windows.Forms.Padding(2);
            this.gb_Asiakastiedot.Name = "gb_Asiakastiedot";
            this.gb_Asiakastiedot.Padding = new System.Windows.Forms.Padding(2);
            this.gb_Asiakastiedot.Size = new System.Drawing.Size(308, 492);
            this.gb_Asiakastiedot.TabIndex = 8;
            this.gb_Asiakastiedot.TabStop = false;
            this.gb_Asiakastiedot.Text = "Asiakastiedot";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Sukunimi";
            // 
            // tb_Sukunimi
            // 
            this.tb_Sukunimi.AcceptsReturn = true;
            this.tb_Sukunimi.AcceptsTab = true;
            this.tb_Sukunimi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Sukunimi.Enabled = false;
            this.tb_Sukunimi.Location = new System.Drawing.Point(120, 85);
            this.tb_Sukunimi.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Sukunimi.Name = "tb_Sukunimi";
            this.tb_Sukunimi.Size = new System.Drawing.Size(175, 31);
            this.tb_Sukunimi.TabIndex = 4;
            this.tb_Sukunimi.Tag = "1";
            this.tb_Sukunimi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Kirjain_KeyPress);
            this.tb_Sukunimi.MouseLeave += new System.EventHandler(this.tb_Leave);
            // 
            // dtp_Lahtopvm
            // 
            this.dtp_Lahtopvm.CustomFormat = "";
            this.dtp_Lahtopvm.Enabled = false;
            this.dtp_Lahtopvm.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Lahtopvm.Location = new System.Drawing.Point(17, 425);
            this.dtp_Lahtopvm.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_Lahtopvm.MinDate = new System.DateTime(2023, 4, 6, 0, 0, 0, 0);
            this.dtp_Lahtopvm.Name = "dtp_Lahtopvm";
            this.dtp_Lahtopvm.Size = new System.Drawing.Size(263, 29);
            this.dtp_Lahtopvm.TabIndex = 17;
            // 
            // lbl_Postinro
            // 
            this.lbl_Postinro.AutoSize = true;
            this.lbl_Postinro.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Postinro.Location = new System.Drawing.Point(13, 168);
            this.lbl_Postinro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Postinro.Name = "lbl_Postinro";
            this.lbl_Postinro.Size = new System.Drawing.Size(99, 22);
            this.lbl_Postinro.TabIndex = 15;
            this.lbl_Postinro.Text = "Postinumero:";
            // 
            // dtp_Saapumispvm
            // 
            this.dtp_Saapumispvm.CustomFormat = "";
            this.dtp_Saapumispvm.Enabled = false;
            this.dtp_Saapumispvm.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Saapumispvm.Location = new System.Drawing.Point(17, 323);
            this.dtp_Saapumispvm.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_Saapumispvm.MinDate = new System.DateTime(2023, 4, 6, 0, 0, 0, 0);
            this.dtp_Saapumispvm.Name = "dtp_Saapumispvm";
            this.dtp_Saapumispvm.Size = new System.Drawing.Size(263, 29);
            this.dtp_Saapumispvm.TabIndex = 16;
            // 
            // tb_Postinro
            // 
            this.tb_Postinro.AcceptsReturn = true;
            this.tb_Postinro.AcceptsTab = true;
            this.tb_Postinro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Postinro.Enabled = false;
            this.tb_Postinro.Location = new System.Drawing.Point(120, 164);
            this.tb_Postinro.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Postinro.Name = "tb_Postinro";
            this.tb_Postinro.Size = new System.Drawing.Size(175, 31);
            this.tb_Postinro.TabIndex = 6;
            this.tb_Postinro.Tag = "1";
            this.tb_Postinro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Numero_KeyPress);
            this.tb_Postinro.MouseLeave += new System.EventHandler(this.tb_Leave);
            // 
            // lbl_LahtoPvm
            // 
            this.lbl_LahtoPvm.AutoSize = true;
            this.lbl_LahtoPvm.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LahtoPvm.Location = new System.Drawing.Point(86, 386);
            this.lbl_LahtoPvm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_LahtoPvm.Name = "lbl_LahtoPvm";
            this.lbl_LahtoPvm.Size = new System.Drawing.Size(93, 22);
            this.lbl_LahtoPvm.TabIndex = 15;
            this.lbl_LahtoPvm.Text = "Lähtöpäivä";
            // 
            // lbl_SaapumisPvm
            // 
            this.lbl_SaapumisPvm.AutoSize = true;
            this.lbl_SaapumisPvm.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SaapumisPvm.Location = new System.Drawing.Point(73, 287);
            this.lbl_SaapumisPvm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SaapumisPvm.Name = "lbl_SaapumisPvm";
            this.lbl_SaapumisPvm.Size = new System.Drawing.Size(120, 22);
            this.lbl_SaapumisPvm.TabIndex = 14;
            this.lbl_SaapumisPvm.Text = "Saapumispäivä";
            // 
            // lbl_PuhNo
            // 
            this.lbl_PuhNo.AutoSize = true;
            this.lbl_PuhNo.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PuhNo.Location = new System.Drawing.Point(14, 242);
            this.lbl_PuhNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_PuhNo.Name = "lbl_PuhNo";
            this.lbl_PuhNo.Size = new System.Drawing.Size(62, 22);
            this.lbl_PuhNo.TabIndex = 11;
            this.lbl_PuhNo.Text = "Puhnro:";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(14, 203);
            this.lbl_Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(54, 22);
            this.lbl_Email.TabIndex = 10;
            this.lbl_Email.Text = "Email:";
            // 
            // lbl_Osoite
            // 
            this.lbl_Osoite.AutoSize = true;
            this.lbl_Osoite.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Osoite.Location = new System.Drawing.Point(13, 128);
            this.lbl_Osoite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Osoite.Name = "lbl_Osoite";
            this.lbl_Osoite.Size = new System.Drawing.Size(59, 22);
            this.lbl_Osoite.TabIndex = 9;
            this.lbl_Osoite.Text = "Osoite:";
            // 
            // lbl_Nimi
            // 
            this.lbl_Nimi.AutoSize = true;
            this.lbl_Nimi.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nimi.Location = new System.Drawing.Point(13, 50);
            this.lbl_Nimi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Nimi.Name = "lbl_Nimi";
            this.lbl_Nimi.Size = new System.Drawing.Size(67, 22);
            this.lbl_Nimi.TabIndex = 8;
            this.lbl_Nimi.Text = "Etunimi";
            // 
            // tb_PuhNo
            // 
            this.tb_PuhNo.AcceptsReturn = true;
            this.tb_PuhNo.AcceptsTab = true;
            this.tb_PuhNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_PuhNo.Enabled = false;
            this.tb_PuhNo.Location = new System.Drawing.Point(120, 239);
            this.tb_PuhNo.Margin = new System.Windows.Forms.Padding(2);
            this.tb_PuhNo.Name = "tb_PuhNo";
            this.tb_PuhNo.Size = new System.Drawing.Size(175, 31);
            this.tb_PuhNo.TabIndex = 8;
            this.tb_PuhNo.Tag = "1";
            this.tb_PuhNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Numero_KeyPress);
            this.tb_PuhNo.MouseLeave += new System.EventHandler(this.tb_Leave);
            // 
            // tb_Email
            // 
            this.tb_Email.AcceptsReturn = true;
            this.tb_Email.AcceptsTab = true;
            this.tb_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Email.Enabled = false;
            this.tb_Email.Location = new System.Drawing.Point(120, 200);
            this.tb_Email.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(175, 31);
            this.tb_Email.TabIndex = 7;
            this.tb_Email.Tag = "1";
            this.tb_Email.MouseLeave += new System.EventHandler(this.tb_Leave);
            // 
            // tb_Osoite
            // 
            this.tb_Osoite.AcceptsReturn = true;
            this.tb_Osoite.AcceptsTab = true;
            this.tb_Osoite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Osoite.Enabled = false;
            this.tb_Osoite.Location = new System.Drawing.Point(120, 125);
            this.tb_Osoite.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Osoite.Name = "tb_Osoite";
            this.tb_Osoite.Size = new System.Drawing.Size(175, 31);
            this.tb_Osoite.TabIndex = 5;
            this.tb_Osoite.Tag = "1";
            this.tb_Osoite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Osoite_KeyPress);
            this.tb_Osoite.MouseLeave += new System.EventHandler(this.tb_Leave);
            // 
            // tb_Etunimi
            // 
            this.tb_Etunimi.AcceptsReturn = true;
            this.tb_Etunimi.AcceptsTab = true;
            this.tb_Etunimi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Etunimi.Enabled = false;
            this.tb_Etunimi.Location = new System.Drawing.Point(120, 47);
            this.tb_Etunimi.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Etunimi.Name = "tb_Etunimi";
            this.tb_Etunimi.Size = new System.Drawing.Size(175, 31);
            this.tb_Etunimi.TabIndex = 3;
            this.tb_Etunimi.Tag = "1";
            this.tb_Etunimi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Kirjain_KeyPress);
            this.tb_Etunimi.MouseLeave += new System.EventHandler(this.tb_Leave);
            // 
            // tb_Henklkm
            // 
            this.tb_Henklkm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Henklkm.Enabled = false;
            this.tb_Henklkm.Location = new System.Drawing.Point(80, 426);
            this.tb_Henklkm.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Henklkm.Name = "tb_Henklkm";
            this.tb_Henklkm.Size = new System.Drawing.Size(82, 31);
            this.tb_Henklkm.TabIndex = 20;
            this.tb_Henklkm.Tag = "1";
            // 
            // lbl_HenkMaara
            // 
            this.lbl_HenkMaara.AutoSize = true;
            this.lbl_HenkMaara.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HenkMaara.Location = new System.Drawing.Point(33, 388);
            this.lbl_HenkMaara.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_HenkMaara.Name = "lbl_HenkMaara";
            this.lbl_HenkMaara.Size = new System.Drawing.Size(176, 22);
            this.lbl_HenkMaara.TabIndex = 12;
            this.lbl_HenkMaara.Text = "Max henkilölukumäärä";
            // 
            // clb_Lisapalvelut
            // 
            this.clb_Lisapalvelut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clb_Lisapalvelut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clb_Lisapalvelut.CheckOnClick = true;
            this.clb_Lisapalvelut.ColumnWidth = 210;
            this.clb_Lisapalvelut.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_Lisapalvelut.FormattingEnabled = true;
            this.clb_Lisapalvelut.HorizontalScrollbar = true;
            this.clb_Lisapalvelut.Location = new System.Drawing.Point(595, 118);
            this.clb_Lisapalvelut.MultiColumn = true;
            this.clb_Lisapalvelut.Name = "clb_Lisapalvelut";
            this.clb_Lisapalvelut.Size = new System.Drawing.Size(466, 78);
            this.clb_Lisapalvelut.Sorted = true;
            this.clb_Lisapalvelut.TabIndex = 9;
            // 
            // lb_Sijainti
            // 
            this.lb_Sijainti.AutoSize = true;
            this.lb_Sijainti.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Sijainti.Location = new System.Drawing.Point(67, 287);
            this.lb_Sijainti.Name = "lb_Sijainti";
            this.lb_Sijainti.Size = new System.Drawing.Size(108, 22);
            this.lb_Sijainti.TabIndex = 18;
            this.lb_Sijainti.Text = "Mökin sijainti";
            // 
            // mc_Varaus
            // 
            this.mc_Varaus.BackColor = System.Drawing.Color.Tan;
            this.mc_Varaus.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.mc_Varaus.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mc_Varaus.ForeColor = System.Drawing.Color.Tan;
            this.mc_Varaus.Location = new System.Drawing.Point(26, 39);
            this.mc_Varaus.Margin = new System.Windows.Forms.Padding(7);
            this.mc_Varaus.MaxSelectionCount = 31;
            this.mc_Varaus.MinDate = new System.DateTime(2023, 5, 9, 0, 0, 0, 0);
            this.mc_Varaus.Name = "mc_Varaus";
            this.mc_Varaus.ShowToday = false;
            this.mc_Varaus.TabIndex = 1;
            this.mc_Varaus.TabStop = false;
            this.mc_Varaus.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mc_Varaus_DateChanged);
            this.mc_Varaus.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mc_Varaus_DateSelected);
            // 
            // lbl_MokkiID
            // 
            this.lbl_MokkiID.AutoSize = true;
            this.lbl_MokkiID.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MokkiID.Location = new System.Drawing.Point(109, 322);
            this.lbl_MokkiID.Name = "lbl_MokkiID";
            this.lbl_MokkiID.Size = new System.Drawing.Size(66, 19);
            this.lbl_MokkiID.TabIndex = 20;
            this.lbl_MokkiID.Text = "Mökki ID";
            // 
            // tb_MokkiID
            // 
            this.tb_MokkiID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_MokkiID.Enabled = false;
            this.tb_MokkiID.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MokkiID.Location = new System.Drawing.Point(97, 350);
            this.tb_MokkiID.Name = "tb_MokkiID";
            this.tb_MokkiID.Size = new System.Drawing.Size(100, 26);
            this.tb_MokkiID.TabIndex = 21;
            // 
            // lbl_Ajankohta
            // 
            this.lbl_Ajankohta.AutoSize = true;
            this.lbl_Ajankohta.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ajankohta.Location = new System.Drawing.Point(454, 98);
            this.lbl_Ajankohta.Name = "lbl_Ajankohta";
            this.lbl_Ajankohta.Size = new System.Drawing.Size(0, 22);
            this.lbl_Ajankohta.TabIndex = 22;
            // 
            // gb_KohteenLisatiedot
            // 
            this.gb_KohteenLisatiedot.Controls.Add(this.lbl_Varustelu);
            this.gb_KohteenLisatiedot.Controls.Add(this.label3);
            this.gb_KohteenLisatiedot.Controls.Add(this.rtb_Mokkivarustelu);
            this.gb_KohteenLisatiedot.Controls.Add(this.rtb_MokkiTiedot);
            this.gb_KohteenLisatiedot.Controls.Add(this.tb_AlueID);
            this.gb_KohteenLisatiedot.Controls.Add(this.lbl_MokkiID);
            this.gb_KohteenLisatiedot.Controls.Add(this.tb_MokkiID);
            this.gb_KohteenLisatiedot.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_KohteenLisatiedot.Location = new System.Drawing.Point(634, 193);
            this.gb_KohteenLisatiedot.Name = "gb_KohteenLisatiedot";
            this.gb_KohteenLisatiedot.Size = new System.Drawing.Size(427, 382);
            this.gb_KohteenLisatiedot.TabIndex = 24;
            this.gb_KohteenLisatiedot.TabStop = false;
            this.gb_KohteenLisatiedot.Text = "Tietoa Kohteesta:";
            // 
            // lbl_Varustelu
            // 
            this.lbl_Varustelu.AutoSize = true;
            this.lbl_Varustelu.Location = new System.Drawing.Point(6, 151);
            this.lbl_Varustelu.Name = "lbl_Varustelu";
            this.lbl_Varustelu.Size = new System.Drawing.Size(128, 22);
            this.lbl_Varustelu.TabIndex = 24;
            this.lbl_Varustelu.Text = "Mökin varustelu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Alue ID";
            // 
            // rtb_Mokkivarustelu
            // 
            this.rtb_Mokkivarustelu.BackColor = System.Drawing.Color.Snow;
            this.rtb_Mokkivarustelu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_Mokkivarustelu.Enabled = false;
            this.rtb_Mokkivarustelu.Location = new System.Drawing.Point(5, 188);
            this.rtb_Mokkivarustelu.Margin = new System.Windows.Forms.Padding(2);
            this.rtb_Mokkivarustelu.Name = "rtb_Mokkivarustelu";
            this.rtb_Mokkivarustelu.Size = new System.Drawing.Size(410, 125);
            this.rtb_Mokkivarustelu.TabIndex = 6;
            this.rtb_Mokkivarustelu.Text = "";
            // 
            // tb_AlueID
            // 
            this.tb_AlueID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_AlueID.Enabled = false;
            this.tb_AlueID.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_AlueID.Location = new System.Drawing.Point(247, 350);
            this.tb_AlueID.Name = "tb_AlueID";
            this.tb_AlueID.Size = new System.Drawing.Size(100, 26);
            this.tb_AlueID.TabIndex = 23;
            // 
            // gb_Ajankohta
            // 
            this.gb_Ajankohta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gb_Ajankohta.Controls.Add(this.tb_Henklkm);
            this.gb_Ajankohta.Controls.Add(this.tb_Sijainti);
            this.gb_Ajankohta.Controls.Add(this.mc_Varaus);
            this.gb_Ajankohta.Controls.Add(this.cb_VapaatMokit);
            this.gb_Ajankohta.Controls.Add(this.Mokit_lb);
            this.gb_Ajankohta.Controls.Add(this.lb_Sijainti);
            this.gb_Ajankohta.Controls.Add(this.lbl_HenkMaara);
            this.gb_Ajankohta.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Ajankohta.Location = new System.Drawing.Point(16, 83);
            this.gb_Ajankohta.Name = "gb_Ajankohta";
            this.gb_Ajankohta.Size = new System.Drawing.Size(261, 492);
            this.gb_Ajankohta.TabIndex = 26;
            this.gb_Ajankohta.TabStop = false;
            this.gb_Ajankohta.Text = "Majoittumisen ajankohta";
            // 
            // tb_Sijainti
            // 
            this.tb_Sijainti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Sijainti.Enabled = false;
            this.tb_Sijainti.Location = new System.Drawing.Point(34, 323);
            this.tb_Sijainti.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Sijainti.Name = "tb_Sijainti";
            this.tb_Sijainti.Size = new System.Drawing.Size(175, 31);
            this.tb_Sijainti.TabIndex = 100;
            this.tb_Sijainti.TextChanged += new System.EventHandler(this.tb_Sijainti_TextChanged);
            // 
            // lbl_Lisapalvelut
            // 
            this.lbl_Lisapalvelut.AutoSize = true;
            this.lbl_Lisapalvelut.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lisapalvelut.Location = new System.Drawing.Point(591, 83);
            this.lbl_Lisapalvelut.Name = "lbl_Lisapalvelut";
            this.lbl_Lisapalvelut.Size = new System.Drawing.Size(240, 24);
            this.lbl_Lisapalvelut.TabIndex = 26;
            this.lbl_Lisapalvelut.Text = "Saatavilla olevat lisäpalvelut";
            // 
            // btn_Takaisin
            // 
            this.btn_Takaisin.BackColor = System.Drawing.Color.Sienna;
            this.btn_Takaisin.FlatAppearance.BorderSize = 0;
            this.btn_Takaisin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Takaisin.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Takaisin.Location = new System.Drawing.Point(1, 613);
            this.btn_Takaisin.Name = "btn_Takaisin";
            this.btn_Takaisin.Size = new System.Drawing.Size(151, 54);
            this.btn_Takaisin.TabIndex = 12;
            this.btn_Takaisin.Text = "Takaisin";
            this.btn_Takaisin.UseVisualStyleBackColor = false;
            this.btn_Takaisin.Click += new System.EventHandler(this.btn_Takaisin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Controls.Add(this.lbl_VapaatMokit);
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 66);
            this.panel1.TabIndex = 28;
            // 
            // btn_HyvaksyVarauksia
            // 
            this.btn_HyvaksyVarauksia.BackColor = System.Drawing.Color.Sienna;
            this.btn_HyvaksyVarauksia.FlatAppearance.BorderSize = 0;
            this.btn_HyvaksyVarauksia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HyvaksyVarauksia.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HyvaksyVarauksia.Location = new System.Drawing.Point(868, 593);
            this.btn_HyvaksyVarauksia.Margin = new System.Windows.Forms.Padding(2);
            this.btn_HyvaksyVarauksia.Name = "btn_HyvaksyVarauksia";
            this.btn_HyvaksyVarauksia.Size = new System.Drawing.Size(193, 64);
            this.btn_HyvaksyVarauksia.TabIndex = 11;
            this.btn_HyvaksyVarauksia.Text = "Vahvista varauksia";
            this.btn_HyvaksyVarauksia.UseVisualStyleBackColor = false;
            this.btn_HyvaksyVarauksia.Click += new System.EventHandler(this.btn_HyvaksyVarauksia_Click);
            // 
            // tb_hinta
            // 
            this.tb_hinta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_hinta.Enabled = false;
            this.tb_hinta.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_hinta.Location = new System.Drawing.Point(444, 602);
            this.tb_hinta.Name = "tb_hinta";
            this.tb_hinta.Size = new System.Drawing.Size(118, 29);
            this.tb_hinta.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 602);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "Hinta/vrk:";
            // 
            // FrmVaraus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 668);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_hinta);
            this.Controls.Add(this.btn_HyvaksyVarauksia);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Takaisin);
            this.Controls.Add(this.btn_HyvaksyVarays);
            this.Controls.Add(this.lbl_Lisapalvelut);
            this.Controls.Add(this.gb_Ajankohta);
            this.Controls.Add(this.clb_Lisapalvelut);
            this.Controls.Add(this.gb_KohteenLisatiedot);
            this.Controls.Add(this.lbl_Ajankohta);
            this.Controls.Add(this.gb_Asiakastiedot);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmVaraus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mökkien varaaminen";
            this.Load += new System.EventHandler(this.FrmVapaatmokit_Load);
            this.gb_Asiakastiedot.ResumeLayout(false);
            this.gb_Asiakastiedot.PerformLayout();
            this.gb_KohteenLisatiedot.ResumeLayout(false);
            this.gb_KohteenLisatiedot.PerformLayout();
            this.gb_Ajankohta.ResumeLayout(false);
            this.gb_Ajankohta.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_VapaatMokit;
        private System.Windows.Forms.ComboBox cb_VapaatMokit;
        private System.Windows.Forms.Label Mokit_lb;
        private System.Windows.Forms.RichTextBox rtb_MokkiTiedot;
        private System.Windows.Forms.Button btn_HyvaksyVarays;
        private System.Windows.Forms.GroupBox gb_Asiakastiedot;
        private System.Windows.Forms.TextBox tb_PuhNo;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_Osoite;
        private System.Windows.Forms.TextBox tb_Etunimi;
        private System.Windows.Forms.Label lbl_HenkMaara;
        private System.Windows.Forms.Label lbl_PuhNo;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Osoite;
        private System.Windows.Forms.Label lbl_Nimi;
        private System.Windows.Forms.DateTimePicker dtp_Lahtopvm;
        private System.Windows.Forms.DateTimePicker dtp_Saapumispvm;
        private System.Windows.Forms.Label lbl_LahtoPvm;
        private System.Windows.Forms.Label lbl_SaapumisPvm;
        private System.Windows.Forms.CheckedListBox clb_Lisapalvelut;
        private System.Windows.Forms.Label lb_Sijainti;
        private System.Windows.Forms.MonthCalendar mc_Varaus;
        private System.Windows.Forms.Label lbl_Postinro;
        private System.Windows.Forms.TextBox tb_Postinro;
        private System.Windows.Forms.Label lbl_MokkiID;
        private System.Windows.Forms.TextBox tb_MokkiID;
        private System.Windows.Forms.Label lbl_Ajankohta;
        private System.Windows.Forms.GroupBox gb_KohteenLisatiedot;
        private System.Windows.Forms.GroupBox gb_Ajankohta;
        private System.Windows.Forms.Label lbl_Lisapalvelut;
        private System.Windows.Forms.Button btn_Takaisin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Sukunimi;
        private System.Windows.Forms.TextBox tb_Henklkm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_AlueID;
        private System.Windows.Forms.TextBox tb_Sijainti;
        private System.Windows.Forms.RichTextBox rtb_Mokkivarustelu;
        private System.Windows.Forms.Label lbl_Varustelu;
        private System.Windows.Forms.Button btn_HyvaksyVarauksia;
        private System.Windows.Forms.TextBox tb_hinta;
        private System.Windows.Forms.Label label2;
    }
}