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
    public partial class FrmPersonelEkle : Form
    {
        public FrmPersonelEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS01 ;Initial Catalog=SinemasyonDB;Integrated Security=True");

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OyuncuKayitTamamlaButon_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            // insert - update - delete - select 
            SqlCommand kayit = new SqlCommand("insert into Personel(p_adı,p_soyad,p_kAdi,p_kSifre) values(@p1,@p2,@p3,@p4)", baglanti);
            
            kayit.Parameters.AddWithValue("@p1", PersonelAdText.Text.ToString());
            kayit.Parameters.AddWithValue("@p2", PersonelSoyAdText.Text.ToString());
            kayit.Parameters.AddWithValue("@p3", PersonelKAdiText.Text.ToString());
            kayit.Parameters.AddWithValue("@p4", PersonelKSifreText.Text.ToString());
            kayit.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Kaydı Tamamlandı");
            PersonelAdText.Text = "";
            PersonelSoyAdText.Text = "";
            PersonelKAdiText.Text = "";
            PersonelKSifreText.Text = "";
            PersonelAdText.Focus();
        }
    }
}
//5527441697
