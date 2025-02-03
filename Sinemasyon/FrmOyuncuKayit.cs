using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinemasyon
{
    public partial class FrmOyuncuKayit : Form
    {
        public FrmOyuncuKayit()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string resimyolu = "";
        private void OyuncuResimYukleBtn_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Resim Seçme Ekranı";
            ofd.Filter = "PNG | *.png | JPG-JPEG | *.jpg;*.jpeg; | All Files | *.*";
            ofd.FilterIndex = 3;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //resim alma işlemini bu alanda ya da bu kısımda gerçekleştireceğiz
                OyuncuResimPicBox.Image = new Bitmap(ofd.FileName);
                resimyolu = ofd.FileName.ToString();
            }
        }

        public string cinsiyet = "0";
        private void OyuncuErkekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "0";
        }

        private void OyuncuKadinRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "1";
        }


        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS01 ;Initial Catalog=SinemasyonDB;Integrated Security=True");


        private void OyuncuKayitTamamlaButon_Click(object sender, EventArgs e)
        {
            // Yaş Hesaplama Metodumuz 

            YasHesapla();

            if (OyuncuAdText.Text != "" && OyuncuSoyAdText.Text != "" && OyuncuBiyografiTextBox.Text != "" && resimyolu != "")
            {

                string ad = OyuncuAdText.Text.ToString().ToUpper();
                string soyad = OyuncuSoyAdText.Text.ToString().ToUpper();

                baglanti.Open();

                // insert - update - delete - select 
                SqlCommand kayit = new SqlCommand("insert into Oyuncular(o_adi,o_soyadi,o_cinsiyet,o_yas,o_biyografi,o_resim) values(@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);



                kayit.Parameters.AddWithValue("@p1", ad);
                kayit.Parameters.AddWithValue("@p2", soyad);
                kayit.Parameters.AddWithValue("@p3", cinsiyet);
                kayit.Parameters.AddWithValue("@p4", bYas);
                kayit.Parameters.AddWithValue("@p5", OyuncuBiyografiTextBox.Text.ToString().ToUpper());
                kayit.Parameters.AddWithValue("@p6", resimyolu);

                kayit.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Oyuncu Kaydı Tamamlandı");

                // Arac Temizle Metodunu Çağırıyoruz  **** 

                AracTemizle();

            }
            else
            {
                MessageBox.Show("LÜTFEN TÜM ALANLARI EKSİKSİZ BİR ŞEKİLDE DOLDURUNUZ!");
            }

        }




        void AracTemizle()
        {
            OyuncuAdText.Text = "";
            OyuncuSoyAdText.Text = "";
            OyuncuBiyografiTextBox.Text = "";
            Oyuncugun.Value = 1;
            OyuncuAy.Value = 1;
            OyuncuYil.Value = 2024;
            OyuncuErkekRadioButton.Checked = true;
            OyuncuKadinRadioButton.Checked = false;
            textBox5.Text = "300";
            cinsiyet = "0";
            bYas = "000";
            OyuncuResimPicBox.ImageLocation = @"C:\Users\meden\Desktop\proje_v4\no-photos.png";
            OyuncuAdText.Focus();  // İmleci temizleme işleminden sonra ad kısmında başlatmaya olanak tanır.


        }
        
        public string bYas = "000";

        // Yas Hesapla Metodumuz *****
        void YasHesapla()
        {
            string doğum = Oyuncugun.Value.ToString() + " - " + OyuncuAy.Value.ToString() + " - " +OyuncuYil.Value.ToString();
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

        private void OyuncuBiyografiTextBox_TextChanged(object sender, EventArgs e)
        {

            int karektersayisi = OyuncuBiyografiTextBox.Text.Length;
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
