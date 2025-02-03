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
    public partial class FrmOyuncuListesi : Form
    {
        public FrmOyuncuListesi()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS01 ;Initial Catalog=SinemasyonDB;Integrated Security=True");


        private void FrmOyuncuListesi_Load(object sender, EventArgs e)
        {

            OyuncuListeFlowPanel.Controls.Clear();

            baglanti.Open();
            string sorgu = "select*from Oyuncular"; // Burada alfabetik sıralamak için "order by y_Adi asc" kullanılabilir . 
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                // Oyuncu Listesini yeni öge altındaki kullanıcı kontrol kısmından ekledik 

                OyuncuListesi arac = new OyuncuListesi();

                arac.OyuncuListeAdLabel.Text = oku["o_adi"].ToString() + " " + oku["o_soyadi"].ToString();
                arac.OyuncuListesiPicBox.ImageLocation = oku["o_resim"].ToString();
                arac.OyuncuNoLabel.Text = oku["o_no"].ToString();

                OyuncuListeFlowPanel.Controls.Add(arac);

            }

            baglanti.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void OyuncuListesiAramaText_TextChanged(object sender, EventArgs e)
        {

            OyuncuListeFlowPanel.Controls.Clear(); // Aradığımız zaman veya yeni bir şey eklediğimiz zaman önce bir temizle ardından verileri tekrardan çek!  
            baglanti.Open();
            SqlCommand ara = new SqlCommand("SELECT *FROM Oyuncular WHERE CONCAT(o_adi, ' ', o_soyadi) LIKE '%" + OyuncuListesiAramaText.Text + "%' collate Turkish_CI_AS", baglanti);
            SqlDataReader oku = ara.ExecuteReader();
            while (oku.Read())
            {

                OyuncuListesi arac = new OyuncuListesi();

                arac.OyuncuListeAdLabel.Text = oku["o_adi"].ToString() + " " + oku["o_soyadi"].ToString();
                arac.OyuncuListesiPicBox.ImageLocation = oku["o_resim"].ToString();
                arac.OyuncuNoLabel.Text = oku["o_no"].ToString();

                OyuncuListeFlowPanel.Controls.Add(arac);


            }
            baglanti.Close();
        }
    }
}
