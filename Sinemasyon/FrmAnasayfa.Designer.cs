namespace Sinemasyon
{
    partial class FrmAnasayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnasayfa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SinemasyonLogo = new System.Windows.Forms.Label();
            this.FilmTimer = new System.Windows.Forms.Timer(this.components);
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.YönetmenTimer = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.YonetmenContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.YönetmenAyarlarıPaneli = new System.Windows.Forms.Panel();
            this.BtnYonetmen = new System.Windows.Forms.Button();
            this.YönetmenKayıtPaneli = new System.Windows.Forms.Panel();
            this.BtnYonetmenKayıtEkranı = new System.Windows.Forms.Button();
            this.YönetmenListeEkranıPaneli = new System.Windows.Forms.Panel();
            this.BtnYonetmenListeEkranı = new System.Windows.Forms.Button();
            this.OyuncuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.OyuncuAyarlarıPaneli = new System.Windows.Forms.Panel();
            this.BtnOyuncu = new System.Windows.Forms.Button();
            this.OyuncuKayıtEkranıPaneli = new System.Windows.Forms.Panel();
            this.BtnOyuncuKayıtEkranı = new System.Windows.Forms.Button();
            this.OyuncuListeEkranıPaneli = new System.Windows.Forms.Panel();
            this.BtnOyuncuListeEkranı = new System.Windows.Forms.Button();
            this.BiletContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.BiletAyarlariPanel = new System.Windows.Forms.Panel();
            this.BtnBiletAyarlari = new System.Windows.Forms.Button();
            this.BiletOlusturmaEkraniPanel = new System.Windows.Forms.Panel();
            this.BtnBiletOlusturmaEkrani = new System.Windows.Forms.Button();
            this.BiletSorgulamaEkraniPanel = new System.Windows.Forms.Panel();
            this.BtnBiletSorgulamaEkrani = new System.Windows.Forms.Button();
            this.FilmContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.filmSttngsBttn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnFilmEkle = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.FilmListelemeButonu = new System.Windows.Forms.Button();
            this.BtnSalonKayıtEkrani = new System.Windows.Forms.Button();
            this.BtnSalonAtamaEkrani = new System.Windows.Forms.Button();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.OyuncuTimer = new System.Windows.Forms.Timer(this.components);
            this.BiletTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.YonetmenContainer.SuspendLayout();
            this.YönetmenAyarlarıPaneli.SuspendLayout();
            this.YönetmenKayıtPaneli.SuspendLayout();
            this.YönetmenListeEkranıPaneli.SuspendLayout();
            this.OyuncuContainer.SuspendLayout();
            this.OyuncuAyarlarıPaneli.SuspendLayout();
            this.OyuncuKayıtEkranıPaneli.SuspendLayout();
            this.OyuncuListeEkranıPaneli.SuspendLayout();
            this.BiletContainer.SuspendLayout();
            this.BiletAyarlariPanel.SuspendLayout();
            this.BiletOlusturmaEkraniPanel.SuspendLayout();
            this.BiletSorgulamaEkraniPanel.SuspendLayout();
            this.FilmContainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.SinemasyonLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 62);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // SinemasyonLogo
            // 
            this.SinemasyonLogo.AutoSize = true;
            this.SinemasyonLogo.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SinemasyonLogo.Location = new System.Drawing.Point(12, 9);
            this.SinemasyonLogo.Name = "SinemasyonLogo";
            this.SinemasyonLogo.Size = new System.Drawing.Size(159, 37);
            this.SinemasyonLogo.TabIndex = 2;
            this.SinemasyonLogo.Text = "Sinemasyon";
            // 
            // FilmTimer
            // 
            this.FilmTimer.Interval = 10;
            this.FilmTimer.Tick += new System.EventHandler(this.settingsTransition_Tick);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "actress.png");
            this.ımageList1.Images.SetKeyName(1, "casting.png");
            this.ımageList1.Images.SetKeyName(2, "theatre.png");
            this.ımageList1.Images.SetKeyName(3, "right.png");
            this.ımageList1.Images.SetKeyName(4, "next.png");
            this.ımageList1.Images.SetKeyName(5, "interface.png");
            this.ımageList1.Images.SetKeyName(6, "list.png");
            this.ımageList1.Images.SetKeyName(7, "ticket.png");
            this.ımageList1.Images.SetKeyName(8, "log-out.png");
            this.ımageList1.Images.SetKeyName(9, "cinema-screen.png");
            this.ımageList1.Images.SetKeyName(10, "theater.png");
            // 
            // YönetmenTimer
            // 
            this.YönetmenTimer.Interval = 10;
            this.YönetmenTimer.Tick += new System.EventHandler(this.Yönetmen_Ayarları_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.flowLayoutPanel1.Controls.Add(this.YonetmenContainer);
            this.flowLayoutPanel1.Controls.Add(this.OyuncuContainer);
            this.flowLayoutPanel1.Controls.Add(this.BiletContainer);
            this.flowLayoutPanel1.Controls.Add(this.FilmContainer);
            this.flowLayoutPanel1.Controls.Add(this.BtnSalonKayıtEkrani);
            this.flowLayoutPanel1.Controls.Add(this.BtnSalonAtamaEkrani);
            this.flowLayoutPanel1.Controls.Add(this.BtnCikis);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 62);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 618);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // YonetmenContainer
            // 
            this.YonetmenContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.YonetmenContainer.Controls.Add(this.YönetmenAyarlarıPaneli);
            this.YonetmenContainer.Controls.Add(this.YönetmenKayıtPaneli);
            this.YonetmenContainer.Controls.Add(this.YönetmenListeEkranıPaneli);
            this.YonetmenContainer.Location = new System.Drawing.Point(3, 3);
            this.YonetmenContainer.Name = "YonetmenContainer";
            this.YonetmenContainer.Size = new System.Drawing.Size(274, 97);
            this.YonetmenContainer.TabIndex = 9;
            this.YonetmenContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.YonetmenContaiener_Paint_1);
            // 
            // YönetmenAyarlarıPaneli
            // 
            this.YönetmenAyarlarıPaneli.Controls.Add(this.BtnYonetmen);
            this.YönetmenAyarlarıPaneli.Location = new System.Drawing.Point(3, 3);
            this.YönetmenAyarlarıPaneli.Name = "YönetmenAyarlarıPaneli";
            this.YönetmenAyarlarıPaneli.Size = new System.Drawing.Size(245, 80);
            this.YönetmenAyarlarıPaneli.TabIndex = 5;
            // 
            // BtnYonetmen
            // 
            this.BtnYonetmen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.BtnYonetmen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnYonetmen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnYonetmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYonetmen.ForeColor = System.Drawing.Color.White;
            this.BtnYonetmen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnYonetmen.ImageKey = "actress.png";
            this.BtnYonetmen.ImageList = this.ımageList1;
            this.BtnYonetmen.Location = new System.Drawing.Point(-8, -8);
            this.BtnYonetmen.Margin = new System.Windows.Forms.Padding(0);
            this.BtnYonetmen.Name = "BtnYonetmen";
            this.BtnYonetmen.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.BtnYonetmen.Size = new System.Drawing.Size(258, 97);
            this.BtnYonetmen.TabIndex = 3;
            this.BtnYonetmen.Text = "Yönetmen  Ayarları";
            this.BtnYonetmen.UseVisualStyleBackColor = false;
            this.BtnYonetmen.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // YönetmenKayıtPaneli
            // 
            this.YönetmenKayıtPaneli.Controls.Add(this.BtnYonetmenKayıtEkranı);
            this.YönetmenKayıtPaneli.Location = new System.Drawing.Point(3, 89);
            this.YönetmenKayıtPaneli.Name = "YönetmenKayıtPaneli";
            this.YönetmenKayıtPaneli.Size = new System.Drawing.Size(234, 59);
            this.YönetmenKayıtPaneli.TabIndex = 6;
            // 
            // BtnYonetmenKayıtEkranı
            // 
            this.BtnYonetmenKayıtEkranı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.BtnYonetmenKayıtEkranı.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnYonetmenKayıtEkranı.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnYonetmenKayıtEkranı.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYonetmenKayıtEkranı.ForeColor = System.Drawing.Color.White;
            this.BtnYonetmenKayıtEkranı.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnYonetmenKayıtEkranı.ImageKey = "next.png";
            this.BtnYonetmenKayıtEkranı.ImageList = this.ımageList1;
            this.BtnYonetmenKayıtEkranı.Location = new System.Drawing.Point(-3, 3);
            this.BtnYonetmenKayıtEkranı.Margin = new System.Windows.Forms.Padding(0);
            this.BtnYonetmenKayıtEkranı.Name = "BtnYonetmenKayıtEkranı";
            this.BtnYonetmenKayıtEkranı.Size = new System.Drawing.Size(237, 49);
            this.BtnYonetmenKayıtEkranı.TabIndex = 4;
            this.BtnYonetmenKayıtEkranı.Text = "    Yönetmen Kayıt Ekranı";
            this.BtnYonetmenKayıtEkranı.UseVisualStyleBackColor = false;
            this.BtnYonetmenKayıtEkranı.Click += new System.EventHandler(this.BtnYonetmenKayıtEkranı_Click_1);
            // 
            // YönetmenListeEkranıPaneli
            // 
            this.YönetmenListeEkranıPaneli.Controls.Add(this.BtnYonetmenListeEkranı);
            this.YönetmenListeEkranıPaneli.Location = new System.Drawing.Point(3, 154);
            this.YönetmenListeEkranıPaneli.Name = "YönetmenListeEkranıPaneli";
            this.YönetmenListeEkranıPaneli.Size = new System.Drawing.Size(234, 60);
            this.YönetmenListeEkranıPaneli.TabIndex = 7;
            // 
            // BtnYonetmenListeEkranı
            // 
            this.BtnYonetmenListeEkranı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.BtnYonetmenListeEkranı.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnYonetmenListeEkranı.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnYonetmenListeEkranı.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYonetmenListeEkranı.ForeColor = System.Drawing.Color.White;
            this.BtnYonetmenListeEkranı.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnYonetmenListeEkranı.ImageKey = "next.png";
            this.BtnYonetmenListeEkranı.ImageList = this.ımageList1;
            this.BtnYonetmenListeEkranı.Location = new System.Drawing.Point(-1, 0);
            this.BtnYonetmenListeEkranı.Margin = new System.Windows.Forms.Padding(0);
            this.BtnYonetmenListeEkranı.Name = "BtnYonetmenListeEkranı";
            this.BtnYonetmenListeEkranı.Size = new System.Drawing.Size(235, 43);
            this.BtnYonetmenListeEkranı.TabIndex = 5;
            this.BtnYonetmenListeEkranı.Text = "   Yönetmen  Liste Ekranı";
            this.BtnYonetmenListeEkranı.UseVisualStyleBackColor = false;
            this.BtnYonetmenListeEkranı.Click += new System.EventHandler(this.BtnYonetmenListeEkranı_Click);
            // 
            // OyuncuContainer
            // 
            this.OyuncuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.OyuncuContainer.Controls.Add(this.OyuncuAyarlarıPaneli);
            this.OyuncuContainer.Controls.Add(this.OyuncuKayıtEkranıPaneli);
            this.OyuncuContainer.Controls.Add(this.OyuncuListeEkranıPaneli);
            this.OyuncuContainer.Location = new System.Drawing.Point(3, 106);
            this.OyuncuContainer.Name = "OyuncuContainer";
            this.OyuncuContainer.Size = new System.Drawing.Size(274, 97);
            this.OyuncuContainer.TabIndex = 10;
            this.OyuncuContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.OyuncuContainer_Paint);
            // 
            // OyuncuAyarlarıPaneli
            // 
            this.OyuncuAyarlarıPaneli.Controls.Add(this.BtnOyuncu);
            this.OyuncuAyarlarıPaneli.Location = new System.Drawing.Point(3, 3);
            this.OyuncuAyarlarıPaneli.Name = "OyuncuAyarlarıPaneli";
            this.OyuncuAyarlarıPaneli.Size = new System.Drawing.Size(245, 80);
            this.OyuncuAyarlarıPaneli.TabIndex = 5;
            // 
            // BtnOyuncu
            // 
            this.BtnOyuncu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.BtnOyuncu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOyuncu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOyuncu.ForeColor = System.Drawing.Color.White;
            this.BtnOyuncu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOyuncu.ImageKey = "theatre.png";
            this.BtnOyuncu.ImageList = this.ımageList1;
            this.BtnOyuncu.Location = new System.Drawing.Point(2, -2);
            this.BtnOyuncu.Name = "BtnOyuncu";
            this.BtnOyuncu.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnOyuncu.Size = new System.Drawing.Size(245, 97);
            this.BtnOyuncu.TabIndex = 3;
            this.BtnOyuncu.Text = "Oyuncu Ayarları";
            this.BtnOyuncu.UseVisualStyleBackColor = false;
            this.BtnOyuncu.Click += new System.EventHandler(this.sellBttn_Click);
            // 
            // OyuncuKayıtEkranıPaneli
            // 
            this.OyuncuKayıtEkranıPaneli.Controls.Add(this.BtnOyuncuKayıtEkranı);
            this.OyuncuKayıtEkranıPaneli.Location = new System.Drawing.Point(3, 89);
            this.OyuncuKayıtEkranıPaneli.Name = "OyuncuKayıtEkranıPaneli";
            this.OyuncuKayıtEkranıPaneli.Size = new System.Drawing.Size(234, 59);
            this.OyuncuKayıtEkranıPaneli.TabIndex = 6;
            // 
            // BtnOyuncuKayıtEkranı
            // 
            this.BtnOyuncuKayıtEkranı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.BtnOyuncuKayıtEkranı.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOyuncuKayıtEkranı.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOyuncuKayıtEkranı.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOyuncuKayıtEkranı.ForeColor = System.Drawing.Color.White;
            this.BtnOyuncuKayıtEkranı.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOyuncuKayıtEkranı.ImageKey = "next.png";
            this.BtnOyuncuKayıtEkranı.ImageList = this.ımageList1;
            this.BtnOyuncuKayıtEkranı.Location = new System.Drawing.Point(-3, 3);
            this.BtnOyuncuKayıtEkranı.Margin = new System.Windows.Forms.Padding(0);
            this.BtnOyuncuKayıtEkranı.Name = "BtnOyuncuKayıtEkranı";
            this.BtnOyuncuKayıtEkranı.Size = new System.Drawing.Size(237, 49);
            this.BtnOyuncuKayıtEkranı.TabIndex = 4;
            this.BtnOyuncuKayıtEkranı.Text = "      Oyuncu Kayıt Ekranı";
            this.BtnOyuncuKayıtEkranı.UseVisualStyleBackColor = false;
            this.BtnOyuncuKayıtEkranı.Click += new System.EventHandler(this.BtnOyuncuKayıtEkranı_Click);
            // 
            // OyuncuListeEkranıPaneli
            // 
            this.OyuncuListeEkranıPaneli.Controls.Add(this.BtnOyuncuListeEkranı);
            this.OyuncuListeEkranıPaneli.Location = new System.Drawing.Point(3, 154);
            this.OyuncuListeEkranıPaneli.Name = "OyuncuListeEkranıPaneli";
            this.OyuncuListeEkranıPaneli.Size = new System.Drawing.Size(234, 60);
            this.OyuncuListeEkranıPaneli.TabIndex = 7;
            // 
            // BtnOyuncuListeEkranı
            // 
            this.BtnOyuncuListeEkranı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.BtnOyuncuListeEkranı.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOyuncuListeEkranı.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOyuncuListeEkranı.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOyuncuListeEkranı.ForeColor = System.Drawing.Color.White;
            this.BtnOyuncuListeEkranı.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOyuncuListeEkranı.ImageKey = "next.png";
            this.BtnOyuncuListeEkranı.ImageList = this.ımageList1;
            this.BtnOyuncuListeEkranı.Location = new System.Drawing.Point(-1, 0);
            this.BtnOyuncuListeEkranı.Margin = new System.Windows.Forms.Padding(0);
            this.BtnOyuncuListeEkranı.Name = "BtnOyuncuListeEkranı";
            this.BtnOyuncuListeEkranı.Size = new System.Drawing.Size(235, 43);
            this.BtnOyuncuListeEkranı.TabIndex = 5;
            this.BtnOyuncuListeEkranı.Text = "   Oyuncu Liste Ekranı";
            this.BtnOyuncuListeEkranı.UseVisualStyleBackColor = false;
            this.BtnOyuncuListeEkranı.Click += new System.EventHandler(this.BtnOyuncuListeEkranı_Click);
            // 
            // BiletContainer
            // 
            this.BiletContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.BiletContainer.Controls.Add(this.BiletAyarlariPanel);
            this.BiletContainer.Controls.Add(this.BiletOlusturmaEkraniPanel);
            this.BiletContainer.Controls.Add(this.BiletSorgulamaEkraniPanel);
            this.BiletContainer.Location = new System.Drawing.Point(3, 209);
            this.BiletContainer.Name = "BiletContainer";
            this.BiletContainer.Size = new System.Drawing.Size(274, 97);
            this.BiletContainer.TabIndex = 11;
            // 
            // BiletAyarlariPanel
            // 
            this.BiletAyarlariPanel.Controls.Add(this.BtnBiletAyarlari);
            this.BiletAyarlariPanel.Location = new System.Drawing.Point(3, 3);
            this.BiletAyarlariPanel.Name = "BiletAyarlariPanel";
            this.BiletAyarlariPanel.Size = new System.Drawing.Size(245, 80);
            this.BiletAyarlariPanel.TabIndex = 5;
            // 
            // BtnBiletAyarlari
            // 
            this.BtnBiletAyarlari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.BtnBiletAyarlari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBiletAyarlari.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBiletAyarlari.ForeColor = System.Drawing.Color.White;
            this.BtnBiletAyarlari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBiletAyarlari.ImageKey = "ticket.png";
            this.BtnBiletAyarlari.ImageList = this.ımageList1;
            this.BtnBiletAyarlari.Location = new System.Drawing.Point(3, -8);
            this.BtnBiletAyarlari.Name = "BtnBiletAyarlari";
            this.BtnBiletAyarlari.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnBiletAyarlari.Size = new System.Drawing.Size(245, 97);
            this.BtnBiletAyarlari.TabIndex = 3;
            this.BtnBiletAyarlari.Text = "Bilet Ayarları";
            this.BtnBiletAyarlari.UseVisualStyleBackColor = false;
            this.BtnBiletAyarlari.Click += new System.EventHandler(this.BtnBiletAyarlari_Click);
            // 
            // BiletOlusturmaEkraniPanel
            // 
            this.BiletOlusturmaEkraniPanel.Controls.Add(this.BtnBiletOlusturmaEkrani);
            this.BiletOlusturmaEkraniPanel.Location = new System.Drawing.Point(3, 89);
            this.BiletOlusturmaEkraniPanel.Name = "BiletOlusturmaEkraniPanel";
            this.BiletOlusturmaEkraniPanel.Size = new System.Drawing.Size(234, 59);
            this.BiletOlusturmaEkraniPanel.TabIndex = 6;
            // 
            // BtnBiletOlusturmaEkrani
            // 
            this.BtnBiletOlusturmaEkrani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.BtnBiletOlusturmaEkrani.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBiletOlusturmaEkrani.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBiletOlusturmaEkrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBiletOlusturmaEkrani.ForeColor = System.Drawing.Color.White;
            this.BtnBiletOlusturmaEkrani.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBiletOlusturmaEkrani.ImageKey = "next.png";
            this.BtnBiletOlusturmaEkrani.ImageList = this.ımageList1;
            this.BtnBiletOlusturmaEkrani.Location = new System.Drawing.Point(3, 6);
            this.BtnBiletOlusturmaEkrani.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBiletOlusturmaEkrani.Name = "BtnBiletOlusturmaEkrani";
            this.BtnBiletOlusturmaEkrani.Size = new System.Drawing.Size(237, 49);
            this.BtnBiletOlusturmaEkrani.TabIndex = 4;
            this.BtnBiletOlusturmaEkrani.Text = "     Bilet Oluşturma Ekranı";
            this.BtnBiletOlusturmaEkrani.UseVisualStyleBackColor = false;
            this.BtnBiletOlusturmaEkrani.Click += new System.EventHandler(this.BtnBiletOlusturmaEkrani_Click);
            // 
            // BiletSorgulamaEkraniPanel
            // 
            this.BiletSorgulamaEkraniPanel.Controls.Add(this.BtnBiletSorgulamaEkrani);
            this.BiletSorgulamaEkraniPanel.Location = new System.Drawing.Point(3, 154);
            this.BiletSorgulamaEkraniPanel.Name = "BiletSorgulamaEkraniPanel";
            this.BiletSorgulamaEkraniPanel.Size = new System.Drawing.Size(234, 60);
            this.BiletSorgulamaEkraniPanel.TabIndex = 7;
            // 
            // BtnBiletSorgulamaEkrani
            // 
            this.BtnBiletSorgulamaEkrani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.BtnBiletSorgulamaEkrani.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBiletSorgulamaEkrani.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBiletSorgulamaEkrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBiletSorgulamaEkrani.ForeColor = System.Drawing.Color.White;
            this.BtnBiletSorgulamaEkrani.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBiletSorgulamaEkrani.ImageKey = "next.png";
            this.BtnBiletSorgulamaEkrani.ImageList = this.ımageList1;
            this.BtnBiletSorgulamaEkrani.Location = new System.Drawing.Point(3, 0);
            this.BtnBiletSorgulamaEkrani.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBiletSorgulamaEkrani.Name = "BtnBiletSorgulamaEkrani";
            this.BtnBiletSorgulamaEkrani.Size = new System.Drawing.Size(235, 43);
            this.BtnBiletSorgulamaEkrani.TabIndex = 5;
            this.BtnBiletSorgulamaEkrani.Text = "   Bilet Sorgulama Ekranı";
            this.BtnBiletSorgulamaEkrani.UseVisualStyleBackColor = false;
            this.BtnBiletSorgulamaEkrani.Click += new System.EventHandler(this.BtnBiletSorgulamaEkrani_Click);
            // 
            // FilmContainer
            // 
            this.FilmContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.FilmContainer.Controls.Add(this.panel3);
            this.FilmContainer.Controls.Add(this.panel4);
            this.FilmContainer.Controls.Add(this.panel5);
            this.FilmContainer.Location = new System.Drawing.Point(3, 312);
            this.FilmContainer.Name = "FilmContainer";
            this.FilmContainer.Size = new System.Drawing.Size(274, 97);
            this.FilmContainer.TabIndex = 8;
            this.FilmContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.filmSttngsBttn);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 80);
            this.panel3.TabIndex = 5;
            // 
            // filmSttngsBttn
            // 
            this.filmSttngsBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.filmSttngsBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filmSttngsBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.filmSttngsBttn.ForeColor = System.Drawing.Color.White;
            this.filmSttngsBttn.Image = ((System.Drawing.Image)(resources.GetObject("filmSttngsBttn.Image")));
            this.filmSttngsBttn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filmSttngsBttn.Location = new System.Drawing.Point(-10, -20);
            this.filmSttngsBttn.Margin = new System.Windows.Forms.Padding(0);
            this.filmSttngsBttn.Name = "filmSttngsBttn";
            this.filmSttngsBttn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.filmSttngsBttn.Size = new System.Drawing.Size(255, 97);
            this.filmSttngsBttn.TabIndex = 3;
            this.filmSttngsBttn.Text = " Film Ayarları\r\n";
            this.filmSttngsBttn.UseVisualStyleBackColor = false;
            this.filmSttngsBttn.Click += new System.EventHandler(this.filmSttngsBttn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BtnFilmEkle);
            this.panel4.Location = new System.Drawing.Point(3, 89);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(234, 59);
            this.panel4.TabIndex = 6;
            // 
            // BtnFilmEkle
            // 
            this.BtnFilmEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.BtnFilmEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFilmEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFilmEkle.ForeColor = System.Drawing.Color.White;
            this.BtnFilmEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFilmEkle.ImageKey = "interface.png";
            this.BtnFilmEkle.ImageList = this.ımageList1;
            this.BtnFilmEkle.Location = new System.Drawing.Point(-2, -3);
            this.BtnFilmEkle.Name = "BtnFilmEkle";
            this.BtnFilmEkle.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.BtnFilmEkle.Size = new System.Drawing.Size(273, 59);
            this.BtnFilmEkle.TabIndex = 3;
            this.BtnFilmEkle.Text = "Film Ekleme";
            this.BtnFilmEkle.UseVisualStyleBackColor = false;
            this.BtnFilmEkle.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.FilmListelemeButonu);
            this.panel5.Location = new System.Drawing.Point(3, 154);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(234, 60);
            this.panel5.TabIndex = 7;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // FilmListelemeButonu
            // 
            this.FilmListelemeButonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.FilmListelemeButonu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FilmListelemeButonu.ForeColor = System.Drawing.Color.White;
            this.FilmListelemeButonu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FilmListelemeButonu.ImageKey = "list.png";
            this.FilmListelemeButonu.ImageList = this.ımageList1;
            this.FilmListelemeButonu.Location = new System.Drawing.Point(0, -5);
            this.FilmListelemeButonu.Margin = new System.Windows.Forms.Padding(0);
            this.FilmListelemeButonu.Name = "FilmListelemeButonu";
            this.FilmListelemeButonu.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.FilmListelemeButonu.Size = new System.Drawing.Size(271, 61);
            this.FilmListelemeButonu.TabIndex = 3;
            this.FilmListelemeButonu.Text = "        Film Listeleme";
            this.FilmListelemeButonu.UseVisualStyleBackColor = false;
            this.FilmListelemeButonu.Click += new System.EventHandler(this.FilmListelemeButonu_Click);
            // 
            // BtnSalonKayıtEkrani
            // 
            this.BtnSalonKayıtEkrani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.BtnSalonKayıtEkrani.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalonKayıtEkrani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalonKayıtEkrani.ForeColor = System.Drawing.Color.White;
            this.BtnSalonKayıtEkrani.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalonKayıtEkrani.ImageKey = "cinema-screen.png";
            this.BtnSalonKayıtEkrani.ImageList = this.ımageList1;
            this.BtnSalonKayıtEkrani.Location = new System.Drawing.Point(3, 415);
            this.BtnSalonKayıtEkrani.Name = "BtnSalonKayıtEkrani";
            this.BtnSalonKayıtEkrani.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnSalonKayıtEkrani.Size = new System.Drawing.Size(241, 61);
            this.BtnSalonKayıtEkrani.TabIndex = 3;
            this.BtnSalonKayıtEkrani.Text = "  Salon Kayıt Ekranı";
            this.BtnSalonKayıtEkrani.UseVisualStyleBackColor = false;
            this.BtnSalonKayıtEkrani.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnSalonAtamaEkrani
            // 
            this.BtnSalonAtamaEkrani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.BtnSalonAtamaEkrani.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalonAtamaEkrani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalonAtamaEkrani.ForeColor = System.Drawing.Color.White;
            this.BtnSalonAtamaEkrani.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalonAtamaEkrani.ImageKey = "theater.png";
            this.BtnSalonAtamaEkrani.ImageList = this.ımageList1;
            this.BtnSalonAtamaEkrani.Location = new System.Drawing.Point(3, 482);
            this.BtnSalonAtamaEkrani.Name = "BtnSalonAtamaEkrani";
            this.BtnSalonAtamaEkrani.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnSalonAtamaEkrani.Size = new System.Drawing.Size(241, 61);
            this.BtnSalonAtamaEkrani.TabIndex = 5;
            this.BtnSalonAtamaEkrani.Text = "Salon Atama Ekranı";
            this.BtnSalonAtamaEkrani.UseVisualStyleBackColor = false;
            this.BtnSalonAtamaEkrani.Click += new System.EventHandler(this.BtnSalonAtamaEkrani_Click);
            // 
            // BtnCikis
            // 
            this.BtnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.BtnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCikis.ForeColor = System.Drawing.Color.White;
            this.BtnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCikis.ImageKey = "log-out.png";
            this.BtnCikis.ImageList = this.ımageList1;
            this.BtnCikis.Location = new System.Drawing.Point(3, 549);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnCikis.Size = new System.Drawing.Size(241, 61);
            this.BtnCikis.TabIndex = 6;
            this.BtnCikis.Text = "Çıkış";
            this.BtnCikis.UseVisualStyleBackColor = false;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // OyuncuTimer
            // 
            this.OyuncuTimer.Interval = 10;
            this.OyuncuTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BiletTimer
            // 
            this.BiletTimer.Interval = 10;
            this.BiletTimer.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(956, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(914, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FrmAnasayfa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(992, 680);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAnasayfa";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.FrmAnasayfa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.YonetmenContainer.ResumeLayout(false);
            this.YönetmenAyarlarıPaneli.ResumeLayout(false);
            this.YönetmenKayıtPaneli.ResumeLayout(false);
            this.YönetmenListeEkranıPaneli.ResumeLayout(false);
            this.OyuncuContainer.ResumeLayout(false);
            this.OyuncuAyarlarıPaneli.ResumeLayout(false);
            this.OyuncuKayıtEkranıPaneli.ResumeLayout(false);
            this.OyuncuListeEkranıPaneli.ResumeLayout(false);
            this.BiletContainer.ResumeLayout(false);
            this.BiletAyarlariPanel.ResumeLayout(false);
            this.BiletOlusturmaEkraniPanel.ResumeLayout(false);
            this.BiletSorgulamaEkraniPanel.ResumeLayout(false);
            this.FilmContainer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SinemasyonLogo;
        private System.Windows.Forms.Timer FilmTimer;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button BtnSalonKayıtEkrani;
        private System.Windows.Forms.Button BtnOyuncu;
        private System.Windows.Forms.Button filmSttngsBttn;
        private System.Windows.Forms.Button BtnFilmEkle;
        private System.Windows.Forms.Button FilmListelemeButonu;
        private System.Windows.Forms.Timer YönetmenTimer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel FilmContainer;
        private System.Windows.Forms.FlowLayoutPanel OyuncuContainer;
        private System.Windows.Forms.Panel OyuncuAyarlarıPaneli;
        private System.Windows.Forms.Panel OyuncuKayıtEkranıPaneli;
        private System.Windows.Forms.Button BtnOyuncuKayıtEkranı;
        private System.Windows.Forms.Panel OyuncuListeEkranıPaneli;
        private System.Windows.Forms.Button BtnOyuncuListeEkranı;
        private System.Windows.Forms.Timer OyuncuTimer;
        private System.Windows.Forms.Panel YönetmenListeEkranıPaneli;
        private System.Windows.Forms.Button BtnYonetmenListeEkranı;
        private System.Windows.Forms.Panel YönetmenKayıtPaneli;
        private System.Windows.Forms.Button BtnYonetmenKayıtEkranı;
        private System.Windows.Forms.Panel YönetmenAyarlarıPaneli;
        private System.Windows.Forms.Button BtnYonetmen;
        private System.Windows.Forms.FlowLayoutPanel YonetmenContainer;
        private System.Windows.Forms.Panel BiletSorgulamaEkraniPanel;
        private System.Windows.Forms.Button BtnBiletSorgulamaEkrani;
        private System.Windows.Forms.Panel BiletOlusturmaEkraniPanel;
        private System.Windows.Forms.Button BtnBiletOlusturmaEkrani;
        private System.Windows.Forms.Panel BiletAyarlariPanel;
        private System.Windows.Forms.Button BtnBiletAyarlari;
        private System.Windows.Forms.FlowLayoutPanel BiletContainer;
        private System.Windows.Forms.Timer BiletTimer;
        private System.Windows.Forms.Button BtnSalonAtamaEkrani;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}