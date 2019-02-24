using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Kutuphane
{
    public partial class FormUyeKayit : Form
    {
        public FormUyeKayit()
        {
            InitializeComponent();
            Form1 form=new Form1();

           // _cmbAdresSec.Items.Add(  form.hashtable.ToString());

            

        }



        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);


        //private string Sorgu(string secim)
        //{
        //    string sorgu=null;


        //    switch (secim)
        //    {
        //        case "kayit":  sorgu = "INSERT INTO [dbo].[Uyeler] ([uyeAd],[uyeSoyad],[tcNo],[cinsiyet],[telefon],[eposta],[adres_id]) VALUES(@uyeadi,@uyesoyadi,@tcNo,@cinsiyet,@telefon,@eposta)";


        //            break;

        //        case "Listele": sorgu = "SELECT * FROM Adresler";break;

        //    }

        //    return sorgu;
        //}

        public string EkleAdres
        {
            get;set;

        }

        private void UyeKaydet()
        {

            string sorgu ="INSERT INTO[dbo].[Uyeler]([uyeAd],[uyeSoyad],[tcNo],[cinsiyet],[telefon],[eposta],[adres_id]) VALUES(@uyeadi, @uyesoyadi, @tcNo, @cinsiyet, @telefon, @eposta,@adres_id)";

            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            komut.Parameters.AddWithValue("@uyeadi", _txtUyeAdi.Text);
            komut.Parameters.AddWithValue("@uyesoyadi", _txtUyeSoyad.Text);
            komut.Parameters.AddWithValue("@tcNo", _txtUyeTCNo.Text);

            string c = null;
            if (_rdbutonE.Checked == true)
            {
                c = "Erkek";
            }
            else
            if (_rdbutonK.Checked == true)
                c = "Kadın";

            komut.Parameters.AddWithValue("@cinsiyet", c.ToString());
            komut.Parameters.AddWithValue("@telefon", _txtTelefon.Text);
            komut.Parameters.AddWithValue("@eposta", _txtEposta.Text);
            komut.Parameters.AddWithValue("@adres_id",Convert.ToInt32( label9.Text));

            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Yapıldı");
            baglanti.Close();
            komut.Dispose();


        }


        private void _btnYeniUyeKaydet_Click(object sender, EventArgs e)
        {

            UyeKaydet();

        }

        Form1 Form = new Form1();

        private void FormYeniKayit_Load(object sender, EventArgs e)
        {
            Form.AdreslerCek(_cmbAdresSec);
            //string[] dizi = _cmbAdresSec.SelectedText.Split(' ');
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    listBox1.Items.Add(dizi[i]);
            //}
        }
        private void _cmbAdresSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = _cmbAdresSec.SelectedItem.ToString();
            string[] parcalar;
            parcalar = a.Split(' ');
            label9.Text = parcalar[0];
        }

        private void _txtUyeTCNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormUyeDuzenle_FormClosed(object sender, FormClosedEventArgs e)
        {
            var formToShow = Application.OpenForms.Cast<Form>()
            .FirstOrDefault(c => c is Form1);
            if (formToShow != null)
            {
                formToShow.Show();
            }
        }
    }
}