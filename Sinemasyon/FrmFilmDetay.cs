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
    public partial class FrmFilmDetay : Form
    {
        public FrmFilmDetay()
        {
            InitializeComponent();
        }

        public string fno = "";


        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS01 ;Initial Catalog=SinemasyonDB;Integrated Security=True");



        private void FrmFilmDetay_Load(object sender, EventArgs e)
        {

            string sorgu = "select*from Filmler where f_no=@p1";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu,baglanti);
            komut.Parameters.AddWithValue("@p1",fno);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                lblFilmAdi.Text = oku["f_adi"].ToString();
                pictureBox1.ImageLocation = oku["f_afis"].ToString();
                lbltur.Text = oku["f_turu"].ToString();
                lblbicim.Text = oku["f_bicimi"].ToString();
                lblYonetmen.Text = oku["f_yonetmen"].ToString();
                lblOyuncu.Text = oku["f_oyuncu"].ToString();
                lblOzellik.Text = oku["f_ozellikleri"].ToString();
                lblPuan.Text = oku["f_puan"].ToString() ;
                lblVizyon.Text = oku["f_tarih"].ToString();
                lblDurum.Text = oku["f_durum"].ToString();
                lblDetay.Text = oku["f_detay"].ToString();
            }


            baglanti.Close();

            if (lblDurum.Text == "0")
            {
                lblDurum.Text = "FİLM VİZYONDA DEĞİL";
            }
            else
            {
                lblDurum.Text = "FİLM VİZYONA GİRDİ";
            }



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
