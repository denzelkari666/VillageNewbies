namespace VillageNewbies
{
    partial class FrmLaskutusTiedot
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
            this.label1 = new System.Windows.Forms.Label();
            this.Takaisin_bt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_tulostalasku = new System.Windows.Forms.Button();
            this.lb_laskud = new System.Windows.Forms.Label();
            this.lb_tiedot = new System.Windows.Forms.Label();
            this.lb_lasku = new System.Windows.Forms.ListBox();
            this.cb_VarausID = new System.Windows.Forms.ComboBox();
            this.cb_File = new System.Windows.Forms.ComboBox();
            this.bt_PoistaLasku = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_tallenna = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_Logo
            // 
            this.pb_Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_Logo.Image = global::VillageNewbies.Properties.Resources.VN_Icon;
            this.pb_Logo.Location = new System.Drawing.Point(0, 65);
            this.pb_Logo.Margin = new System.Windows.Forms.Padding(2);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(146, 121);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Logo.TabIndex = 15;
            this.pb_Logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 36);
            this.label1.TabIndex = 16;
            this.label1.Text = "Laskutustiedot";
            // 
            // Takaisin_bt
            // 
            this.Takaisin_bt.BackColor = System.Drawing.Color.Sienna;
            this.Takaisin_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Takaisin_bt.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Takaisin_bt.Location = new System.Drawing.Point(11, 515);
            this.Takaisin_bt.Margin = new System.Windows.Forms.Padding(2);
            this.Takaisin_bt.Name = "Takaisin_bt";
            this.Takaisin_bt.Size = new System.Drawing.Size(70, 30);
            this.Takaisin_bt.TabIndex = 17;
            this.Takaisin_bt.Text = "Takaisin";
            this.Takaisin_bt.UseVisualStyleBackColor = false;
            this.Takaisin_bt.Click += new System.EventHandler(this.Takaisin_bt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 59);
            this.panel1.TabIndex = 18;
            // 
            // bt_tulostalasku
            // 
            this.bt_tulostalasku.BackColor = System.Drawing.Color.Sienna;
            this.bt_tulostalasku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_tulostalasku.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tulostalasku.Location = new System.Drawing.Point(747, 470);
            this.bt_tulostalasku.Name = "bt_tulostalasku";
            this.bt_tulostalasku.Size = new System.Drawing.Size(107, 36);
            this.bt_tulostalasku.TabIndex = 19;
            this.bt_tulostalasku.Text = "Tulosta lasku";
            this.bt_tulostalasku.UseVisualStyleBackColor = false;
            this.bt_tulostalasku.Click += new System.EventHandler(this.bt_tulostalasku_Click);
            // 
            // lb_laskud
            // 
            this.lb_laskud.AutoSize = true;
            this.lb_laskud.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_laskud.Location = new System.Drawing.Point(151, 77);
            this.lb_laskud.Name = "lb_laskud";
            this.lb_laskud.Size = new System.Drawing.Size(79, 19);
            this.lb_laskud.TabIndex = 20;
            this.lb_laskud.Text = "Varaus ID : ";
            // 
            // lb_tiedot
            // 
            this.lb_tiedot.AutoSize = true;
            this.lb_tiedot.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tiedot.Location = new System.Drawing.Point(151, 96);
            this.lb_tiedot.Name = "lb_tiedot";
            this.lb_tiedot.Size = new System.Drawing.Size(47, 19);
            this.lb_tiedot.TabIndex = 21;
            this.lb_tiedot.Text = "Tiedot";
            // 
            // lb_lasku
            // 
            this.lb_lasku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lasku.FormattingEnabled = true;
            this.lb_lasku.ItemHeight = 16;
            this.lb_lasku.Location = new System.Drawing.Point(151, 118);
            this.lb_lasku.Name = "lb_lasku";
            this.lb_lasku.Size = new System.Drawing.Size(572, 436);
            this.lb_lasku.TabIndex = 22;
            // 
            // cb_VarausID
            // 
            this.cb_VarausID.FormattingEnabled = true;
            this.cb_VarausID.Location = new System.Drawing.Point(236, 78);
            this.cb_VarausID.Name = "cb_VarausID";
            this.cb_VarausID.Size = new System.Drawing.Size(121, 21);
            this.cb_VarausID.TabIndex = 23;
            this.cb_VarausID.SelectedIndexChanged += new System.EventHandler(this.cb_VarausID_SelectedIndexChanged);
            // 
            // cb_File
            // 
            this.cb_File.FormattingEnabled = true;
            this.cb_File.Location = new System.Drawing.Point(575, 80);
            this.cb_File.Name = "cb_File";
            this.cb_File.Size = new System.Drawing.Size(148, 21);
            this.cb_File.TabIndex = 24;
            this.cb_File.SelectedIndexChanged += new System.EventHandler(this.cb_File_SelectedIndexChanged);
            // 
            // bt_PoistaLasku
            // 
            this.bt_PoistaLasku.BackColor = System.Drawing.Color.Sienna;
            this.bt_PoistaLasku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_PoistaLasku.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_PoistaLasku.Location = new System.Drawing.Point(747, 512);
            this.bt_PoistaLasku.Name = "bt_PoistaLasku";
            this.bt_PoistaLasku.Size = new System.Drawing.Size(107, 36);
            this.bt_PoistaLasku.TabIndex = 25;
            this.bt_PoistaLasku.Text = "Poista lasku";
            this.bt_PoistaLasku.UseVisualStyleBackColor = false;
            this.bt_PoistaLasku.Click += new System.EventHandler(this.bt_PoistaLasku_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(413, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "Olemassa olevat laskut : ";
            // 
            // bt_tallenna
            // 
            this.bt_tallenna.BackColor = System.Drawing.Color.Sienna;
            this.bt_tallenna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_tallenna.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tallenna.Location = new System.Drawing.Point(747, 428);
            this.bt_tallenna.Name = "bt_tallenna";
            this.bt_tallenna.Size = new System.Drawing.Size(107, 36);
            this.bt_tallenna.TabIndex = 28;
            this.bt_tallenna.Text = "Tallenna lasku";
            this.bt_tallenna.UseVisualStyleBackColor = false;
            this.bt_tallenna.Click += new System.EventHandler(this.bt_tallenna_Click);
            // 
            // FrmLaskutusTiedot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(866, 556);
            this.Controls.Add(this.bt_tallenna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_PoistaLasku);
            this.Controls.Add(this.cb_File);
            this.Controls.Add(this.cb_VarausID);
            this.Controls.Add(this.lb_lasku);
            this.Controls.Add(this.lb_tiedot);
            this.Controls.Add(this.lb_laskud);
            this.Controls.Add(this.bt_tulostalasku);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pb_Logo);
            this.Controls.Add(this.Takaisin_bt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmLaskutusTiedot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLaskutusTiedot";
            this.Load += new System.EventHandler(this.FrmLaskutusTiedot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Takaisin_bt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_tulostalasku;
        private System.Windows.Forms.Label lb_laskud;
        private System.Windows.Forms.Label lb_tiedot;
        private System.Windows.Forms.ListBox lb_lasku;
        private System.Windows.Forms.ComboBox cb_VarausID;
        private System.Windows.Forms.ComboBox cb_File;
        private System.Windows.Forms.Button bt_PoistaLasku;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_tallenna;
    }
}