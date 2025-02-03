namespace Sinemasyon
{
    partial class YonetmenListesi
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
            this.YonetmenListeAdLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.YonetmenListesiPicBox = new System.Windows.Forms.PictureBox();
            this.YonetmenListesiDetayButon = new System.Windows.Forms.Button();
            this.YonetmenNoLabel = new System.Windows.Forms.Label();
            this.YonetmenListesiSilButon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.YonetmenListesiPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // YonetmenListeAdLabel
            // 
            this.YonetmenListeAdLabel.AutoSize = true;
            this.YonetmenListeAdLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YonetmenListeAdLabel.Location = new System.Drawing.Point(181, 16);
            this.YonetmenListeAdLabel.Name = "YonetmenListeAdLabel";
            this.YonetmenListeAdLabel.Size = new System.Drawing.Size(73, 31);
            this.YonetmenListeAdLabel.TabIndex = 0;
            this.YonetmenListeAdLabel.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(17, 138);
            this.panel1.TabIndex = 2;
            // 
            // YonetmenListesiPicBox
            // 
            this.YonetmenListesiPicBox.Image = global::Sinemasyon.Properties.Resources.no_photos;
            this.YonetmenListesiPicBox.Location = new System.Drawing.Point(20, 1);
            this.YonetmenListesiPicBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YonetmenListesiPicBox.Name = "YonetmenListesiPicBox";
            this.YonetmenListesiPicBox.Size = new System.Drawing.Size(108, 76);
            this.YonetmenListesiPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.YonetmenListesiPicBox.TabIndex = 3;
            this.YonetmenListesiPicBox.TabStop = false;
            // 
            // YonetmenListesiDetayButon
            // 
            this.YonetmenListesiDetayButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.YonetmenListesiDetayButon.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YonetmenListesiDetayButon.ForeColor = System.Drawing.Color.White;
            this.YonetmenListesiDetayButon.Location = new System.Drawing.Point(460, 22);
            this.YonetmenListesiDetayButon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YonetmenListesiDetayButon.Name = "YonetmenListesiDetayButon";
            this.YonetmenListesiDetayButon.Size = new System.Drawing.Size(191, 42);
            this.YonetmenListesiDetayButon.TabIndex = 6;
            this.YonetmenListesiDetayButon.Text = "DETAY";
            this.YonetmenListesiDetayButon.UseVisualStyleBackColor = false;
            this.YonetmenListesiDetayButon.Click += new System.EventHandler(this.YonetmenResimYukleBtn_Click);
            // 
            // YonetmenNoLabel
            // 
            this.YonetmenNoLabel.AutoSize = true;
            this.YonetmenNoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YonetmenNoLabel.Location = new System.Drawing.Point(303, 43);
            this.YonetmenNoLabel.Name = "YonetmenNoLabel";
            this.YonetmenNoLabel.Size = new System.Drawing.Size(73, 31);
            this.YonetmenNoLabel.TabIndex = 7;
            this.YonetmenNoLabel.Text = "label1";
            this.YonetmenNoLabel.Visible = false;
            // 
            // YonetmenListesiSilButon
            // 
            this.YonetmenListesiSilButon.BackColor = System.Drawing.Color.Red;
            this.YonetmenListesiSilButon.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YonetmenListesiSilButon.ForeColor = System.Drawing.Color.White;
            this.YonetmenListesiSilButon.Location = new System.Drawing.Point(655, 22);
            this.YonetmenListesiSilButon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YonetmenListesiSilButon.Name = "YonetmenListesiSilButon";
            this.YonetmenListesiSilButon.Size = new System.Drawing.Size(80, 42);
            this.YonetmenListesiSilButon.TabIndex = 8;
            this.YonetmenListesiSilButon.Text = "SİL";
            this.YonetmenListesiSilButon.UseVisualStyleBackColor = false;
            this.YonetmenListesiSilButon.Click += new System.EventHandler(this.YonetmenListesiSilButon_Click);
            // 
            // YonetmenListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.YonetmenListesiSilButon);
            this.Controls.Add(this.YonetmenNoLabel);
            this.Controls.Add(this.YonetmenListesiDetayButon);
            this.Controls.Add(this.YonetmenListesiPicBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.YonetmenListeAdLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "YonetmenListesi";
            this.Size = new System.Drawing.Size(799, 80);
            this.Load += new System.EventHandler(this.YonetmenListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.YonetmenListesiPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label YonetmenListeAdLabel;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox YonetmenListesiPicBox;
        private System.Windows.Forms.Button YonetmenListesiDetayButon;
        public System.Windows.Forms.Label YonetmenNoLabel;
        private System.Windows.Forms.Button YonetmenListesiSilButon;
    }
}
