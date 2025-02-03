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
    public partial class YonetmenListesi : UserControl
    {
        public YonetmenListesi()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS01 ;Initial Catalog=SinemasyonDB;Integrated Security=True");





        private void YonetmenListesi_Load(object sender, EventArgs e)
        {


        }   
        
        
        
        // Yonetmen Listeleme Detay Butonu içerisi -----------------

        private void YonetmenResimYukleBtn_Click(object sender, EventArgs e)


        {

            baglanti.Open();
            string sorgu = "select*from Yonetmenler where y_no=@p1";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@p1", YonetmenNoLabel.Text);
            SqlDataReader oku = komut.ExecuteReader();


            if(oku.Read())
            {
                MessageBox.Show(oku["y_adi"].ToString() + " " + oku["y_soyadi"].ToString()+ "\n"+ "\n" + "BİYOGRAFİ " + "\n" + "\n" + oku["y_biyografi"].ToString() + "\n" + "\n" + "(ERKEK = 0 - KADIN = 1 ) " + "Cinsiyeti : " + oku["y_cinsiyet"].ToString() + "\n" + "\n" + "Yaşı : "+ oku["y_yas"].ToString());
            }

            baglanti.Close();


        }

        private void YonetmenListesiSilButon_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sil = "delete from Yonetmenler where y_no=@p1";
            SqlCommand komutsil = new SqlCommand(sil, baglanti);
            komutsil.Parameters.AddWithValue("@p1", YonetmenNoLabel.Text);
            komutsil.ExecuteNonQuery(); // UPDATE, INSERT ya da DELETE deyimlerini yürüterek, bir veri tabanındaki verileri değiştirmek için kullanırız.

            baglanti.Close();


                MessageBox.Show(YonetmenListeAdLabel.Text+ " Kişisine Ait Kayıt Başarılı Bir Şekilde Silinmiştir!");
            this.Hide();    // Sildikten sonra Sayfada Gizlemeye Yarar


        }
    }
}
