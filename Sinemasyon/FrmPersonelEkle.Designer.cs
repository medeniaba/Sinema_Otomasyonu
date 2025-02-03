namespace Sinemasyon
{
    partial class FrmPersonelEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonelEkle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SinemasyonLogo = new System.Windows.Forms.Label();
            this.OyuncuGroupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PersonelKAdi = new System.Windows.Forms.Label();
            this.PersonelKSifreText = new System.Windows.Forms.TextBox();
            this.PersonelKAdiText = new System.Windows.Forms.TextBox();
            this.PersonelSoyAdLabel = new System.Windows.Forms.Label();
            this.PersonelAdLabel = new System.Windows.Forms.Label();
            this.PersonelSoyAdText = new System.Windows.Forms.TextBox();
            this.PersonelAdText = new System.Windows.Forms.TextBox();
            this.OyuncuKayitTamamlaButon = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.OyuncuGroupBox1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(517, 52);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(477, 16);
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
            this.SinemasyonLogo.ForeColor = System.Drawing.Color.Purple;
            this.SinemasyonLogo.Location = new System.Drawing.Point(125, 9);
            this.SinemasyonLogo.Name = "SinemasyonLogo";
            this.SinemasyonLogo.Size = new System.Drawing.Size(241, 38);
            this.SinemasyonLogo.TabIndex = 2;
            this.SinemasyonLogo.Text = "PERSONEL KAYIT";
            this.SinemasyonLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OyuncuGroupBox1
            // 
            this.OyuncuGroupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.OyuncuGroupBox1.Controls.Add(this.label1);
            this.OyuncuGroupBox1.Controls.Add(this.PersonelKAdi);
            this.OyuncuGroupBox1.Controls.Add(this.PersonelKSifreText);
            this.OyuncuGroupBox1.Controls.Add(this.PersonelKAdiText);
            this.OyuncuGroupBox1.Controls.Add(this.PersonelSoyAdLabel);
            this.OyuncuGroupBox1.Controls.Add(this.PersonelAdLabel);
            this.OyuncuGroupBox1.Controls.Add(this.PersonelSoyAdText);
            this.OyuncuGroupBox1.Controls.Add(this.PersonelAdText);
            this.OyuncuGroupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OyuncuGroupBox1.Location = new System.Drawing.Point(104, 90);
            this.OyuncuGroupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OyuncuGroupBox1.Name = "OyuncuGroupBox1";
            this.OyuncuGroupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OyuncuGroupBox1.Size = new System.Drawing.Size(272, 281);
            this.OyuncuGroupBox1.TabIndex = 10;
            this.OyuncuGroupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "KULLANICI ŞİFRE";
            // 
            // PersonelKAdi
            // 
            this.PersonelKAdi.AutoSize = true;
            this.PersonelKAdi.Location = new System.Drawing.Point(19, 146);
            this.PersonelKAdi.Name = "PersonelKAdi";
            this.PersonelKAdi.Size = new System.Drawing.Size(98, 16);
            this.PersonelKAdi.TabIndex = 6;
            this.PersonelKAdi.Text = "KULLANICI ADI";
            // 
            // PersonelKSifreText
            // 
            this.PersonelKSifreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelKSifreText.Location = new System.Drawing.Point(19, 223);
            this.PersonelKSifreText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PersonelKSifreText.Name = "PersonelKSifreText";
            this.PersonelKSifreText.Size = new System.Drawing.Size(229, 30);
            this.PersonelKSifreText.TabIndex = 5;
            // 
            // PersonelKAdiText
            // 
            this.PersonelKAdiText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelKAdiText.Location = new System.Drawing.Point(19, 165);
            this.PersonelKAdiText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PersonelKAdiText.Name = "PersonelKAdiText";
            this.PersonelKAdiText.Size = new System.Drawing.Size(229, 30);
            this.PersonelKAdiText.TabIndex = 4;
            // 
            // PersonelSoyAdLabel
            // 
            this.PersonelSoyAdLabel.AutoSize = true;
            this.PersonelSoyAdLabel.Location = new System.Drawing.Point(19, 79);
            this.PersonelSoyAdLabel.Name = "PersonelSoyAdLabel";
            this.PersonelSoyAdLabel.Size = new System.Drawing.Size(54, 16);
            this.PersonelSoyAdLabel.TabIndex = 3;
            this.PersonelSoyAdLabel.Text = "SOYAD";
            // 
            // PersonelAdLabel
            // 
            this.PersonelAdLabel.AutoSize = true;
            this.PersonelAdLabel.Location = new System.Drawing.Point(19, 22);
            this.PersonelAdLabel.Name = "PersonelAdLabel";
            this.PersonelAdLabel.Size = new System.Drawing.Size(26, 16);
            this.PersonelAdLabel.TabIndex = 2;
            this.PersonelAdLabel.Text = "AD";
            // 
            // PersonelSoyAdText
            // 
            this.PersonelSoyAdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelSoyAdText.Location = new System.Drawing.Point(19, 98);
            this.PersonelSoyAdText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PersonelSoyAdText.Name = "PersonelSoyAdText";
            this.PersonelSoyAdText.Size = new System.Drawing.Size(229, 30);
            this.PersonelSoyAdText.TabIndex = 1;
            // 
            // PersonelAdText
            // 
            this.PersonelAdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelAdText.Location = new System.Drawing.Point(19, 41);
            this.PersonelAdText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PersonelAdText.Name = "PersonelAdText";
            this.PersonelAdText.Size = new System.Drawing.Size(229, 30);
            this.PersonelAdText.TabIndex = 0;
            // 
            // OyuncuKayitTamamlaButon
            // 
            this.OyuncuKayitTamamlaButon.BackColor = System.Drawing.Color.Purple;
            this.OyuncuKayitTamamlaButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OyuncuKayitTamamlaButon.ForeColor = System.Drawing.Color.White;
            this.OyuncuKayitTamamlaButon.Location = new System.Drawing.Point(61, 396);
            this.OyuncuKayitTamamlaButon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OyuncuKayitTamamlaButon.Name = "OyuncuKayitTamamlaButon";
            this.OyuncuKayitTamamlaButon.Size = new System.Drawing.Size(352, 42);
            this.OyuncuKayitTamamlaButon.TabIndex = 13;
            this.OyuncuKayitTamamlaButon.Text = "KAYIT TAMAMLA ";
            this.OyuncuKayitTamamlaButon.UseVisualStyleBackColor = false;
            this.OyuncuKayitTamamlaButon.Click += new System.EventHandler(this.OyuncuKayitTamamlaButon_Click);
            // 
            // FrmPersonelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(517, 482);
            this.Controls.Add(this.OyuncuKayitTamamlaButon);
            this.Controls.Add(this.OyuncuGroupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(600, 180);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPersonelEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmPersonelEkle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.OyuncuGroupBox1.ResumeLayout(false);
            this.OyuncuGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SinemasyonLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox OyuncuGroupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PersonelKAdi;
        private System.Windows.Forms.TextBox PersonelKSifreText;
        private System.Windows.Forms.TextBox PersonelKAdiText;
        private System.Windows.Forms.Label PersonelSoyAdLabel;
        private System.Windows.Forms.Label PersonelAdLabel;
        private System.Windows.Forms.TextBox PersonelSoyAdText;
        private System.Windows.Forms.TextBox PersonelAdText;
        private System.Windows.Forms.Button OyuncuKayitTamamlaButon;
    }
}