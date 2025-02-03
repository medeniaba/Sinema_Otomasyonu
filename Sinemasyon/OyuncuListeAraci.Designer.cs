namespace Sinemasyon
{
    partial class OyuncuListeAraci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OyuncuListeAraci));
            this.OyuncListeAracilbl = new System.Windows.Forms.Label();
            this.OyuncuListeAraciPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.OyuncuListeAraciPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OyuncListeAracilbl
            // 
            this.OyuncListeAracilbl.AutoSize = true;
            this.OyuncListeAracilbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OyuncListeAracilbl.Location = new System.Drawing.Point(31, 8);
            this.OyuncListeAracilbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OyuncListeAracilbl.Name = "OyuncListeAracilbl";
            this.OyuncListeAracilbl.Size = new System.Drawing.Size(41, 15);
            this.OyuncListeAracilbl.TabIndex = 1;
            this.OyuncListeAracilbl.Text = "label1";
            this.OyuncListeAracilbl.Click += new System.EventHandler(this.OyuncListeAracilbl_Click);
            this.OyuncListeAracilbl.MouseLeave += new System.EventHandler(this.OyuncListeAracilbl_MouseLeave);
            this.OyuncListeAracilbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OyuncListeAracilbl_MouseMove);
            // 
            // OyuncuListeAraciPicBox
            // 
            this.OyuncuListeAraciPicBox.Image = ((System.Drawing.Image)(resources.GetObject("OyuncuListeAraciPicBox.Image")));
            this.OyuncuListeAraciPicBox.Location = new System.Drawing.Point(3, 5);
            this.OyuncuListeAraciPicBox.Margin = new System.Windows.Forms.Padding(2);
            this.OyuncuListeAraciPicBox.Name = "OyuncuListeAraciPicBox";
            this.OyuncuListeAraciPicBox.Size = new System.Drawing.Size(20, 20);
            this.OyuncuListeAraciPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OyuncuListeAraciPicBox.TabIndex = 0;
            this.OyuncuListeAraciPicBox.TabStop = false;
            this.OyuncuListeAraciPicBox.Click += new System.EventHandler(this.OyuncuListeAraciPicBox_Click);
            // 
            // OyuncuListeAraci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OyuncListeAracilbl);
            this.Controls.Add(this.OyuncuListeAraciPicBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OyuncuListeAraci";
            this.Size = new System.Drawing.Size(153, 30);
            this.Load += new System.EventHandler(this.OyuncuListeAraci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OyuncuListeAraciPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox OyuncuListeAraciPicBox;
        public System.Windows.Forms.Label OyuncListeAracilbl;
    }
}
