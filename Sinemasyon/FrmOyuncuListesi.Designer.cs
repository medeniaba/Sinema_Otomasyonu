namespace Sinemasyon
{
    partial class FrmOyuncuListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOyuncuListesi));
            this.OyuncuListeFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SinemasyonLogo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OyuncuListesiAramaText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OyuncuListeFlowPanel
            // 
            this.OyuncuListeFlowPanel.AutoSize = true;
            this.OyuncuListeFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OyuncuListeFlowPanel.Location = new System.Drawing.Point(0, 95);
            this.OyuncuListeFlowPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OyuncuListeFlowPanel.Name = "OyuncuListeFlowPanel";
            this.OyuncuListeFlowPanel.Size = new System.Drawing.Size(799, 527);
            this.OyuncuListeFlowPanel.TabIndex = 6;
            // 
            // SinemasyonLogo
            // 
            this.SinemasyonLogo.AutoSize = true;
            this.SinemasyonLogo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SinemasyonLogo.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SinemasyonLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SinemasyonLogo.Location = new System.Drawing.Point(257, 7);
            this.SinemasyonLogo.Name = "SinemasyonLogo";
            this.SinemasyonLogo.Size = new System.Drawing.Size(236, 38);
            this.SinemasyonLogo.TabIndex = 2;
            this.SinemasyonLogo.Text = "OYUNCU LİSTESİ";
            this.SinemasyonLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.SinemasyonLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 95);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Purple;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.OyuncuListesiAramaText);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 38);
            this.panel2.TabIndex = 5;
            // 
            // OyuncuListesiAramaText
            // 
            this.OyuncuListesiAramaText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OyuncuListesiAramaText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.OyuncuListesiAramaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OyuncuListesiAramaText.Location = new System.Drawing.Point(145, 9);
            this.OyuncuListesiAramaText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OyuncuListesiAramaText.Name = "OyuncuListesiAramaText";
            this.OyuncuListesiAramaText.Size = new System.Drawing.Size(183, 20);
            this.OyuncuListesiAramaText.TabIndex = 5;
            this.OyuncuListesiAramaText.TextChanged += new System.EventHandler(this.OyuncuListesiAramaText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "AD VE SOYAD : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(763, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmOyuncuListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 622);
            this.Controls.Add(this.OyuncuListeFlowPanel);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(600, 180);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmOyuncuListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmOyuncuListesi";
            this.Load += new System.EventHandler(this.FrmOyuncuListesi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel OyuncuListeFlowPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label SinemasyonLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox OyuncuListesiAramaText;
        private System.Windows.Forms.Label label1;
    }
}