namespace Sinemasyon
{
    partial class FrmBiletOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBiletOlustur));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SinemasyonLogo = new System.Windows.Forms.Label();
            this.BİLETNO = new System.Windows.Forms.GroupBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.ADSOYAD = new System.Windows.Forms.GroupBox();
            this.TxtAdSoyad = new System.Windows.Forms.TextBox();
            this.TELEFONNO = new System.Windows.Forms.GroupBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbFilmAdi = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbTarih = new System.Windows.Forms.ComboBox();
            this.lblGun = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSeansSec = new System.Windows.Forms.Label();
            this.panelSeans = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblKoltukSayisi = new System.Windows.Forms.Label();
            this.cbSalon = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbBiletTuru = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtKoltuklar = new System.Windows.Forms.TextBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.lblGelenKoltuk = new System.Windows.Forms.Label();
            this.listeGelenKoltuk = new System.Windows.Forms.ListBox();
            this.KoltukPaneli = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblBelirlenen = new System.Windows.Forms.ListBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BİLETNO.SuspendLayout();
            this.ADSOYAD.SuspendLayout();
            this.TELEFONNO.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
            this.panel1.TabIndex = 9;
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
            this.SinemasyonLogo.Location = new System.Drawing.Point(244, 9);
            this.SinemasyonLogo.Name = "SinemasyonLogo";
            this.SinemasyonLogo.Size = new System.Drawing.Size(378, 38);
            this.SinemasyonLogo.TabIndex = 2;
            this.SinemasyonLogo.Text = "BİLET OLUŞTURMA EKRANI";
            this.SinemasyonLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BİLETNO
            // 
            this.BİLETNO.Controls.Add(this.txtBarkod);
            this.BİLETNO.Location = new System.Drawing.Point(12, 57);
            this.BİLETNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BİLETNO.Name = "BİLETNO";
            this.BİLETNO.Padding = new System.Windows.Forms.Padding(11, 2, 3, 2);
            this.BİLETNO.Size = new System.Drawing.Size(216, 60);
            this.BİLETNO.TabIndex = 10;
            this.BİLETNO.TabStop = false;
            this.BİLETNO.Text = "BİLET NO";
            // 
            // txtBarkod
            // 
            this.txtBarkod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBarkod.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkod.Location = new System.Drawing.Point(11, 35);
            this.txtBarkod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.ReadOnly = true;
            this.txtBarkod.Size = new System.Drawing.Size(202, 23);
            this.txtBarkod.TabIndex = 0;
            // 
            // ADSOYAD
            // 
            this.ADSOYAD.Controls.Add(this.TxtAdSoyad);
            this.ADSOYAD.Location = new System.Drawing.Point(12, 127);
            this.ADSOYAD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ADSOYAD.Name = "ADSOYAD";
            this.ADSOYAD.Padding = new System.Windows.Forms.Padding(11, 2, 3, 2);
            this.ADSOYAD.Size = new System.Drawing.Size(216, 60);
            this.ADSOYAD.TabIndex = 11;
            this.ADSOYAD.TabStop = false;
            this.ADSOYAD.Text = "AD SOYAD";
            // 
            // TxtAdSoyad
            // 
            this.TxtAdSoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAdSoyad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TxtAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAdSoyad.Location = new System.Drawing.Point(11, 35);
            this.TxtAdSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtAdSoyad.MaxLength = 100;
            this.TxtAdSoyad.Name = "TxtAdSoyad";
            this.TxtAdSoyad.Size = new System.Drawing.Size(202, 23);
            this.TxtAdSoyad.TabIndex = 0;
            // 
            // TELEFONNO
            // 
            this.TELEFONNO.Controls.Add(this.txtTelNo);
            this.TELEFONNO.Location = new System.Drawing.Point(12, 201);
            this.TELEFONNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TELEFONNO.Name = "TELEFONNO";
            this.TELEFONNO.Padding = new System.Windows.Forms.Padding(11, 2, 3, 2);
            this.TELEFONNO.Size = new System.Drawing.Size(216, 60);
            this.TELEFONNO.TabIndex = 12;
            this.TELEFONNO.TabStop = false;
            this.TELEFONNO.Text = "TELEFON NUMARASI";
            // 
            // txtTelNo
            // 
            this.txtTelNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelNo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelNo.Location = new System.Drawing.Point(11, 35);
            this.txtTelNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelNo.MaxLength = 10;
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(202, 23);
            this.txtTelNo.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbFilmAdi);
            this.groupBox1.Location = new System.Drawing.Point(12, 273);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(11, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(216, 60);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FİLM ADI";
            // 
            // cbFilmAdi
            // 
            this.cbFilmAdi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbFilmAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilmAdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFilmAdi.FormattingEnabled = true;
            this.cbFilmAdi.Location = new System.Drawing.Point(11, 34);
            this.cbFilmAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFilmAdi.Name = "cbFilmAdi";
            this.cbFilmAdi.Size = new System.Drawing.Size(202, 24);
            this.cbFilmAdi.TabIndex = 0;
            this.cbFilmAdi.SelectedIndexChanged += new System.EventHandler(this.cbFilmAdi_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbTarih);
            this.groupBox2.Controls.Add(this.lblGun);
            this.groupBox2.Location = new System.Drawing.Point(12, 338);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(11, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(216, 65);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TARİH";
            // 
            // cbTarih
            // 
            this.cbTarih.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbTarih.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTarih.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTarih.FormattingEnabled = true;
            this.cbTarih.Location = new System.Drawing.Point(11, 39);
            this.cbTarih.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTarih.Name = "cbTarih";
            this.cbTarih.Size = new System.Drawing.Size(202, 24);
            this.cbTarih.TabIndex = 19;
            this.cbTarih.SelectedIndexChanged += new System.EventHandler(this.cbTarih_SelectedIndexChanged);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSeansSec);
            this.groupBox3.Controls.Add(this.panelSeans);
            this.groupBox3.Location = new System.Drawing.Point(12, 411);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(11, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(216, 87);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SAAT/SEANS";
            // 
            // lblSeansSec
            // 
            this.lblSeansSec.AutoSize = true;
            this.lblSeansSec.BackColor = System.Drawing.Color.White;
            this.lblSeansSec.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeansSec.ForeColor = System.Drawing.Color.Purple;
            this.lblSeansSec.Location = new System.Drawing.Point(157, -2);
            this.lblSeansSec.Name = "lblSeansSec";
            this.lblSeansSec.Size = new System.Drawing.Size(56, 17);
            this.lblSeansSec.TabIndex = 20;
            this.lblSeansSec.Text = "lblSeans";
            this.lblSeansSec.Visible = false;
            // 
            // panelSeans
            // 
            this.panelSeans.AutoScroll = true;
            this.panelSeans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSeans.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelSeans.Location = new System.Drawing.Point(11, 17);
            this.panelSeans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSeans.Name = "panelSeans";
            this.panelSeans.Size = new System.Drawing.Size(202, 68);
            this.panelSeans.TabIndex = 20;
            this.panelSeans.WrapContents = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblKoltukSayisi);
            this.groupBox4.Controls.Add(this.cbSalon);
            this.groupBox4.Location = new System.Drawing.Point(12, 505);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(11, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(216, 60);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SALON ADI";
            // 
            // lblKoltukSayisi
            // 
            this.lblKoltukSayisi.AutoSize = true;
            this.lblKoltukSayisi.BackColor = System.Drawing.Color.White;
            this.lblKoltukSayisi.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKoltukSayisi.ForeColor = System.Drawing.Color.Purple;
            this.lblKoltukSayisi.Location = new System.Drawing.Point(125, 0);
            this.lblKoltukSayisi.Name = "lblKoltukSayisi";
            this.lblKoltukSayisi.Size = new System.Drawing.Size(90, 17);
            this.lblKoltukSayisi.TabIndex = 21;
            this.lblKoltukSayisi.Text = "lblKoltukSayisi";
            this.lblKoltukSayisi.Visible = false;
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
            this.cbSalon.SelectedIndexChanged += new System.EventHandler(this.cbSalon_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbBiletTuru);
            this.groupBox5.Location = new System.Drawing.Point(12, 576);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(11, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(216, 60);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "BİLET TÜRÜ";
            // 
            // cbBiletTuru
            // 
            this.cbBiletTuru.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbBiletTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBiletTuru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBiletTuru.FormattingEnabled = true;
            this.cbBiletTuru.Items.AddRange(new object[] {
            "YETİŞKİN",
            "ÖĞRENCİ"});
            this.cbBiletTuru.Location = new System.Drawing.Point(11, 34);
            this.cbBiletTuru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBiletTuru.Name = "cbBiletTuru";
            this.cbBiletTuru.Size = new System.Drawing.Size(202, 24);
            this.cbBiletTuru.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtKoltuklar);
            this.groupBox6.Location = new System.Drawing.Point(12, 639);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(11, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(216, 60);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "SEÇİLEN KOLTUK(LAR)";
            // 
            // txtKoltuklar
            // 
            this.txtKoltuklar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKoltuklar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtKoltuklar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKoltuklar.Location = new System.Drawing.Point(11, 35);
            this.txtKoltuklar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKoltuklar.Name = "txtKoltuklar";
            this.txtKoltuklar.ReadOnly = true;
            this.txtKoltuklar.Size = new System.Drawing.Size(202, 23);
            this.txtKoltuklar.TabIndex = 0;
            // 
            // btnOlustur
            // 
            this.btnOlustur.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOlustur.Location = new System.Drawing.Point(12, 706);
            this.btnOlustur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(139, 36);
            this.btnOlustur.TabIndex = 19;
            this.btnOlustur.Text = "OLUŞTUR";
            this.btnOlustur.UseVisualStyleBackColor = false;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // lblGelenKoltuk
            // 
            this.lblGelenKoltuk.AutoSize = true;
            this.lblGelenKoltuk.BackColor = System.Drawing.Color.White;
            this.lblGelenKoltuk.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGelenKoltuk.ForeColor = System.Drawing.Color.Purple;
            this.lblGelenKoltuk.Location = new System.Drawing.Point(380, 736);
            this.lblGelenKoltuk.Name = "lblGelenKoltuk";
            this.lblGelenKoltuk.Size = new System.Drawing.Size(91, 17);
            this.lblGelenKoltuk.TabIndex = 22;
            this.lblGelenKoltuk.Text = "lblGelenKoltuk";
            this.lblGelenKoltuk.Visible = false;
            // 
            // listeGelenKoltuk
            // 
            this.listeGelenKoltuk.FormattingEnabled = true;
            this.listeGelenKoltuk.ItemHeight = 16;
            this.listeGelenKoltuk.Location = new System.Drawing.Point(235, 647);
            this.listeGelenKoltuk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listeGelenKoltuk.Name = "listeGelenKoltuk";
            this.listeGelenKoltuk.Size = new System.Drawing.Size(120, 84);
            this.listeGelenKoltuk.TabIndex = 23;
            this.listeGelenKoltuk.Visible = false;
            // 
            // KoltukPaneli
            // 
            this.KoltukPaneli.AutoScroll = true;
            this.KoltukPaneli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.KoltukPaneli.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.KoltukPaneli.Location = new System.Drawing.Point(271, 66);
            this.KoltukPaneli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KoltukPaneli.Name = "KoltukPaneli";
            this.KoltukPaneli.Size = new System.Drawing.Size(632, 548);
            this.KoltukPaneli.TabIndex = 24;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Sinemasyon.Properties.Resources.mavikoltuk;
            this.pictureBox2.Location = new System.Drawing.Point(415, 640);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(400, 699);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "BOŞ KOLTUK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(523, 698);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "DOLU KOLTUK";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(544, 639);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Olive;
            this.label3.Location = new System.Drawing.Point(644, 698);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "SEÇİLEN KOLTUK";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Sinemasyon.Properties.Resources.sarikoltuk;
            this.pictureBox4.Location = new System.Drawing.Point(665, 639);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(56, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // lblBelirlenen
            // 
            this.lblBelirlenen.FormattingEnabled = true;
            this.lblBelirlenen.ItemHeight = 16;
            this.lblBelirlenen.Location = new System.Drawing.Point(801, 661);
            this.lblBelirlenen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblBelirlenen.Name = "lblBelirlenen";
            this.lblBelirlenen.Size = new System.Drawing.Size(120, 84);
            this.lblBelirlenen.TabIndex = 31;
            this.lblBelirlenen.Visible = false;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(155, 706);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(139, 36);
            this.btnTemizle.TabIndex = 32;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumPurple;
            this.button1.Location = new System.Drawing.Point(527, 727);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 33;
            this.button1.Text = "YAZDIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FrmBiletOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 757);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.lblBelirlenen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.KoltukPaneli);
            this.Controls.Add(this.listeGelenKoltuk);
            this.Controls.Add(this.lblGelenKoltuk);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TELEFONNO);
            this.Controls.Add(this.ADSOYAD);
            this.Controls.Add(this.BİLETNO);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(550, 130);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmBiletOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmBiletOlustur";
            this.Load += new System.EventHandler(this.FrmBiletOlustur_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BİLETNO.ResumeLayout(false);
            this.BİLETNO.PerformLayout();
            this.ADSOYAD.ResumeLayout(false);
            this.ADSOYAD.PerformLayout();
            this.TELEFONNO.ResumeLayout(false);
            this.TELEFONNO.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SinemasyonLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox BİLETNO;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.GroupBox ADSOYAD;
        private System.Windows.Forms.TextBox TxtAdSoyad;
        private System.Windows.Forms.GroupBox TELEFONNO;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbFilmAdi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblGun;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbSalon;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbBiletTuru;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtKoltuklar;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.ComboBox cbTarih;
        private System.Windows.Forms.FlowLayoutPanel panelSeans;
        private System.Windows.Forms.Label lblSeansSec;
        private System.Windows.Forms.Label lblKoltukSayisi;
        private System.Windows.Forms.Label lblGelenKoltuk;
        private System.Windows.Forms.ListBox listeGelenKoltuk;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.FlowLayoutPanel KoltukPaneli;
        private System.Windows.Forms.ListBox lblBelirlenen;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}