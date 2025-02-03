using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinemasyon
{
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }


        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {

        }
        bool FilmGenişlik=false;
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;
        private void settingsTransition_Tick(object sender, EventArgs e)
        {
            if (FilmGenişlik == false)
            {
                FilmContainer.Height += 10;   
                if(FilmContainer.Height >=210) {
                    FilmTimer.Stop();
                    FilmGenişlik = true;
                }
            }
            else
            {
                FilmContainer.Height -= 10;
                if(FilmContainer.Height <= 97)
                {
                    FilmTimer.Stop();
                    FilmGenişlik = false;
                }
            }
        }

        private void filmSttngsBttn_Click(object sender, EventArgs e)
        {
            FilmTimer.Start();
        }

        /////////////////////////////////////////////////////////////////

        bool sidebarExpand = true;

   

        private void MenuBttn_Click(object sender, EventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FrmFilmEkle frmFilmEkle = new FrmFilmEkle();
            frmFilmEkle.ShowDialog();
        }


        private void button3_Click(object sender, EventArgs e)
        {
         
            FrmSalonKayit salonKayit = new FrmSalonKayit();
            salonKayit.ShowDialog(); 
            
        }


        // -----------------------------------------

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = this.Location;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = Cursor.Position.X - lastCursor.X;
                int deltaY = Cursor.Position.Y - lastCursor.Y;
                this.Location = new Point(lastForm.X + deltaX, lastForm.Y + deltaY);
            }
        }


        /// Mouse Hareketini  sağlıyormuş 
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        
          /////////////// Ödeme Yöntemleri //////////////
        private void sellBttn_Click(object sender, EventArgs e)
        {
            OyuncuTimer.Start();
        }


        // yeni eklenen 
        private void button1_Click(object sender, EventArgs e)
        {
            FilmTimer.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            YönetmenTimer.Start();
        }


        bool YonetmenGenislik= false;

        private void Yönetmen_Ayarları_Tick(object sender, EventArgs e)
        {

            if (YonetmenGenislik == false)
            {
                YonetmenContainer.Height += 10; 
                if(YonetmenContainer.Height>= 210)
                {
                    YönetmenTimer.Stop();
                    YonetmenGenislik = true;
                }
                

            }
            else
            {
                YonetmenContainer.Height -= 10;
                if(YonetmenContainer.Height <= 97)
                {
                    YönetmenTimer.Stop();
                    YonetmenGenislik = false;
                }
            }


        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void YonetmenContaiener_Paint(object sender, PaintEventArgs e)
        {

        }

        private void YönetmenAyarlarıPaneli_Paint(object sender, PaintEventArgs e)
        {

        }

        private void YonetmenContaiener_Paint_1(object sender, PaintEventArgs e)
        {

        }


        bool OyuncuGenislik = false;
        private void timer1_Tick(object sender, EventArgs e)
        {


            if (OyuncuGenislik == false)
            {
                OyuncuContainer.Height += 10;
                if (OyuncuContainer.Height >= 210)
                {
                    OyuncuTimer.Stop();
                    OyuncuGenislik = true;
                }


            }
            else
            {
                OyuncuContainer.Height -= 10;
                if (OyuncuContainer.Height <= 97)
                {
                    OyuncuTimer.Stop();
                    OyuncuGenislik = false;
                }
            }


        }

        private void OyuncuContainer_Paint(object sender, PaintEventArgs e)
        {

        }


       
         private void BtnBiletAyarlari_Click(object sender, EventArgs e)
        {
             BiletTimer.Start();
        }


        bool BiletGenislik = false;
        private void timer1_Tick_1(object sender, EventArgs e)
        {

            if (BiletGenislik == false)
            {
                BiletContainer.Height += 10;
                if (BiletContainer.Height >= 210)
                {
                    BiletTimer.Stop();
                    BiletGenislik = true;
                }


            }
            else
            {
                BiletContainer.Height -= 10;
                if (BiletContainer.Height <= 97)
                {
                    BiletTimer.Stop();
                    BiletGenislik = false;
                }
            }

        }

        private void BtnSalonAtamaEkrani_Click(object sender, EventArgs e)
        {

            FrmSalonAtama frm = new FrmSalonAtama();
            frm.ShowDialog();

        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            FrmAcilis yenifrm  = new FrmAcilis();
            this.Close();
            yenifrm.Show();
           
           
        }

     

     

        private void BtnYonetmenKayıtEkranı_Click_1(object sender, EventArgs e)
        {

            FrmYonetmenKayitt frmyeni1 = new FrmYonetmenKayitt();
            frmyeni1.ShowDialog();
        }

        private void BtnYonetmenListeEkranı_Click(object sender, EventArgs e)
        {
            FrmYonetmenListesi yenifrm1 = new FrmYonetmenListesi();
            yenifrm1.ShowDialog();
        }

        private void BtnOyuncuKayıtEkranı_Click(object sender, EventArgs e)
        {
            FrmOyuncuKayit yeni = new FrmOyuncuKayit();
            yeni.ShowDialog();
        }

        private void BtnOyuncuListeEkranı_Click(object sender, EventArgs e)
        {
            FrmOyuncuListesi FrmOyuncuListesi = new FrmOyuncuListesi();
            FrmOyuncuListesi.ShowDialog();
        }

        private void FilmListelemeButonu_Click(object sender, EventArgs e)
        {
            FrmFilmListeleme frm = new FrmFilmListeleme();
            frm.ShowDialog();
        }

        private void BtnBiletOlusturmaEkrani_Click(object sender, EventArgs e)
        {
            FrmBiletOlustur frm = new FrmBiletOlustur();
            frm.ShowDialog();
        }

        private void BtnBiletSorgulamaEkrani_Click(object sender, EventArgs e)
        {
            FrmBiletSorgulama frm = new FrmBiletSorgulama();
            frm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmDogrulama frm = new FrmDogrulama();
            frm.ShowDialog();
        }
    }
}
