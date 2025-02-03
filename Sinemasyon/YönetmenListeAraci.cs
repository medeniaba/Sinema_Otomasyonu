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
    public partial class YönetmenListeAraci : UserControl
    {
        public YönetmenListeAraci()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS01 ;Initial Catalog=SinemasyonDB;Integrated Security=True");



        private void YonetmenListeAracilbl_Click(object sender, EventArgs e)
        {
            if (YonetmenListeAracilbl.ForeColor == Color.FromName("ControlText"))
            {
                YonetmenListeAracilbl.ForeColor = Color.FromArgb(249, 164, 26);
                YonetmenListeAraciPicBox.ImageLocation = @"C:\Users\90537\Desktop\Sinemasyon V_6\proje_v5\SariButton.png";

                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Secilenler(kisi,Tur) values(@kisi,@Tur)",baglanti);

                komut.Parameters.AddWithValue("kisi",YonetmenListeAracilbl.Text);
                komut.Parameters.AddWithValue("@Tur", "Yönetmen");
                komut.ExecuteNonQuery();

                baglanti.Close();

            }
            else
            {
                YonetmenListeAracilbl.ForeColor = Color.FromName("ControlText");
                YonetmenListeAraciPicBox.ImageLocation = @"C:\Users\90537\Desktop\Sinemasyon V_6\proje_v5\KirimiziButton.png";



                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Secilenler where kisi=@kisi and Tur=@Tur", baglanti);

                komut.Parameters.AddWithValue("kisi", YonetmenListeAracilbl.Text);
                komut.Parameters.AddWithValue("@Tur", "Yönetmen");
                komut.ExecuteNonQuery();

                baglanti.Close();

            }
        }

        private void YonetmenListeAracilbl_MouseLeave(object sender, EventArgs e)
        {
            YonetmenListeAracilbl.Font = new Font(YonetmenListeAracilbl.Font.Name, 9, FontStyle.Regular);

        }

        private void YonetmenListeAracilbl_MouseMove(object sender, MouseEventArgs e)
        {
            YonetmenListeAracilbl.Font = new Font(YonetmenListeAracilbl.Font.Name, 9, FontStyle.Underline);
        }

        private void YönetmenListeAraci_Load(object sender, EventArgs e)
        {
           baglanti.Open();
            
            SqlCommand komut = new SqlCommand("select * from Secilenler where kisi=@kisi and Tur=@Tur",baglanti);
            komut.Parameters.AddWithValue("@kisi",YonetmenListeAracilbl.Text);
            komut.Parameters.AddWithValue("@Tur","Yönetmen");
            SqlDataReader oku = komut.ExecuteReader();  

            if(oku.Read()) {

                YonetmenListeAracilbl.ForeColor = Color.FromArgb(249, 164, 26);

            }
            else
            {
                YonetmenListeAracilbl.ForeColor = Color.FromName("ControlText");

            }


            baglanti.Close();
        }
        
        private void YonetmneListeAraciPicBox_Click(object sender, EventArgs e)
        {
            if (YonetmenListeAracilbl.ForeColor == Color.FromName("ControlText"))
            {
                YonetmenListeAracilbl.ForeColor = Color.FromArgb(249, 164, 26);
                YonetmenListeAraciPicBox.ImageLocation = @"C:\Users\90537\Desktop\Sinemasyon V_6\proje_v5\SariButton.png";

                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Secilenler(kisi,Tur) values(@kisi,@Tur)", baglanti);

                komut.Parameters.AddWithValue("kisi", YonetmenListeAracilbl.Text);
                komut.Parameters.AddWithValue("@Tur", "Yönetmen");
                komut.ExecuteNonQuery();

                baglanti.Close();

            }
            else
            {
                YonetmenListeAracilbl.ForeColor = Color.FromName("ControlText");
                YonetmenListeAraciPicBox.ImageLocation = @"C:\Users\90537\Desktop\Sinemasyon V_6\proje_v5\KirimiziButton.png";



                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Secilenler where kisi=@kisi and Tur=@Tur", baglanti);

                komut.Parameters.AddWithValue("kisi", YonetmenListeAracilbl.Text);
                komut.Parameters.AddWithValue("@Tur", "Yönetmen");
                komut.ExecuteNonQuery();

                baglanti.Close();

            }
        }
    }
}
