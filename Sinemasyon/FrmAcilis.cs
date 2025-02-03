using System;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Windows.Forms;
//sql veritabanına ait kütüphaneyi ekliyoruz
using System.Data.SqlClient;

namespace Sinemasyon
{
    public partial class FrmAcilis : Form
    {
        // Windows API'lerini içeri aktarıyoruz
          [DllImport("user32.dll")]
          public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

          [DllImport("user32.dll")]
          public static extern bool ReleaseCapture();

          // Windows Mesajları
          public const int WM_NCLBUTTONDOWN = 0xA1;
          public const int HT_CAPTION = 0x2;

        //connectionstring dediğimiz veritabanımızın yolunu projemize eklememiz gerekiyor ve
        //veritabanımızın yolunu programımıza söylememiz gerekiyor.
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS01 ;Initial Catalog=SinemasyonDB;Integrated Security=True");

        public FrmAcilis()
          {
              InitializeComponent();
          }


          private void pictureBox4_Click_1(object sender, EventArgs e)
          {
              Application.Exit();
          }

          private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
          {
              if (e.Button == MouseButtons.Left && e.Clicks == 1)
              {
                  ReleaseCapture();
                  SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
              }
          }

          private void panel1_MouseDown(object sender, MouseEventArgs e)
          {
              if (e.Button == MouseButtons.Left && e.Clicks == 1)
              {
                  ReleaseCapture();
                  SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
              }
          }

          private void pictureBox5_MouseDown_1(object sender, MouseEventArgs e)
          {
              if (e.Button == MouseButtons.Left && e.Clicks == 1)
              {
                  ReleaseCapture();
                  SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
              }
          }

        
          private void Giris_Button_Click(object sender, EventArgs e)
          { 

            baglanti.Open();
            SqlCommand sorgula = new SqlCommand("select * from Personel WHERE p_kAdi=@username AND p_kSifre=@password", baglanti);
            sorgula.Parameters.AddWithValue("@username", Txt_KAdi.Text);
            sorgula.Parameters.AddWithValue("@password", Txt_Sifre.Text);
            SqlDataReader oku = sorgula.ExecuteReader();
           
            if (oku.Read())//okuma işlemi başarılı ise ya da girilen bilgiler veri tabanında var ve uyuşuyor ise
            {
                // MessageBox.Show("Giriş Başarılı");
                
                FrmAnasayfa frm = new FrmAnasayfa();
                frm.Show();
                this.Hide();
            }
            else

            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış","Hatalı Giriş",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            Txt_KAdi.Text = "";
            Txt_Sifre.Text = "";
            Txt_KAdi.Focus();//imleci kullanıcı adı üzerine konumlandır
            baglanti.Close(); 
            
            
            
        }
    }
}
