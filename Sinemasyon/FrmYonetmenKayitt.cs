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
    public partial class FrmYonetmenKayitt : Form
    {
        public FrmYonetmenKayitt()
        {
            InitializeComponent();
        }

        // ConnectionStrinng 

        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS01 ;Initial Catalog=SinemasyonDB;Integrated Security=True");



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public string resimyolu = "";
        private void YonetmenResimYukleBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Resim Seçme Ekranı";
            ofd.Filter = "PNG | *.png | JPG-JPEG | *.jpg;*.jpeg; | All Files | *.*";
            ofd.FilterIndex = 3;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //resim alma işlemini bu alanda ya da bu kısımda gerçekleştireceğiz
                YonetmenResimPicBox.Image = new Bitmap(ofd.FileName);
                 resimyolu = ofd.FileName.ToString();
            }
        }

        public string cinsiyet = "0";
        private void YoneticiErkekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "0";
        }

        private void YoneticiKadinRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "1";

        }
      

        private void YonetmenKayitTamamlaButon_Click(object sender, EventArgs e)
        {

            // Yaş Hesaplama Metodumuz 

            YasHesapla();

            if(YoneticiAdText.Text != "" && YoneticiSoyAdText.Text !="" && YonetmenBiyografiTextBox.Text != "" && resimyolu != "")
            {
                
                string ad = YoneticiAdText.Text.ToString().ToUpper();
                string soyad = YoneticiSoyAdText.Text.ToString().ToUpper();

                baglanti.Open();

                // insert - update - delete - select 
                SqlCommand kayit = new SqlCommand("insert into Yonetmenler(y_adi,y_soyadi,y_cinsiyet,y_yas,y_biyografi,y_resim) values(@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);



                kayit.Parameters.AddWithValue("@p1", ad);
                kayit.Parameters.AddWithValue("@p2", soyad);
                kayit.Parameters.AddWithValue("@p3", cinsiyet);
                kayit.Parameters.AddWithValue("@p4", bYas);
                kayit.Parameters.AddWithValue("@p5", YonetmenBiyografiTextBox.Text.ToString().ToUpper());
                kayit.Parameters.AddWithValue("@p6", resimyolu);

                kayit.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Yönetmen Kaydı Tamamlandı");

                // Arac Temizle Metodunu Çağırıyoruz  **** 

                AracTemizle();

            }
            else
            {
                MessageBox.Show("LÜTFEN TÜM ALANLARI EKSİKSİZ BİR ŞEKİLDE DOLDURUNUZ!");
            }




        }

        // Kayıttan Sonra Kayıt Formunun Değerlerini Eski Haline Getirmek İçin Yazdığımız AracTemizle Metoduumuz.
        void AracTemizle()
        {
            YoneticiAdText.Text = "";
            YoneticiSoyAdText.Text = "";
            YonetmenBiyografiTextBox.Text = "";
            Yoneticigun.Value = 1; 
            YoneticiAy.Value = 1;
            YoneticiYil.Value = 2024; 
            YoneticiErkekRadioButton.Checked = true;
            YoneticiKadinRadioButton.Checked = false;
            textBox5.Text = "300";
            cinsiyet = "0";
            bYas = "000";
            YonetmenResimPicBox.ImageLocation = @"C:\Users\meden\Desktop\proje_v4\no-photos.png";
            YoneticiAdText.Focus();  // İmleci temizleme işleminden sonra ad kısmında başlatmaya olanak tanır.


        }



        public string bYas = "000";
        
        // Yas Hesapla Metodumuz *****
        void YasHesapla()
        {
            string doğum = Yoneticigun.Value.ToString() + " - " + YoneticiAy.Value.ToString() + " - " + YoneticiYil.Value.ToString();
            DateTime bugun = DateTime.Today;
            DateTime doğumtarihi = Convert.ToDateTime(doğum);

            int yas = (bugun.Year - doğumtarihi.Year);

            /*if (yas < 0)
            {
                MessageBox.Show("Yaşınız 0 dan küçük olamaz.");
            }
            else
            {
                MessageBox.Show("Yönetmenin Yaşı : " + yas.ToString());

            }*/
            bYas = yas.ToString();

        }

        private void YonetmenBiyografiTextBox_TextChanged(object sender, EventArgs e)
        {
            int karektersayisi= YonetmenBiyografiTextBox.Text.Length;
            int geri = 300 - karektersayisi;
            textBox5.Text = geri.ToString();    

           /* if (geri <= 20) 
            {
                textBox5.ForeColor = Color.Red;
            }
           */
        }
    }
}
