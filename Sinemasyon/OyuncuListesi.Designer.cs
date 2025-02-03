namespace Sinemasyon
{
    partial class OyuncuListesi
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.OyuncuListesiSilButon = new System.Windows.Forms.Button();
            this.OyuncuNoLabel = new System.Windows.Forms.Label();
            this.OyuncuListesiDetayButon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OyuncuListeAdLabel = new System.Windows.Forms.Label();
            this.OyuncuListesiPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.OyuncuListesiPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OyuncuListesiSilButon
            // 
            this.OyuncuListesiSilButon.BackColor = System.Drawing.Color.Red;
            this.OyuncuListesiSilButon.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OyuncuListesiSilButon.ForeColor = System.Drawing.Color.White;
            this.OyuncuListesiSilButon.Location = new System.Drawing.Point(669, 23);
            this.OyuncuListesiSilButon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OyuncuListesiSilButon.Name = "OyuncuListesiSilButon";
            this.OyuncuListesiSilButon.Size = new System.Drawing.Size(80, 42);
            this.OyuncuListesiSilButon.TabIndex = 14;
            this.OyuncuListesiSilButon.Text = "SİL";
            this.OyuncuListesiSilButon.UseVisualStyleBackColor = false;
            this.OyuncuListesiSilButon.Click += new System.EventHandler(this.OyuncuListesiSilButon_Click);
            // 
            // OyuncuNoLabel
            // 
            this.OyuncuNoLabel.AutoSize = true;
            this.OyuncuNoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OyuncuNoLabel.Location = new System.Drawing.Point(304, 47);
            this.OyuncuNoLabel.Name = "OyuncuNoLabel";
            this.OyuncuNoLabel.Size = new System.Drawing.Size(73, 31);
            this.OyuncuNoLabel.TabIndex = 13;
            this.OyuncuNoLabel.Text = "label1";
            this.OyuncuNoLabel.Visible = false;
            // 
            // OyuncuListesiDetayButon
            // 
            this.OyuncuListesiDetayButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.OyuncuListesiDetayButon.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OyuncuListesiDetayButon.ForeColor = System.Drawing.Color.White;
            this.OyuncuListesiDetayButon.Location = new System.Drawing.Point(473, 23);
            this.OyuncuListesiDetayButon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OyuncuListesiDetayButon.Name = "OyuncuListesiDetayButon";
            this.OyuncuListesiDetayButon.Size = new System.Drawing.Size(191, 42);
            this.OyuncuListesiDetayButon.TabIndex = 12;
            this.OyuncuListesiDetayButon.Text = "DETAY";
            this.OyuncuListesiDetayButon.UseVisualStyleBackColor = false;
            this.OyuncuListesiDetayButon.Click += new System.EventHandler(this.OyuncuListesiDetayButon_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(17, 138);
            this.panel1.TabIndex = 10;
            // 
            // OyuncuListeAdLabel
            // 
            this.OyuncuListeAdLabel.AutoSize = true;
            this.OyuncuListeAdLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OyuncuListeAdLabel.Location = new System.Drawing.Point(181, 23);
            this.OyuncuListeAdLabel.Name = "OyuncuListeAdLabel";
            this.OyuncuListeAdLabel.Size = new System.Drawing.Size(73, 31);
            this.OyuncuListeAdLabel.TabIndex = 9;
            this.OyuncuListeAdLabel.Text = "label1";
            // 
            // OyuncuListesiPicBox
            // 
            this.OyuncuListesiPicBox.Image = global::Sinemasyon.Properties.Resources.no_photos;
            this.OyuncuListesiPicBox.Location = new System.Drawing.Point(20, 2);
            this.OyuncuListesiPicBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OyuncuListesiPicBox.Name = "OyuncuListesiPicBox";
            this.OyuncuListesiPicBox.Size = new System.Drawing.Size(123, 76);
            this.OyuncuListesiPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OyuncuListesiPicBox.TabIndex = 11;
            this.OyuncuListesiPicBox.TabStop = false;
            // 
            // OyuncuListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.OyuncuListesiSilButon);
            this.Controls.Add(this.OyuncuNoLabel);
            this.Controls.Add(this.OyuncuListesiDetayButon);
            this.Controls.Add(this.OyuncuListesiPicBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OyuncuListeAdLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OyuncuListesi";
            this.Size = new System.Drawing.Size(799, 80);
            ((System.ComponentModel.ISupportInitialize)(this.OyuncuListesiPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OyuncuListesiSilButon;
        public System.Windows.Forms.Label OyuncuNoLabel;
        private System.Windows.Forms.Button OyuncuListesiDetayButon;
        public System.Windows.Forms.PictureBox OyuncuListesiPicBox;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label OyuncuListeAdLabel;
    }
}
