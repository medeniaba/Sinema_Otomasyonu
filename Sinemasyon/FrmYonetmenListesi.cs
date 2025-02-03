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
    public partial class FrmYonetmenListesi : Form
    {
        public FrmYonetmenListesi()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS01 ;Initial Catalog=SinemasyonDB;Integrated Security=True");



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmYonetmenListesi_Load(object sender, EventArgs e)
        {
            YonetmenListeFlowPanel.Controls.Clear();

            baglanti.Open();
            string sorgu = "select*from Yonetmenler"; // Burada alfabetik sıralamak için "order by y_Adi asc" kullanılabilir . 
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();  
            while(oku.Read()) 
            { 

            // Yönetmen Listesini yeni öge altındaki kullanıcı kontrol kısmından ekledik 

            YonetmenListesi arac = new YonetmenListesi();
            
                arac.YonetmenListeAdLabel.Text = oku["y_adi"].ToString() + " " + oku["y_soyadi"].ToString();
                arac.YonetmenListesiPicBox.ImageLocation = oku["y_resim"].ToString();
                arac.YonetmenNoLabel.Text = oku["y_no"].ToString();
                
             YonetmenListeFlowPanel.Controls.Add(arac);
            
            }
            
            baglanti.Close();

        }

        private void YonetmenListeFlowPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void YonetmenListesiAramaText_TextChanged(object sender, EventArgs e)
        {
            
            YonetmenListeFlowPanel.Controls.Clear();
            baglanti.Open();
            SqlCommand ara = new SqlCommand("SELECT *FROM Yonetmenler WHERE CONCAT(y_adi, ' ', y_soyadi) LIKE '%"+YonetmenListesiAramaText.Text+ "%' collate Turkish_CI_AS", baglanti);
            SqlDataReader oku = ara.ExecuteReader();
            while (oku.Read()) {

                YonetmenListesi arac = new YonetmenListesi();

                arac.YonetmenListeAdLabel.Text = oku["y_adi"].ToString() + " " + oku["y_soyadi"].ToString();
                arac.YonetmenListesiPicBox.ImageLocation = oku["y_resim"].ToString();
                arac.YonetmenNoLabel.Text = oku["y_no"].ToString();

                YonetmenListeFlowPanel.Controls.Add(arac);


            }
            baglanti.Close() ; 
        }
    }
}
