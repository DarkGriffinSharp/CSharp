using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class FormYazarEkle : Form
    {
        public FormYazarEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);


        public DataSet dataSet = new DataSet();



        private void _btnYazarEkle_Click(object sender, EventArgs e)
        {



            try
            {

                string sorgu = "INSERT INTO[dbo].[Yazarlar]([yazarAd],[yazarSoyad])    VALUES(@yazarad,@yazarsoyad)";


                SqlCommand YazarEkle = new SqlCommand(sorgu, baglanti);

                YazarEkle.Parameters.AddWithValue("@yazarad",_txtYazarAd.Text);

                YazarEkle.Parameters.AddWithValue("@yazarsoyad", _txtYazarSoyad.Text);


                baglanti.Open();
                YazarEkle.ExecuteNonQuery();
                MessageBox.Show("Kayıt Yapıldı");
                baglanti.Close();

                YazarEkle.Dispose();


            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex);
            }



        }
    }
}
