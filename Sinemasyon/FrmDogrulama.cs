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
    public partial class FrmDogrulama : Form
    {
        public FrmDogrulama()
        {
            InitializeComponent();
        }

        //connectionstring dediğimiz veritabanımızın yolunu projemize eklememiz gerekiyor ve
        //veritabanımızın yolunu programımıza söylememiz gerekiyor.

        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS01 ;Initial Catalog=SinemasyonDB;Integrated Security=True");

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void OyuncuKayitTamamlaButon_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sorgula = new SqlCommand("select * from Yonetici WHERE y_kAdi=@username AND y_kSifre=@password", baglanti);
            sorgula.Parameters.AddWithValue("@username", YoneticiKAdText.Text);
            sorgula.Parameters.AddWithValue("@password", YoneticiKSifreText.Text);
            SqlDataReader oku = sorgula.ExecuteReader();

            if (oku.Read())//okuma işlemi başarılı ise ya da girilen bilgiler veri tabanında var ve uyuşuyor ise
            {
                // MessageBox.Show("Giriş Başarılı");
                FrmPersonelEkle frm = new FrmPersonelEkle();
                frm.ShowDialog();
                this.Hide();
            }
            else

            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            YoneticiKAdText.Text = "";
            YoneticiKSifreText.Text = "";
            YoneticiKAdText.Focus();//imleci kullanıcı adı üzerine konumlandır
            baglanti.Close();



        }
    }
    }

