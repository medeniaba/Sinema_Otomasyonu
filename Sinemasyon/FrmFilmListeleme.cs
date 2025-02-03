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
    public partial class FrmFilmListeleme : Form
    {
        public FrmFilmListeleme()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS01 ;Initial Catalog=SinemasyonDB;Integrated Security=True");



        private void FrmFilmListeleme_Load(object sender, EventArgs e)
        {
            FilmListesiFlowPanel.Controls.Clear();
            string sorgu = "select * from Filmler order by f_adi asc";
            baglanti.Open();

            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                FilmListesi arac = new FilmListesi();


                arac.lblFilmAdi.Text = oku["f_adi"].ToString();
                arac.pictureBox1.ImageLocation = oku["f_afis"].ToString();
                arac.lblf_no.Text = oku["f_no"].ToString();

                FilmListesiFlowPanel.Controls.Add(arac);

            }



            baglanti.Close();

           

        }

        private void FilmListesiAramaText_TextChanged(object sender, EventArgs e)
        {
            FilmListesiFlowPanel.Controls.Clear(); // Aradığımız zaman veya yeni bir şey eklediğimiz zaman önce bir temizle ardından verileri tekrardan çek!  
            baglanti.Open();
            SqlCommand ara = new SqlCommand("SELECT *FROM Filmler WHERE f_adi LIKE '%" + FilmListesiAramaText.Text + "%' collate Turkish_CI_AS order by f_adi asc", baglanti);
            SqlDataReader oku = ara.ExecuteReader();
            while (oku.Read())
            {

                FilmListesi arac = new FilmListesi();

                arac.lblFilmAdi.Text = oku["f_adi"].ToString();
                arac.pictureBox1.ImageLocation = oku["f_afis"].ToString();
                arac.lblf_no.Text = oku["f_no"].ToString();

                FilmListesiFlowPanel.Controls.Add(arac);

            }
            baglanti.Close();
        }
    }
}
