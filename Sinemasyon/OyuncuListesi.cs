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
    public partial class OyuncuListesi : UserControl
    {
        public OyuncuListesi()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS01 ;Initial Catalog=SinemasyonDB;Integrated Security=True");

        private void OyuncuListesiDetayButon_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            string sorgu = "select*from Oyuncular where o_no=@p1";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@p1", OyuncuNoLabel.Text);
            SqlDataReader oku = komut.ExecuteReader();


            if (oku.Read())
            {
                MessageBox.Show(oku["o_adi"].ToString() + " " + oku["o_soyadi"].ToString() + "\n" + "\n" + "BİYOGRAFİ " + "\n" + "\n" + oku["o_biyografi"].ToString() + "\n" + "\n" + "(ERKEK = 0 - KADIN = 1 ) " + "Cinsiyeti : " + oku["o_cinsiyet"].ToString() + "\n" + "\n" + "Yaşı : " + oku["o_yas"].ToString());
            }

            baglanti.Close();

        }

        private void OyuncuListesiSilButon_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            string sil = "delete from Oyuncular where o_no=@p1";
            SqlCommand komutsil = new SqlCommand(sil, baglanti);
            komutsil.Parameters.AddWithValue("@p1", OyuncuNoLabel.Text);
            komutsil.ExecuteNonQuery(); // UPDATE, INSERT ya da DELETE deyimlerini yürüterek, bir veri tabanındaki verileri değiştirmek için kullanırız.

            baglanti.Close();


            MessageBox.Show(OyuncuListeAdLabel.Text + " Kişisine Ait Kayıt Başarılı Bir Şekilde Silinmiştir!");
            this.Hide();    // Sildikten sonra Sayfada Gizlemeye Yarar

        }


    }
}
