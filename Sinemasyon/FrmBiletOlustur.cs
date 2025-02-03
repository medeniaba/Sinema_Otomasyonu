using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;


namespace Sinemasyon
{
    public partial class FrmBiletOlustur : Form
    {
        public FrmBiletOlustur()
        {
            InitializeComponent();
            
            
        }



        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS01 ;Initial Catalog=SinemasyonDB;Integrated Security=True");


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
             
        }

       
        private void FrmBiletOlustur_Load(object sender, EventArgs e)
        {
            filmAdiGetir();
            biletNolustur();

            txtBarkod.SelectionStart = 0; // Forum Açıldıgında txtBarkod içerisinde metin seçili olarak geliyordu bu şekilde düzelttik


        }

        // Film İsimlerini Getirmek İçin Kullandığımız Metodumuz 

        void filmAdiGetir()
        {
            string sorgu = "select*from Filmler order by f_adi asc";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {


                // Bugün Vizyonda Olan Filmleri Getirme İmkanına Eriştik Bu Şekildee ( Buradaki Tarih Bilgisi Film Tablosundan Gelen Tarih Bilgisi) 

                string gelentarih = oku["f_tarih"].ToString();
                
                DateTime fTarih = Convert.ToDateTime(gelentarih);
                DateTime bugun = DateTime.Today;

                TimeSpan timespan = fTarih - bugun;

                if(timespan.TotalDays<=0) {
                
                cbFilmAdi.Items.Add(oku["f_adi"].ToString());
                
                }

                
            }
            baglanti.Close();

        }


        // Bilet Barkodu için random kod oluşturacağımız metodumuz 
        void biletNolustur()
        {
            Random rastgele = new Random();
            string karakterler = "1234567898765432112345678987654321345678987654321";
            string kod = "";
            for(int i = 1; i<11; i++)
            {

                kod += karakterler[rastgele.Next(karakterler.Length)];
            }

            txtBarkod.Text = kod.ToString();
            


        }

        // Seçilen Filmin Tarih Kısmını Getirmek Adına Kullandık 
        private void cbFilmAdi_SelectedIndexChanged(object sender, EventArgs e)
        {

            //distinct DISTINCT -->> Veritabanımızda kayıtlı olan aynı türden veriler arasında sadece 1 tanesini getirir.
            // Dikkat -- Diger verilerin hiçbirini silmez.Sadece 1 tanesini gösterir

            cbTarih.Items.Clear();
            string sorgu = "Select distinct k_Tarih from Kontrol where k_filmadi=@filmadi";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@filmadi",cbFilmAdi.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cbTarih.Items.Add(oku["k_Tarih"].ToString());

            }

