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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sinemasyon
{
    public partial class FrmFilmEkle : Form
    {



        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS01 ;Initial Catalog=SinemasyonDB;Integrated Security=True");



        public FrmFilmEkle()
        {
            InitializeComponent();
        }
        String resimYolu = "";
        private void FilmResimyuklebttn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESİM SEÇME EKRANI";
            ofd.Filter = "PNG | *.png | JPG-JPEG | *.jpg;*.jpeg; | All Files | *.*";
            ofd.FilterIndex = 3;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //resim alma işlemini bu alanda ya da bu kısımda gerçekleştireceğiz
                pictureBox1.Image = new Bitmap(ofd.FileName);
                resimYolu = ofd.FileName.ToString();
            }
        }





        private void lblAksiyon_Click(object sender, EventArgs e)
        {
            if (lblAksiyon.ForeColor == Color.FromName("ControlText"))
            {
                lblAksiyon.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblAksiyon.ForeColor = Color.FromName("ControlText");
            }
        }

        private void lblKorku_Click(object sender, EventArgs e)
        {
            if (lblKorku.ForeColor == Color.FromName("ControlText"))
            {
                lblKorku.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblKorku.ForeColor = Color.FromName("ControlText");
            }
        }

        private void lblGerilim_Click(object sender, EventArgs e)
        {
            if (lblGerilim.ForeColor == Color.FromName("ControlText"))
            {
                lblGerilim.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblGerilim.ForeColor = Color.FromName("ControlText");
            }
        }

        private void lblMacera_Click(object sender, EventArgs e)
        {
            if (lblMacera.ForeColor == Color.FromName("ControlText"))
            {
                lblMacera.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblMacera.ForeColor = Color.FromName("ControlText");
            }
        }

        private void lblDram_Click(object sender, EventArgs e)
        {
            if (lblDram.ForeColor == Color.FromName("ControlText"))
            {
                lblDram.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblDram.ForeColor = Color.FromName("ControlText");
            }
        }

        private void lblKomedi_Click(object sender, EventArgs e)
        {
            if (lblKomedi.ForeColor == Color.FromName("ControlText"))
            {
                lblKomedi.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblKomedi.ForeColor = Color.FromName("ControlText");
            }
        }

        private void lblBelgesel_Click(object sender, EventArgs e)
        {
            if (lblBelgesel.ForeColor == Color.FromName("ControlText"))
            {
                lblBelgesel.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblBelgesel.ForeColor = Color.FromName("ControlText");
            }
        }

        private void lblRomantik_Click(object sender, EventArgs e)
        {
            if (lblRomantik.ForeColor == Color.FromName("ControlText"))
            {
                lblRomantik.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblRomantik.ForeColor = Color.FromName("ControlText");
            }
        }

        private void lblBilimKurgu_Click(object sender, EventArgs e)
        {
            if (lblBilimKurgu.ForeColor == Color.FromName("ControlText"))
            {
                lblBilimKurgu.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblBilimKurgu.ForeColor = Color.FromName("ControlText");
            }
        }

        private void FrmFilmEkle_Load(object sender, EventArgs e)
        {
            bugununTarihi();
            YonetmenListesiGetir();
            OyuncuListesiGetir();
            
        }
        void bugununTarihi()
        {
            nmcGun.Value = DateTime.Today.Day;
            nmcAy.Value = DateTime.Today.Month;
            nmcYil.Value = DateTime.Today.Year;
        }


        // KAPAT BUTONU 

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            verileriSil();


        }


        void TemizlemeMetodu()
        {

            this.Controls.Clear();
            InitializeComponent();
       
            FilmAdiTextBox.Focus();
            verileriSil();
            YonetmenListesiGetir();
            OyuncuListesiGetir();
            bugununTarihi();
            
        }




        void verileriSil()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Secilenler", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }


        // Radio Button Textlerini Almak İçin Yazdığımız Kodlar ----- 

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "1";
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "2";
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "3";
        }

        private void rb4_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "4";
        }

        private void rb5_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "5";
        }

        private void rb6_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "6";

        }

        private void rb7_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "7";

        }

        private void rb8_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "8";
        }

        private void rb9_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "9";
        }

        private void rb10_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "10";
        }



        // Film Biyografi TextBox Kodlarımız  300 karakter sınırlaması -- ----- 
        private void FilmEkleBiyografiTextBox_TextChanged(object sender, EventArgs e)
        {

            int karektersayisi = FilmEkleDetayTextBox.Text.Length;
            int geri = 300 - karektersayisi;
            karekterlbl.Text = geri.ToString();

            if (geri <= 20)
            {
                karekterlbl.ForeColor = Color.Red;
            }
        }


        // Yönetmen Listesini Getirmek için kullandık 

        void YonetmenListesiGetir()
        {

            FilmEkleYonetmenflpanel.Controls.Clear(); // Aradığımız zaman veya yeni bir şey eklediğimiz zaman önce bir temizle ardından verileri tekrardan çek!  
            baglanti.Open();
            SqlCommand araa = new SqlCommand("SELECT *FROM Yonetmenler WHERE CONCAT(y_adi, ' ', y_soyadi) LIKE '%" + FilmEkleOyuncutext.Text + "%'", baglanti);
            SqlDataReader okuu = araa.ExecuteReader();
            while (okuu.Read())
            {

                YönetmenListeAraci arac0 = new YönetmenListeAraci();

                arac0.YonetmenListeAracilbl.Text = okuu["y_adi"].ToString() + " " + okuu["y_soyadi"].ToString();

                

                FilmEkleYonetmenflpanel.Controls.Add(arac0);


               

            }


            baglanti.Close();
        }



            // Oyuncu Listesini Getirmek İçin Kullandık 
            void OyuncuListesiGetir()
            {

                FilmEkleOyuncuflpanel.Controls.Clear(); // Aradığımız zaman veya yeni bir şey eklediğimiz zaman önce bir temizle ardından verileri tekrardan çek!  
                baglanti.Open();
                SqlCommand ara = new SqlCommand("SELECT *FROM Oyuncular WHERE CONCAT(o_adi, ' ', o_soyadi) LIKE '%" + FilmEkleOyuncutext.Text + "%'", baglanti);
                SqlDataReader oku = ara.ExecuteReader();
                while (oku.Read())
                {

                    OyuncuListeAraci arac = new OyuncuListeAraci();

                    arac.OyuncListeAracilbl.Text = oku["o_adi"].ToString() + " " + oku["o_soyadi"].ToString();


                    FilmEkleOyuncuflpanel.Controls.Add(arac);


                }
                baglanti.Close();




            }

        private void FilmEkleOyuncutext_MouseLeave(object sender, EventArgs e)
        {
            FilmEkleOyunculbl.Visible = true ; 
        }

        private void FilmEkleOyuncutext_MouseMove(object sender, MouseEventArgs e)
        {
            FilmEkleOyunculbl.Visible = false;
        }

        private void FilmEkleYonetmentext_MouseLeave(object sender, EventArgs e)
        {
            FilmEkleYönetmenLbl.Visible = true;
        }

        private void FilmEkleYonetmentext_MouseMove(object sender, MouseEventArgs e)
        {
            FilmEkleYönetmenLbl.Visible = false;

        }

        private void FilmEkleOyuncutext_TextChanged(object sender, EventArgs e)
        {

            oyuncuAra();
        }



        // Oyuncu  Sorgusunu Yaptığımız Metodumuz -------------------
        void oyuncuAra()
        {

            string sorgu = "SELECT *FROM Oyuncular WHERE CONCAT(o_adi, ' ', o_soyadi) LIKE '%" + FilmEkleOyuncutext.Text + "%'";
            FilmEkleOyuncuflpanel.Controls.Clear(); // Aradığımız zaman veya yeni bir şey eklediğimiz zaman önce bir temizle ardından verileri tekrardan çek!  
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {

                OyuncuListeAraci araci = new OyuncuListeAraci();

                araci.OyuncListeAracilbl.Text = read["o_adi"].ToString() + " " + read["o_soyadi"].ToString();

                FilmEkleOyuncuflpanel.Controls.Add(araci);


            }

            baglanti.Close();

        }




        // Yönetmen Sorgusunu Yaptığımız Metodumuz -----------------
        void YonetmenAra()
        
        {


            FilmEkleYonetmenflpanel.Controls.Clear();
            baglanti.Open();
            SqlCommand ara = new SqlCommand("SELECT *FROM Yonetmenler WHERE CONCAT(y_adi, ' ', y_soyadi) LIKE '%" + FilmEkleYonetmentext.Text + "%'", baglanti);
            SqlDataReader oku = ara.ExecuteReader();
            while (oku.Read())
            {

                YönetmenListeAraci arac = new YönetmenListeAraci();

                arac.YonetmenListeAracilbl.Text = oku["y_adi"].ToString() + " " + oku["y_soyadi"].ToString();
                

                FilmEkleYonetmenflpanel.Controls.Add(arac);


            }
            baglanti.Close();

        }

        private void FilmEkleYonetmentext_TextChanged(object sender, EventArgs e)
        {
            YonetmenAra();
        }

        private void lblAltyazı_Click(object sender, EventArgs e)
        {
            if (lblAltyazı.ForeColor == Color.FromName("ControlText"))
            {
                lblAltyazı.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblAltyazı.ForeColor = Color.FromName("ControlText");
            }
        }

        private void lblİngilizce_Click(object sender, EventArgs e)
        {
            if (lblİngilizce.ForeColor == Color.FromName("ControlText"))
            {
                lblİngilizce.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblİngilizce.ForeColor = Color.FromName("ControlText");
            }

        }

        private void lblTürkçe_Click(object sender, EventArgs e)
        {
            if (lblTürkçe.ForeColor == Color.FromName("ControlText"))
            {
                lblTürkçe.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblTürkçe.ForeColor = Color.FromName("ControlText");
            }


        }

        private void lblartıonsekiz_Click(object sender, EventArgs e)
        {
          
            
            if (lblartıonsekiz.ForeColor == Color.FromName("ControlText"))
            {
                lblartıonsekiz.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblartıonsekiz.ForeColor = Color.FromName("ControlText");
            }

        }

        private void lblgenelizleyici_Click(object sender, EventArgs e)
        {
            if (lblgenelizleyici.ForeColor == Color.FromName("ControlText"))
            {
                lblgenelizleyici.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblgenelizleyici.ForeColor = Color.FromName("ControlText");
            }

        }

        private void lblartıyedi_Click(object sender, EventArgs e)
        {
            if (lblartıyedi.ForeColor == Color.FromName("ControlText"))
            {
                lblartıyedi.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblartıyedi.ForeColor = Color.FromName("ControlText");
            }
        }

        private void lblartıon_Click(object sender, EventArgs e)
        {
            if (lblartıon.ForeColor == Color.FromName("ControlText"))
            {
                lblartıon.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblartıon.ForeColor = Color.FromName("ControlText");
            }
        }

       


        void bugununtarihi()
        {

            nmcGun.Value = DateTime.Today.Day;
            nmcAy.Value = DateTime.Today.Month;
            nmcYil.Value = DateTime.Today.Year;

        }


        string Tarih = "";
        string durum = "0";

        void VizyonTarihiHesaplama()
        {
            Tarih = nmcGun.Value + "-" + nmcAy.Value + "-" + nmcYil.Value;
            DateTime dvTarih = Convert.ToDateTime(Tarih);
            DateTime bugunTarihi = DateTime.Today;

            // timeSpan --> var olan iki tarih arasındaki gün,ay,yıl,saat vb gibi konuları , sayısal verileri belirlemeye yarar.

            TimeSpan tSpan = dvTarih - bugunTarihi;

            if (tSpan.TotalDays < 0)
            {
                // İki tarih arasındaki fark negatif ise ne olacak.
                MessageBox.Show("GEÇMİŞ TARİHLERE AİT FİLM EKLENMESİ YAPILAMAZ! ");
                bugununTarihi();
            }
            else if (tSpan.TotalDays == 0)
            {
                
                durum = "1";
                MessageBox.Show(FilmAdiTextBox.Text.ToUpper()+" FİLMİ BUGÜN VİZYONDA!");
 
            }

            else
            {
                
                
                durum = "0";
                MessageBox.Show(FilmAdiTextBox.Text.ToUpper()+" "+tSpan.TotalDays.ToString()+" GÜN SONRA VİZYONA GİRECEKTİR!");

            }


        }

        private void FilmEkleTarihSecbttn_Click(object sender, EventArgs e)
        {
            VizyonTarihiHesaplama();
        }




        string yonetmen = "";
        string oyuncu = "";

        void secilenYonetmen()
        {
            yonetmen = "";
            string sorgu = "select*from Secilenler where Tur='Yönetmen'";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);

          //  komut.Parameters.AddWithValue("@p1", "Yönetmen");
      
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read()) // if ise burası tek bir seçim yapar . O yüzden while döngüsünü kullandık.
            {
                yonetmen += " , " + oku["kisi"].ToString();
            }


            baglanti.Close();


        }


        void secilenOyuncu()
        {
            oyuncu = "";
            string sorgu = "select*from Secilenler where Tur='Oyuncu'";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);



            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read()) // if ise burası tek bir seçim yapar . O yüzden while döngüsünü kullandık.
            {
                oyuncu += " , " + oku["kisi"].ToString();
            }


            baglanti.Close();


        }




        private void FilmEkleKayitTamamlaButon_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into Filmler (f_adi,f_turu,f_ozellikleri,f_bicimi,f_yonetmen,f_oyuncu,f_detay,f_puan,f_afis,f_tarih,f_durum) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)";

            secilenYonetmen();
            secilenOyuncu();
            tur();
            ozellik();
            bicim();

            // Boş Şekilde Eklemesinin Önüne Geçtik -----------

            if(FilmAdiTextBox.Text !="" && FilmEkleDetayTextBox.Text != "" && yonetmen != "" && oyuncu != "" && resimYolu !="" && Tarih != "" &&SecilenBicim !="" &&SecilenOzellik !=""&&SecilenTur!="" )
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", FilmAdiTextBox.Text.ToUpper());

                // Özelliklerin Eklenmesi Hususu 

                if (SecilenTur.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p2", SecilenTur.Substring(2));
                }
                else
                {
                    komut.Parameters.AddWithValue("@p2", SecilenTur);
                }

                if (SecilenOzellik.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p3", SecilenOzellik.Substring(2));
                }
                else
                {
                    komut.Parameters.AddWithValue("@p3", SecilenOzellik);
                }
                if (SecilenBicim.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p4", SecilenBicim.Substring(2));
                }
                else
                {
                    komut.Parameters.AddWithValue("@p4", SecilenBicim);
                }



                if (yonetmen.Length > 2) // Yapılan Seçim ve Seçim Uzunluğu 
                {
                    komut.Parameters.AddWithValue("@p5", yonetmen.Substring(2));
                }
                else
                {
                    komut.Parameters.AddWithValue("@p5", yonetmen);
                }


                if (oyuncu.Length > 2) // Yapılan Seçim ve Seçim Uzunluğu 
                {
                    komut.Parameters.AddWithValue("@p6", oyuncu.Substring(2));
                }
                else
                {
                    komut.Parameters.AddWithValue("@p6", oyuncu);
                }

                komut.Parameters.AddWithValue("@p7", FilmEkleDetayTextBox.Text.ToString());
                komut.Parameters.AddWithValue("@p8", lblRating.Text);
                komut.Parameters.AddWithValue("@p9", resimYolu);
                komut.Parameters.AddWithValue("@p10", Tarih);
                komut.Parameters.AddWithValue("@p11", durum);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("FİLM KAYDI BAŞARILI BİR ŞEKİLDE EKLENDİ");
                TemizlemeMetodu();

            }
            else {

                MessageBox.Show("LÜTFEN İLGİLİ SEÇİMLERİ YAPINIZ!");
            }





        }


        string SecilenTur = "";
        string SecilenOzellik = "";
        string SecilenBicim = "";

        void tur()
        {
            SecilenTur = "";
            foreach (Control arac in GroupBoxFimTürleri.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.FromName("ControlText"))
                    {

                    }

                    else
                    {
                        // Seçilmiş İse 

                        SecilenTur += " , " + arac.Text.ToString();

                    }
                }
        }   }


        void ozellik()
            
        {
            SecilenOzellik = "";
            foreach(Control arac in GroupBoxFimÖzellikleri.Controls) { 
            
            if (arac is Label)
                {
                    if (arac.ForeColor == Color.FromName("ControlText"))
                    {

                    }

                    else
                    {
                        SecilenOzellik += " , " + arac.Text.ToString();

                    }

                }
            
            
            
            }
        }

        
        void bicim()
        {

            SecilenBicim = "";
           
            foreach (Control arac in GroupBoxFimBicimi.Controls)
            {

                if (arac is Label)
                {
                    if (arac.ForeColor == Color.FromName("ControlText"))
                    {

                    }

                    else
                    {
                        SecilenBicim += " , " + arac.Text.ToString();

                    }

                }



            }
        }


    }


}
