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
using System.Security.Cryptography.X509Certificates;

namespace Sinemasyon
{
    public partial class FrmBiletSorgulama : Form
    {
        public FrmBiletSorgulama()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS01 ;Initial Catalog=SinemasyonDB;Integrated Security=True");



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {


            if(txtBiletNo.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select*from Biletler where b_kod=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", txtBiletNo.Text.ToString());
                SqlDataReader oku = komut.ExecuteReader();

                if (oku.Read())
                {
                    FrmBiletDetay frm = new FrmBiletDetay();
                    frm.biletNo = txtBiletNo.Text.ToString();
                    txtBiletNo.Text = "";
                    frm.ShowDialog();


                }

                else
                {
                    MessageBox.Show("KAYITLI BİLET BULUNAMADI!");
                    baglanti.Close();
                }

                baglanti.Close();


            }

            else
            {
                MessageBox.Show("LÜTFEN BİLET NUMARASI GİRİNİZ!");
            }


        }
      public void verilerigetir(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler,baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];



        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigetir("select * from Biletler ");
        }
    }
}