            baglanti.Close();
        }


        void DOLDUR()
        {
            KoltukPaneli.Controls.Clear();

            int sayi = Convert.ToInt16(lblKoltukSayisi.Text);

            for (int i = 1; i <= sayi; i++)
            {
                Button btn = new Button();

                //. . . . 

                if (i <= 8)
                {
                    btn.Text = "A" + i.ToString();
                    btn.Name = "A" + i.ToString();
                }
                else if (i <= 16)
                {
                    btn.Text = "B" + (i-8).ToString();
                    btn.Name = "B" + (i-8).ToString();

                }
                else if (i <= 24)
                {
                    btn.Text = "C" + (i-16).ToString();
                    btn.Name = "C" + (i-16).ToString();
                }

                else if (i <= 32)
                {
                    btn.Text = "D" + (i-24).ToString();
                    btn.Name = "D" + (i-24).ToString();
                }
                else if (i <= 40)
                {
                    btn.Text = "E" + (i-32).ToString();
                    btn.Name = "E" + (i-32).ToString();
                }
                else if (i <= 48)
                {
                    btn.Text = "F" + (i-40).ToString();
                    btn.Name = "F" + (i-40).ToString();

                }
                else if (i <= 56)
                {
                    btn.Text = "G" + (i-48).ToString();
                    btn.Name = "G" + (i-48).ToString();
                }
                else if (i <= 64)
                {
                    btn.Text = "H" + (i-56).ToString();
                    btn.Name = "H" + (i-56).ToString();
                }
                else if (i <= 72)
                {
                    btn.Text = "I" + (i-64).ToString();
                    btn.Name = "I" + (i-64).ToString();
                }




                // ..... 


                // btn.Text = i.ToString(); Bu 2 satırı yorum satırı olmaktan çıkartırsak harflendirmeyi 
                //btn.Name = i.ToString();   ortadan kaldırır direk sayısal değerlerle sıralamış oluruz 
                btn.Width = 50;
                btn.Height = 50;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;



                btn.ForeColor = Color.Yellow;

                btn.Click += Btn_Click;


                if (listeGelenKoltuk.Items.Contains(btn.Text))
                {

                    
                    btn.Image = (System.Drawing.Image)(Properties.Resources.KırmızıKoltukk);
           
                   // btn.ImageAlign = ContentAlignment.MiddleLeft;                  
                    //  btn.BackColor = Color.Red;
                    btn.ForeColor = Color.Black;
                    btn.TextAlign = ContentAlignment.MiddleRight;
                    // btn.BackColor = Color.Red; // Koltuk Seçiliyse 
                }
                else
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.MaviKoltukk);
                  
                    // btn.ImageAlign = ContentAlignment.MiddleLeft;

                      btn.ForeColor = Color.Yellow;
                      btn.TextAlign = ContentAlignment.MiddleRight;
                    // btn.BackColor = Color.Purple; // Koltuk Seçili Değilse 
                }



                // özellikleri belirleyeceğiz.

                KoltukPaneli.Controls.Add(btn);


            }


        }

        // Seçilen Koltukları belirlenen listbox'i aracılıgıyla txtKoltuklar Kısmına yazdırma metodumuz 
        void Sectiklerimiz()
        {
            txtKoltuklar.Text = "";

            foreach (string item in lblBelirlenen.Items)
            {
                txtKoltuklar.Text += "," + item;
            }
            if (txtKoltuklar.Text.Length > 1)
            {
                txtKoltuklar.Text = txtKoltuklar.Text.Substring(1);
            }

        }



        private void Btn_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;

            if (btn.ForeColor == Color.Black)// Arkaplan Kırmızı
            {
                
                MessageBox.Show("BU KOLTUK DOLUDUR");

            }
            else
            {
                if (btn.ForeColor == Color.Yellow)
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.SarıKoltukk);
                    
                 //   btn.ImageAlign = ContentAlignment.MiddleLeft;

                    btn.ForeColor = Color.Blue;
                    lblBelirlenen.Items.Add(btn.Text);
                    Sectiklerimiz();
                }
                else
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.MaviKoltukk);
                  //  btn.ImageAlign = ContentAlignment.MiddleLeft;

                    btn.ForeColor = Color.Yellow;
                    lblBelirlenen.Items.Remove(btn.Text);
                    Sectiklerimiz();
                }

            }

        }


        void BiletNoSorgula()
        {
            string sorgu = "select*from Biletler where b_kod=@no";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu,baglanti);
            komut.Parameters.AddWithValue("@no",txtBarkod.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();

            if(!oku.Read())
            {
                KaydetmeMetodu();
            }

            else
            {
                biletNolustur();
                baglanti.Close();
                BiletNoSorgula();
            }


            baglanti.Close();

        }



        void KaydetmeMetodu()
        {
            string sorgu = "insert into Biletler (b_kod,b_adsoyad,b_telno,b_koltukno,b_filmadi,b_tarih,b_saat,b_salon,b_tur,b_islemsaati) Values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)";

            baglanti.Close();
            baglanti.Open();
            SqlCommand kayit = new SqlCommand(sorgu, baglanti);
            kayit.Parameters.AddWithValue("p1", txtBarkod.Text.ToString());
            kayit.Parameters.AddWithValue("p2", TxtAdSoyad.Text.ToUpper().ToString());
            kayit.Parameters.AddWithValue("p3", txtTelNo.Text.ToString());
            kayit.Parameters.AddWithValue("p4", txtKoltuklar.Text.ToString());
            kayit.Parameters.AddWithValue("p5", cbFilmAdi.Text.ToString());
            kayit.Parameters.AddWithValue("p6", cbTarih.Text.ToString());
            kayit.Parameters.AddWithValue("p7", lblSeansSec.Text.ToString());
            kayit.Parameters.AddWithValue("p8", cbSalon.Text.ToString());
            kayit.Parameters.AddWithValue("p9", cbBiletTuru.Text.ToString());
            kayit.Parameters.AddWithValue("p10", DateTime.Now.ToString());
            kayit.ExecuteNonQuery();

            baglanti.Close();


            // Update Güncelleme Kısmımız 

            string sorgu2 = "UPDATE Kontrol set k_Koltuklar=@numara where k_filmadi=@filmadi and k_Tarih=@tarih and k_Saat=@saat and k_SalonAdi=@salonadi";

            baglanti.Open();
            SqlCommand guncelle = new SqlCommand(sorgu2,baglanti);
            
            // lblGelenKoltuk başında gelen virgülden kurtulmak adına yaptığımız bir şey .

            if (lblGelenKoltuk.Text.ToString() == "")
            {
                guncelle.Parameters.AddWithValue("@numara", txtKoltuklar.Text.ToString());
            }

            else
            {
                guncelle.Parameters.AddWithValue("@numara", lblGelenKoltuk.Text.ToString() + "," + txtKoltuklar.Text.ToString());
            }


         
            guncelle.Parameters.AddWithValue("@filmadi", cbFilmAdi.Text.ToString());
            guncelle.Parameters.AddWithValue("@tarih", cbTarih.Text.ToString());
            guncelle.Parameters.AddWithValue("@saat", lblSeansSec.Text.ToString());
            guncelle.Parameters.AddWithValue("@salonadi", cbSalon.Text.ToString());
            guncelle.ExecuteNonQuery();

            baglanti.Close();



            
            MessageBox.Show("BİLET SATIŞI BAŞARILI BİR ŞEKİLDE GERÇEKLEŞTİRİLDİ");
           
            salonDurumGeldi();
            lblGelenKoltuk.Text = "";
            listeGelenKoltuk.Items.Clear();
            lblBelirlenen.Items.Clear();
            txtKoltuklar.Text = "";

        }



        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (TxtAdSoyad.Text != "" && txtBarkod.Text != "" && txtKoltuklar.Text != "" && txtTelNo.Text != "" && cbBiletTuru.Text != "" && cbFilmAdi.Text !="" && cbSalon.Text != "" && cbTarih.Text != "")
            {
                BiletNoSorgula(); // Sorgulama sonucunda var olan numara veritabanında kayıtlı değilse kayıt ekleme işlemi gerçekleştirilecektir. Bu metodun içerisinde işlemler yapılacaktır.
            }
            else
            {
                MessageBox.Show("BOŞ");
            }
            //BU KISIM BİLET YAZDIRILACAĞI İÇİN ŞİMDİLİK KOMUT SATIRINA DÖNÜŞTÜRÜLDÜ

            /*baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from Biletler where b_kod=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtBarkod.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                FrmBiletDetay frm = new FrmBiletDetay();
                frm.biletNo = txtBarkod.Text.ToString();
                txtBarkod.Text = "";
                frm.ShowDialog();
            }
            baglanti.Close();
            */
            

        }

        private void cbTarih_SelectedIndexChanged(object sender, EventArgs e)
        {

            panelSeans.Controls.Clear();

            string saatler = "";


            string sorgu = "Select distinct k_Saat from Kontrol where k_filmadi=@filmadi and k_Tarih=@Tarih";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@filmadi", cbFilmAdi.Text.ToString());
            komut.Parameters.AddWithValue("@Tarih", cbTarih.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {

                saatler = oku["k_Saat"].ToString();

                //cbSalon.Items.Add(oku["k_Saat"].ToString());

                RadioButton rnd = new RadioButton();
                rnd.Text = saatler;
                rnd.ForeColor = Color.Purple;
                rnd.FlatStyle = FlatStyle.Flat;
                // rnd.Width = 100;

                rnd.CheckedChanged += new EventHandler(SeansSaatler);
                panelSeans.Controls.Add(rnd);


            }
            baglanti.Close();
        }


        private void SeansSaatler(object sender, EventArgs e)
        {
            // Foreach döngümüzü kullandık 

            foreach (RadioButton item in panelSeans.Controls)
            {

                if (item.Checked) // Yani Seçili ise 
                {

                    lblSeansSec.Text = item.Text;
                    cbSalon.Items.Clear();

                    string sorgu = "Select distinct k_SalonAdi from Kontrol where k_filmadi=@filmadi and k_Tarih=@Tarih and k_Saat=@Saat";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@filmadi", cbFilmAdi.Text.ToString());
                    komut.Parameters.AddWithValue("@Tarih", cbTarih.Text.ToString());
                    komut.Parameters.AddWithValue("@Saat", lblSeansSec.Text.ToString());
                    SqlDataReader oku = komut.ExecuteReader();

                    while (oku.Read())
                    {
                        cbSalon.Items.Add(oku["k_SalonAdi"].ToString());


                    }
                    baglanti.Close();

                }

            }

        }

        private void cbSalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            salonDurumGeldi();
        }


        void salonDurumGeldi()
        {
            string sorgu = "Select * from Salonlar where s_adi=@salonadi";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@salonadi", cbSalon.Text.ToString());

            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                lblKoltukSayisi.Text = (oku["s_koltuksayisi"].ToString());


            }
            baglanti.Close();
            koltukGetir();
            DOLDUR();


        }


        void koltukGetir()
        {
            lblGelenKoltuk.Text = "";
            string sorgu = "Select * from Kontrol where k_filmadi=@filmadi and k_Tarih=@Tarih and k_Saat=@Saat and k_SalonAdi=@salonadi";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@filmadi", cbFilmAdi.Text.ToString());
            komut.Parameters.AddWithValue("@Tarih", cbTarih.Text.ToString());
            komut.Parameters.AddWithValue("@Saat", lblSeansSec.Text.ToString());
            komut.Parameters.AddWithValue("@salonadi", cbSalon.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {

                lblGelenKoltuk.Text += " ," + oku["k_Koltuklar"].ToString();
                if (lblGelenKoltuk.Text.Length > 2)
                {
                    lblGelenKoltuk.Text = lblGelenKoltuk.Text.Substring(2);

                }

                else
                {
                    lblGelenKoltuk.Text = "";
                }

            }
            baglanti.Close();
            koltukAyirma();

        }



        void koltukAyirma()
        {
            listeGelenKoltuk.Items.Clear();

            string no = "";
            string[] sec;
            no = lblGelenKoltuk.Text.ToString();
            sec = no.Split(','); // hangi karakteri belirttiysek o karakterde ayırma işlemi yapmaya yarayan komut.

            //Foreach 

            foreach (string bulunan in sec)
            {
                listeGelenKoltuk.Items.Add(bulunan);
            }


        }


        // Form Temizleme İşlemlerini Burada Yaptık 
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdSoyad.Text = "";
            txtTelNo.Text = "";
            txtKoltuklar.Text = "";
            cbBiletTuru.Text = "";
            cbSalon.Text = "";
            cbTarih.Text = "";
            txtBarkod.Text = "";
            lblGelenKoltuk.Text = "";
            lblKoltukSayisi.Text = "";
            lblSeansSec.Text = "";
            cbSalon.Items.Clear();
            cbTarih.Items.Clear();
            cbBiletTuru.Items.Clear();
            cbBiletTuru.Items.Add("YETİŞKİN");
            cbBiletTuru.Items.Add("ÖĞRENCİ");
            biletNolustur();
            panelSeans.Controls.Clear();
            KoltukPaneli.Controls.Clear();
            lblBelirlenen.Items.Clear();
            cbFilmAdi.Items.Clear();
            listeGelenKoltuk.Items.Clear();
            filmAdiGetir();
            TxtAdSoyad.Focus();

        }


        Bitmap bmp;
        private void button1_Click(object sender, EventArgs e)
        {
            // FrmBiletDetay formunun ekran görüntüsünü alma
            CaptureFormScreen();

            // PrintPreviewDialog'ı gösterme
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }


        private void CaptureFormScreen()
        {
            // FrmBiletDetay formunun ekran görüntüsünü alma
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            Graphics mg = Graphics.FromImage(bmp);
            Point screenPoint = this.PointToScreen(Point.Empty);
            mg.CopyFromScreen(screenPoint.X, screenPoint.Y, 0, 0, this.ClientSize);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Ekran görüntüsünü yazdırma
            e.Graphics.DrawImage(bmp, 0, 0);
        }


    }
}
