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


    // F7 Diyerek Formun .cs kısmına direk geçebiliyoruz .. 
    public partial class FrmBiletDetay : Form
    {
        public FrmBiletDetay()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS01 ;Initial Catalog=SinemasyonDB;Integrated Security=True");


        public string biletNo = "";
        private void FrmBiletDetay_Load(object sender, EventArgs e)
        {
            lblBiletNo.Text = biletNo;
            lblBiletNo2.Text= biletNo;  
            barkodNolustur();
            bilgiGetir();
        }

        void bilgiGetir()
        {

            string sorgu = "select*from Biletler where b_kod=@kod";
            baglanti.Open();

            SqlCommand getir = new SqlCommand(sorgu, baglanti);
            getir.Parameters.AddWithValue("@kod", biletNo);
            SqlDataReader oku = getir.ExecuteReader();
            if(oku.Read())
            {
                lblFilmAdi.Text = oku["b_filmadi"].ToString();
                lblFilmAdi2.Text = oku["b_filmadi"].ToString();
                lblTelNo.Text = oku["b_telno"].ToString();
                lblAdSoyad.Text = oku["b_adsoyad"].ToString();
                lblBiletTuru.Text = oku["b_tur"].ToString();
                lblSalonAdi.Text = oku["b_salon"].ToString();
                lblSalon2.Text = oku["b_salon"].ToString();
                lblTarih2.Text = oku["b_tarih"].ToString()+" " + oku["b_saat"].ToString();
                lblTarihSaat.Text = oku["b_tarih"].ToString() + " " + oku["b_saat"].ToString();
                lblIslemTarih.Text = oku["b_islemsaati"].ToString();
                lblSeciliKoltuk1.Text= oku["b_koltukno"].ToString() ;
                lblSeciliKoltuk2.Text = oku["b_koltukno"].ToString();

            }



            baglanti.Close();   
        }


        void barkodNolustur()
        {
            Random rastgele = new Random();
            string karakterler = "1234567898765432112345678987654321345678987654321";
            string kod = "";
            for (int i = 1; i < 11; i++)
            {

                kod += karakterler[rastgele.Next(karakterler.Length)];
            }

            lblBarkod1.Text = kod.ToString();
            lblBarkod2.Text = kod.ToString();


        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Bitmap bmp;
        private void button1_Click(object sender, EventArgs e)
        {
            // FrmBiletDetay formunun ekran görüntüsünü alma
            CaptureFormScreen();

            // PrintPreviewDialog'ı gösterme
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        private void CaptureFormScreen()
        {
            // FrmBiletDetay formunun ekran görüntüsünü alma
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            Graphics mg = Graphics.FromImage(bmp);
            Point screenPoint = this.PointToScreen(Point.Empty);
            mg.CopyFromScreen(screenPoint.X, screenPoint.Y, 0, 0, this.ClientSize);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Ekran görüntüsünü yazdırma
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
