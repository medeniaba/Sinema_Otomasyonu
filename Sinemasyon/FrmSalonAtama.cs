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

namespace Sinemasyon
{
    public partial class FrmSalonAtama : Form
    {
        public FrmSalonAtama()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS01 ;Initial Catalog=SinemasyonDB;Integrated Security=True");

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSalonAtama_Load(object sender, EventArgs e)
        {
           
            filmAdiGetir();
            bugununTarihi();
            SalonAdiGetir();
        }


        void filmAdiGetir()
        {
            string sorgu = "select*from Filmler order by f_adi asc";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {


                // Bugün Vizyonda Olan Filmleri Getirme İmkanına Eriştik Bu Şekildee ( Buradaki Tarih Bilgisi Film Tablosundan Gelen Tarih Bilgisi) 

                string gelentarih = oku["f_tarih"].ToString();

                DateTime fTarih = Convert.ToDateTime(gelentarih);
                DateTime bugun = DateTime.Today;

                TimeSpan timespan = fTarih - bugun;
                // cbFilmAdi.Items.Add(oku["f_adi"].ToString());
                if (timespan.TotalDays <= 0)
                {

                    cbFilmAdi.Items.Add(oku["f_adi"].ToString());

                }


            }
            baglanti.Close();

        }



        void SalonAdiGetir()
        {
            string sorgu = "select*from Salonlar order by s_adi asc";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {


               

                    cbSalon.Items.Add(oku["s_adi"].ToString());

                


            }
            baglanti.Close();

        }


        void bugununTarihi()
        {
            nmcGun.Value = DateTime.Today.Day;
            nmcAy.Value = DateTime.Today.Month;
            nmcYil.Value = DateTime.Today.Year;
        }


        // cbDoluSaatler1 kısmından saat bilgilerini alamadık **************

        // Dolu Saatler Kısmının Saat Bilgisini Alamıyorum ... 

        private void btnOlustur_Click(object sender, EventArgs e)
        {

            if (btnOlustur.Text == "TAMAMLA")
            {
                string sorgu = "select DISTINCT k_Saat from Kontrol where k_Tarih=@tarih and k_SalonAdi=@salonadi";
               
                // Ayın önündeki 0 gelmediği için hata alıyoruz bundan kaynaklı önüne sıfır eklendi bu sorun üzerine çözüm aramak gerkeiyor.
                string tarih = nmcGun.Value+"-"+nmcAy.Value+"-"+nmcYil.Value;
                    
                baglanti.Open();
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@tarih",tarih);
                komut.Parameters.AddWithValue("@salonadi",cbSalon.Text.ToString());
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {

                    cbDoluSaatler.Items.Add(oku["k_Saat"].ToString());
                }



                baglanti.Close() ;
                SeansKontrol();

                btnOlustur.Text = "OLUŞTUR";
                btnOlustur.BackColor = Color.FromName("DarkOrchid");
            }
            else
            {
                kaydet();
                Temizle();
                btnOlustur.Text = "TAMAMLA";
                btnOlustur.BackColor = Color.FromName("DarkOrchid");
            }



        }

        private void SeansSaatler(object sender , EventArgs e)
        {

            //foreach 


            foreach(RadioButton item in panelSeans.Controls)
            {
                if (item.Checked) // İşaretlendiyse(True ise ) 
                {
                    lblSecilen.Text = item.Text.ToString();

                }


            }




        }


        void kaydet()
        {
            string sorgu = "insert into Kontrol(k_filmadi,k_Tarih,k_Saat,k_SalonAdi) values (@filmadi,@tarih,@saat,@salonadi)";
            baglanti.Open();
            SqlCommand ekle = new SqlCommand(sorgu,baglanti);

            string tarih = nmcGun.Value+"-"+nmcAy.Value+"-"+nmcYil.Value;

            ekle.Parameters.AddWithValue("@filmadi",cbFilmAdi.Text);
            ekle.Parameters.AddWithValue("@tarih", tarih);
            ekle.Parameters.AddWithValue("@saat", lblSecilen.Text);
            ekle.Parameters.AddWithValue("@salonadi", cbSalon.Text);
            ekle.ExecuteNonQuery();


            baglanti.Close();
            MessageBox.Show("SALON ATAMA İŞLEMİ GERÇEKLEŞTİRİLDİ");

        }





        private void btnTemizle_Click(object sender, EventArgs e)
        {

            Temizle();


        }

        void Temizle()
        {
            cbFilmAdi.Items.Clear();
            cbSalon.Items.Clear();
            cbDoluSaatler.Items.Clear();
            lblSecilen.Text = "";
            bugununTarihi();
            filmAdiGetir();
            SalonAdiGetir();
            panelSeans.Controls.Clear();
            btnOlustur.Text = "TAMAMLA";

        }



        void SeansKontrol()
        {
            panelSeans.Controls.Clear();


            for (int i = 10; i <= 22; i++) // Senaslar Sabah 10'da başlar akşam  10'da biter (Saat)
            {
                for (int j = 0; j <= 30; j += 30) // Seanslar buçukta veya saat başında başlar biter 

                {
                    RadioButton rnd = new RadioButton();
                    rnd.BackColor = Color.BlueViolet;

                    rnd.CheckedChanged += new EventHandler(SeansSaatler);

                    if (j == 0)
                    {

                        rnd.Text = i.ToString() + ":" + j.ToString() + "0";

                    }
                    else
                    {
                        rnd.Text = i.ToString() + ":" + j.ToString();
                    }

                    if (cbDoluSaatler.Items.Contains(rnd.Text))
                    {
                        // rnd.ForeColor = Color.Blue;
                        // rnd.BackColor = Color.Orange;

                        rnd.Visible = false;

                    }


                    panelSeans.Controls.Add(rnd);
                }



            }
        }

    }
}
