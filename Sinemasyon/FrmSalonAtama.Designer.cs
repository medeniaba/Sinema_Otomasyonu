namespace Sinemasyon
{
    partial class FrmSalonAtama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSalonAtama));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SinemasyonLogo = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbSalon = new System.Windows.Forms.ComboBox();
            this.lblSecilen = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panelSeans = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nmcYil = new System.Windows.Forms.NumericUpDown();
            this.nmcAy = new System.Windows.Forms.NumericUpDown();
            this.nmcGun = new System.Windows.Forms.NumericUpDown();
            this.lblGun = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbFilmAdi = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbDoluSaatler = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcYil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcAy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcGun)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.SinemasyonLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 52);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(896, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SinemasyonLogo
            // 
            this.SinemasyonLogo.AutoSize = true;
            this.SinemasyonLogo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SinemasyonLogo.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SinemasyonLogo.ForeColor = System.Drawing.Color.DarkOrchid;
            this.SinemasyonLogo.Location = new System.Drawing.Point(323, 9);
            this.SinemasyonLogo.Name = "SinemasyonLogo";
            this.SinemasyonLogo.Size = new System.Drawing.Size(326, 38);
            this.SinemasyonLogo.TabIndex = 2;
            this.SinemasyonLogo.Text = "SALON ATAMA EKRANI";
            this.SinemasyonLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(23, 342);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(211, 36);
            this.btnTemizle.TabIndex = 38;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnOlustur
            // 
            this.btnOlustur.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOlustur.Location = new System.Drawing.Point(23, 300);
            this.btnOlustur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(211, 36);
            this.btnOlustur.TabIndex = 37;
            this.btnOlustur.Text = "TAMAMLA";
            this.btnOlustur.UseVisualStyleBackColor = false;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbSalon);
            this.groupBox4.Location = new System.Drawing.Point(23, 142);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(11, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(216, 60);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SALON ADI";
            // 
            // cbSalon
            // 
            this.cbSalon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbSalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSalon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSalon.FormattingEnabled = true;
            this.cbSalon.Location = new System.Drawing.Point(11, 34);
            this.cbSalon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSalon.Name = "cbSalon";
            this.cbSalon.Size = new System.Drawing.Size(202, 24);
            this.cbSalon.TabIndex = 0;
            // 
            // lblSecilen
            // 
            this.lblSecilen.AutoSize = true;
            this.lblSecilen.BackColor = System.Drawing.Color.White;
            this.lblSecilen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecilen.ForeColor = System.Drawing.Color.Purple;
            this.lblSecilen.Location = new System.Drawing.Point(309, 478);
            this.lblSecilen.Name = "lblSecilen";
            this.lblSecilen.Size = new System.Drawing.Size(117, 23);
            this.lblSecilen.TabIndex = 21;
            this.lblSecilen.Text = "lblKoltukSayisi";
            this.lblSecilen.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panelSeans);
            this.groupBox3.Location = new System.Drawing.Point(277, 76);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(11, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(624, 313);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SAAT/SEANS";
            // 
            // panelSeans
            // 
            this.panelSeans.AutoScroll = true;
            this.panelSeans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSeans.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelSeans.Location = new System.Drawing.Point(11, 17);
            this.panelSeans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSeans.Name = "panelSeans";
            this.panelSeans.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelSeans.Size = new System.Drawing.Size(610, 294);
            this.panelSeans.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nmcYil);
            this.groupBox2.Controls.Add(this.nmcAy);
            this.groupBox2.Controls.Add(this.nmcGun);
            this.groupBox2.Controls.Add(this.lblGun);
            this.groupBox2.Location = new System.Drawing.Point(23, 208);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(11, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(216, 65);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TARİH";
            // 
            // nmcYil
            // 
            this.nmcYil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nmcYil.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmcYil.Location = new System.Drawing.Point(132, 30);
            this.nmcYil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmcYil.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.nmcYil.Minimum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.nmcYil.Name = "nmcYil";
            this.nmcYil.Size = new System.Drawing.Size(79, 26);
            this.nmcYil.TabIndex = 21;
            this.nmcYil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmcYil.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // nmcAy
            // 
            this.nmcAy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nmcAy.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmcAy.Location = new System.Drawing.Point(73, 30);
            this.nmcAy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmcAy.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nmcAy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmcAy.Name = "nmcAy";
            this.nmcAy.Size = new System.Drawing.Size(59, 26);
            this.nmcAy.TabIndex = 20;
            this.nmcAy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmcAy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nmcGun
            // 
            this.nmcGun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nmcGun.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmcGun.Location = new System.Drawing.Point(11, 30);
            this.nmcGun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmcGun.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nmcGun.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmcGun.Name = "nmcGun";
            this.nmcGun.Size = new System.Drawing.Size(56, 26);
            this.nmcGun.TabIndex = 19;
            this.nmcGun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmcGun.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblGun
            // 
            this.lblGun.AutoSize = true;
            this.lblGun.BackColor = System.Drawing.Color.White;
            this.lblGun.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGun.ForeColor = System.Drawing.Color.Purple;
            this.lblGun.Location = new System.Drawing.Point(139, 9);
            this.lblGun.Name = "lblGun";
            this.lblGun.Size = new System.Drawing.Size(72, 17);
            this.lblGun.TabIndex = 18;
            this.lblGun.Text = "gg/aa/yyyy";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbFilmAdi);
            this.groupBox1.Location = new System.Drawing.Point(23, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(11, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(216, 60);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FİLM ADI";
            // 
            // cbFilmAdi
            // 
            this.cbFilmAdi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFilmAdi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbFilmAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilmAdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFilmAdi.FormattingEnabled = true;
            this.cbFilmAdi.Location = new System.Drawing.Point(11, 34);
            this.cbFilmAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFilmAdi.Name = "cbFilmAdi";
            this.cbFilmAdi.Size = new System.Drawing.Size(202, 24);
            this.cbFilmAdi.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbDoluSaatler);
            this.groupBox5.Location = new System.Drawing.Point(53, 444);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(11, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(216, 60);
            this.groupBox5.TabIndex = 39;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "DOLU SAATLER";
            this.groupBox5.Visible = false;
            // 
            // cbDoluSaatler
            // 
            this.cbDoluSaatler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbDoluSaatler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoluSaatler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDoluSaatler.FormattingEnabled = true;
            this.cbDoluSaatler.Location = new System.Drawing.Point(11, 34);
            this.cbDoluSaatler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDoluSaatler.MaxLength = 500;
            this.cbDoluSaatler.Name = "cbDoluSaatler";
            this.cbDoluSaatler.Size = new System.Drawing.Size(202, 24);
            this.cbDoluSaatler.TabIndex = 0;
            // 
            // FrmSalonAtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 405);
            this.Controls.Add(this.lblSecilen);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(550, 180);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmSalonAtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmSalonAtama";
            this.Load += new System.EventHandler(this.FrmSalonAtama_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcYil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcAy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcGun)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label SinemasyonLogo;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblSecilen;
        private System.Windows.Forms.ComboBox cbSalon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel panelSeans;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblGun;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbFilmAdi;
        private System.Windows.Forms.NumericUpDown nmcYil;
        private System.Windows.Forms.NumericUpDown nmcAy;
        private System.Windows.Forms.NumericUpDown nmcGun;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbDoluSaatler;
    }
}