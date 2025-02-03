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
    public partial class OyuncuListeAraci : UserControl
    {
        public OyuncuListeAraci()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS01 ;Initial Catalog=SinemasyonDB;Integrated Security=True");


        // Lbl Üstüne Tıklanıldığında Renk Değişimini sağlar .
        private void OyuncListeAracilbl_Click(object sender, EventArgs e)
        {
            if (OyuncListeAracilbl.ForeColor == Color.FromName("ControlText"))
            {
                OyuncListeAracilbl.ForeColor = Color.FromArgb(249, 164, 26);
                OyuncuListeAraciPicBox.ImageLocation = @"C:\Users\90537\Desktop\Sinemasyon V_6\proje_v5\SariButton.png";

                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Secilenler(kisi,Tur) values(@kisi,@Tur)", baglanti);

                komut.Parameters.AddWithValue("kisi", OyuncListeAracilbl.Text);
                komut.Parameters.AddWithValue("@Tur", "Oyuncu");
                komut.ExecuteNonQuery();

                baglanti.Close();


            }
            else
            {
                OyuncListeAracilbl.ForeColor = Color.FromName("ControlText");
                OyuncuListeAraciPicBox.ImageLocation = @"C:\Users\90537\Desktop\Sinemasyon V_6\proje_v5\KirimiziButton.png";


                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Secilenler where kisi=@kisi and Tur=@Tur", baglanti);

                komut.Parameters.AddWithValue("kisi", OyuncListeAracilbl.Text);
                komut.Parameters.AddWithValue("@Tur", "Oyuncu");
                komut.ExecuteNonQuery();

                baglanti.Close();

            }
        }



        // Arama Kısmında Seçimlerin Kalıcı Olmasını Sağlar
        
        private void OyuncListeAracilbl_MouseLeave(object sender, EventArgs e)
        {
            OyuncListeAracilbl.Font = new Font(OyuncListeAracilbl.Font.Name, 9, FontStyle.Regular); 
        }

        private void OyuncListeAracilbl_MouseMove(object sender, MouseEventArgs e)
        {

            OyuncListeAracilbl.Font = new Font(OyuncListeAracilbl.Font.Name, 9, FontStyle.Underline);
        }

        private void OyuncuListeAraci_Load(object sender, EventArgs e)
        {
            
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select * from Secilenler where kisi=@kisi and Tur=@Tur", baglanti);
            komut.Parameters.AddWithValue("@kisi", OyuncListeAracilbl.Text);
            komut.Parameters.AddWithValue("@Tur", "Oyuncu");
            SqlDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {

                 OyuncListeAracilbl.ForeColor = Color.FromArgb(249, 164, 26);

            }
            else
            {
                OyuncListeAracilbl.ForeColor = Color.FromName("ControlText");

            }


            baglanti.Close();


        }

        private void OyuncuListeAraciPicBox_Click(object sender, EventArgs e)
        {
            if (OyuncListeAracilbl.ForeColor == Color.FromName("ControlText"))
            {
                OyuncListeAracilbl.ForeColor = Color.FromArgb(249, 164, 26);
                OyuncuListeAraciPicBox.ImageLocation = @"C:\Users\90537\Desktop\Sinemasyon V_6\proje_v5\SariButton.png";

                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Secilenler(kisi,Tur) values(@kisi,@Tur)", baglanti);

                komut.Parameters.AddWithValue("kisi", OyuncListeAracilbl.Text);
                komut.Parameters.AddWithValue("@Tur", "Oyuncu");
                komut.ExecuteNonQuery();

                baglanti.Close();


            }
            else
            {
                OyuncListeAracilbl.ForeColor = Color.FromName("ControlText");
                OyuncuListeAraciPicBox.ImageLocation = @"C:\Users\90537\Desktop\Sinemasyon V_6\proje_v5\KirimiziButton.png";


                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Secilenler where kisi=@kisi and Tur=@Tur", baglanti);

                komut.Parameters.AddWithValue("kisi", OyuncListeAracilbl.Text);
                komut.Parameters.AddWithValue("@Tur", "Oyuncu");
                komut.ExecuteNonQuery();

                baglanti.Close();

            }
        }
    }
}
