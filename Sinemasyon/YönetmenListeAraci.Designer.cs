namespace Sinemasyon
{
    partial class YönetmenListeAraci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YönetmenListeAraci));
            this.YonetmenListeAracilbl = new System.Windows.Forms.Label();
            this.YonetmenListeAraciPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.YonetmenListeAraciPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // YonetmenListeAracilbl
            // 
            this.YonetmenListeAracilbl.AutoSize = true;
            this.YonetmenListeAracilbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YonetmenListeAracilbl.Location = new System.Drawing.Point(31, 8);
            this.YonetmenListeAracilbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.YonetmenListeAracilbl.Name = "YonetmenListeAracilbl";
            this.YonetmenListeAracilbl.Size = new System.Drawing.Size(41, 15);
            this.YonetmenListeAracilbl.TabIndex = 3;
            this.YonetmenListeAracilbl.Text = "label1";
            this.YonetmenListeAracilbl.Click += new System.EventHandler(this.YonetmenListeAracilbl_Click);
            this.YonetmenListeAracilbl.MouseLeave += new System.EventHandler(this.YonetmenListeAracilbl_MouseLeave);
            this.YonetmenListeAracilbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.YonetmenListeAracilbl_MouseMove);
            // 
            // YonetmenListeAraciPicBox
            // 
            this.YonetmenListeAraciPicBox.Image = ((System.Drawing.Image)(resources.GetObject("YonetmenListeAraciPicBox.Image")));
            this.YonetmenListeAraciPicBox.Location = new System.Drawing.Point(3, 5);
            this.YonetmenListeAraciPicBox.Margin = new System.Windows.Forms.Padding(2);
            this.YonetmenListeAraciPicBox.Name = "YonetmenListeAraciPicBox";
            this.YonetmenListeAraciPicBox.Size = new System.Drawing.Size(20, 20);
            this.YonetmenListeAraciPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.YonetmenListeAraciPicBox.TabIndex = 2;
            this.YonetmenListeAraciPicBox.TabStop = false;
            this.YonetmenListeAraciPicBox.Click += new System.EventHandler(this.YonetmneListeAraciPicBox_Click);
            // 
            // YönetmenListeAraci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.YonetmenListeAracilbl);
            this.Controls.Add(this.YonetmenListeAraciPicBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "YönetmenListeAraci";
            this.Size = new System.Drawing.Size(153, 30);
            this.Load += new System.EventHandler(this.YönetmenListeAraci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.YonetmenListeAraciPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label YonetmenListeAracilbl;
        private System.Windows.Forms.PictureBox YonetmenListeAraciPicBox;
    }
}
