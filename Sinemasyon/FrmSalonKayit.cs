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
    public partial class FrmSalonKayit : Form
    {
        public FrmSalonKayit()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS01 ;Initial Catalog=SinemasyonDB;Integrated Security=True");


        private void SalonKayıtEkleButon_Click(object sender, EventArgs e)
        {
            if (SalonAdiText.Text !="" && SalonKoltukSayisiComboBox.Text != "")
            {
                baglanti.Open();
                SqlCommand kaydet = new SqlCommand("insert into Salonlar(s_adi,s_koltuksayisi) Values(@p1,@p2)",baglanti);
                kaydet.Parameters.AddWithValue("@p1", SalonAdiText.Text.ToUpper());
                kaydet.Parameters.AddWithValue("@p2", SalonKoltukSayisiComboBox.Text);
                kaydet.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("SALON KAYDETME İŞLEMİ BAŞARILI BİR ŞEKİLDE GERÇEKLEŞTİRİLDİ!");
                SalonAdiText.Text = "";
                SalonKoltukSayisiComboBox.Text = "";
                SalonAdiText.Focus();
                ListeGetir();
            }

            else 
            {
                MessageBox.Show("Lütfen bir değer giriniz !");           
            } 
        }

     

        private void FrmSalonKayit_Load(object sender, EventArgs e)
        {
            ListeGetir();
            KoltukOlustur();
        }

        // Combobax İçindeki Değerleri Atamak İçin Kullandık --------- 
        void KoltukOlustur()
        {
            for(int i = 0; i<= 200 ; i++)
            {


                SalonKoltukSayisiComboBox.Items.Add(i);
            }


        }


        void ListeGetir()
        {


            SalonKayitflowLayoutPanel1.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from Salonlar order by s_adi asc", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                SalonListesi arac = new SalonListesi();
                arac.SalonAdiLbl.Text = oku["s_adi"].ToString();
                arac.KoltukSayisiLbl.Text = oku["s_koltuksayisi"].ToString();
                SalonKayitflowLayoutPanel1.Controls.Add(arac);


            }
            baglanti.Close();



        }


    }
}
