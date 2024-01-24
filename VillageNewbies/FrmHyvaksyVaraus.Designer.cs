namespace VillageNewbies
{
    partial class FrmHyvaksyVaraus
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
            this.hyvaksy = new System.Windows.Forms.Button();
            this.asiakasidcb = new System.Windows.Forms.ComboBox();
            this.lbasiakastiedot = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbmokkitiedot = new System.Windows.Forms.ListBox();
            this.cbmokkitiedot = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hyvaksy
            // 
            this.hyvaksy.BackColor = System.Drawing.Color.Sienna;
            this.hyvaksy.FlatAppearance.BorderSize = 0;
            this.hyvaksy.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hyvaksy.Location = new System.Drawing.Point(448, 362);
            this.hyvaksy.Name = "hyvaksy";
            this.hyvaksy.Size = new System.Drawing.Size(166, 54);
            this.hyvaksy.TabIndex = 0;
            this.hyvaksy.Text = "Vahvista varaus";
            this.hyvaksy.UseVisualStyleBackColor = false;
            this.hyvaksy.Click += new System.EventHandler(this.button2_Click);
            // 
            // asiakasidcb
            // 
            this.asiakasidcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asiakasidcb.FormattingEnabled = true;
            this.asiakasidcb.Location = new System.Drawing.Point(142, 136);
            this.asiakasidcb.MaxLength = 10;
            this.asiakasidcb.Name = "asiakasidcb";
            this.asiakasidcb.Size = new System.Drawing.Size(121, 28);
            this.asiakasidcb.Sorted = true;
            this.asiakasidcb.TabIndex = 1;
            this.asiakasidcb.Text = "Asiakas id";
            this.asiakasidcb.SelectedIndexChanged += new System.EventHandler(this.asiakasidcb_SelectedIndexChanged);
            this.asiakasidcb.TextUpdate += new System.EventHandler(this.asiakasidcb_TextUpdate);
            // 
            // lbasiakastiedot
            // 
            this.lbasiakastiedot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbasiakastiedot.FormattingEnabled = true;
            this.lbasiakastiedot.ItemHeight = 24;
            this.lbasiakastiedot.Location = new System.Drawing.Point(142, 178);
            this.lbasiakastiedot.Name = "lbasiakastiedot";
            this.lbasiakastiedot.Size = new System.Drawing.Size(351, 148);
            this.lbasiakastiedot.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Asiakas ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Etunimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sukunimi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Postinro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Osoite";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Puhelinnro";
            // 
            // lbmokkitiedot
            // 
            this.lbmokkitiedot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmokkitiedot.FormattingEnabled = true;
            this.lbmokkitiedot.ItemHeight = 24;
            this.lbmokkitiedot.Location = new System.Drawing.Point(651, 178);
            this.lbmokkitiedot.Name = "lbmokkitiedot";
            this.lbmokkitiedot.Size = new System.Drawing.Size(358, 148);
            this.lbmokkitiedot.TabIndex = 11;
            this.lbmokkitiedot.SelectedIndexChanged += new System.EventHandler(this.lbmokkitiedot_SelectedIndexChanged);
            // 
            // cbmokkitiedot
            // 
            this.cbmokkitiedot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmokkitiedot.FormattingEnabled = true;
            this.cbmokkitiedot.Location = new System.Drawing.Point(651, 136);
            this.cbmokkitiedot.Name = "cbmokkitiedot";
            this.cbmokkitiedot.Size = new System.Drawing.Size(121, 28);
            this.cbmokkitiedot.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(536, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mökki id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(536, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 22);
            this.label9.TabIndex = 15;
            this.label9.Text = "Mökin nimi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(536, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 22);
            this.label10.TabIndex = 16;
            this.label10.Text = "Osoite";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(536, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 22);
            this.label11.TabIndex = 17;
            this.label11.Text = "Postinro";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(536, 253);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 22);
            this.label12.TabIndex = 18;
            this.label12.Text = "Hinta";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(536, 276);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 22);
            this.label13.TabIndex = 19;
            this.label13.Text = "Henkilömäärä";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(536, 299);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 22);
            this.label14.TabIndex = 20;
            this.label14.Text = "Varustelut";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 89);
            this.panel1.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(19, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(209, 36);
            this.label15.TabIndex = 0;
            this.label15.Text = "Vahvista varaus";
            // 
            // FrmHyvaksyVaraus
            // 
            this.ClientSize = new System.Drawing.Size(1031, 438);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbmokkitiedot);
            this.Controls.Add(this.lbmokkitiedot);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbasiakastiedot);
            this.Controls.Add(this.asiakasidcb);
            this.Controls.Add(this.hyvaksy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmHyvaksyVaraus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hyväksy varaus";
            this.Load += new System.EventHandler(this.FrmHyvaksyVaraus_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button hyvaksy;
        private System.Windows.Forms.ComboBox asiakasidcb;
        private System.Windows.Forms.ListBox lbasiakastiedot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbmokkitiedot;
        private System.Windows.Forms.ComboBox cbmokkitiedot;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
    }
}