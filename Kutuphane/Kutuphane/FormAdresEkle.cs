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


    public partial class FormAdresEkle : Form
    {
        public FormAdresEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);

        public DataSet dataSet = new DataSet();

       
        
        private void AdresKaydet()
        {
            try
            {
                string sorgu = "INSERT INTO [dbo].[Adresler]([cadde],[sokak],[mahalle] ,[binNo],[kat],[postakodu],[il],[ilce])  VALUES(@cadde,@sokak,@mahalle,@numbinano,@numkatno,@postakodu,@il,@ilce)";

                SqlCommand komut = new SqlCommand(sorgu, baglanti);


                    komut.Parameters.AddWithValue("@cadde", _txtCadde.Text);
                    komut.Parameters.AddWithValue("@sokak", _txtSokak.Text);

                    komut.Parameters.AddWithValue("@mahalle", _txtMahalle.Text);

                    komut.Parameters.AddWithValue("@numbinano", Convert.ToInt32(_numBinaNO.Text));
                    komut.Parameters.AddWithValue("@numkatno", Convert.ToInt32(_numKatNo.Text));
                    komut.Parameters.AddWithValue("@postakodu", Convert.ToInt32(_txtPostaKodu.Text));
                    komut.Parameters.AddWithValue("@il", _txtIl.Text);
                    komut.Parameters.AddWithValue("@ilce", _txtIlce.Text);


                    baglanti.Open();
                //bu kısımda 
                //ExecuteNonQuery(); .bu metot geriye int olarak insert,update,delete olaylarından etkilen satır sayısını döndürür
                //ExecuteScalar(); bu metot tek satırlık veri döndüren sql sorguları içindir
                //ExeceuteReader(); Uygulamalarda çalıştırılan komutsonucu elde edilen sonuc kümesinden bir sqldatareader nesnesi için veri akışı sağlar. Select ile yapılan sorguları çekiyoruz.


               komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Yapıldı");

                baglanti.Close();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }



        private void _btAdresKaydet_Click(object sender, EventArgs e)
        {
            AdresKaydet();
            Listele();
        }

        private void Listele()
        {
            baglanti.Open();

            string sorgu = "select * From Adresler";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sorgu, baglanti);

            //databse içerisindeki tablonun ismi,remdeki hali al doldur

            dataAdapter.Fill(dataSet, "Adresler");

            //datasetteki Adresler tablosunu al yükle dbgride
            _dbAdresListele.DataSource = dataSet.Tables["Adresler"];

            _dbAdresListele.Columns[0].Visible = false;
            //dataadaoter nesenesini ucur
            dataAdapter.Dispose();
            baglanti.Close();


        }


        private void FormAdresEkle_Load(object sender, EventArgs e)
        {

            _lblAdresNo.Text = "-1";
            Listele();
            _dbAdresListele.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           // _dbAdresListele.EditMode = DataGridViewEditMode.EditProgrammatically;


        }

        private void _dbAdresListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_lblAdresNo.Text!="-1")
            {
                _btAdresKaydet.Text = "  Güncelle";
            }
            else
            {
                _btAdresKaydet.Text = "Kaydet";
            }

            //txt içersine o anda seçili olan elmanı basıyor Cell[satır no] içerisinde  bilgileri alır textboxlar işler.

            Label l = new Label();
            
            l.Text= _dbAdresListele.CurrentRow.Cells[0].Value.ToString();


            _lblAdresNo.Text = _dbAdresListele.CurrentRow.Cells[0].Value.ToString();

            _txtCadde.Text = _dbAdresListele.CurrentRow.Cells[1].Value.ToString();

            _txtSokak.Text = _dbAdresListele.CurrentRow.Cells[2].Value.ToString();

            _txtMahalle.Text = _dbAdresListele.CurrentRow.Cells[3].Value.ToString();

            _numBinaNO.Text = _dbAdresListele.CurrentRow.Cells[4].Value.ToString();

            _numKatNo.Text = _dbAdresListele.CurrentRow.Cells[5].Value.ToString();

            _txtPostaKodu.Text = _dbAdresListele.CurrentRow.Cells[6].Value.ToString();

            _txtIl.Text = _dbAdresListele.CurrentRow.Cells[7].Value.ToString();

            _txtIlce.Text = _dbAdresListele.CurrentRow.Cells[8].Value.ToString();



        }



        private void _btnADresTemizle_Click(object sender, EventArgs e)
        {

            _lblAdresNo.Text = "-1";
            _txtCadde.Text = "";
            _txtSokak.Text = "";
            _txtMahalle.Text = "";
            _numBinaNO.Text = "";
            _numKatNo.Text ="";
            _txtPostaKodu.Text = "";
            _txtIl.Text = "";
            _txtIlce.Text = "";
            _btAdresKaydet.Text = "Kaydet";


        }

        private void _btnAdresSil_Click(object sender, EventArgs e)
        {
            _lblAdresNo.Text = _dbAdresListele.CurrentRow.Cells[0].Value.ToString();

            DialogResult cevap;
            cevap = MessageBox.Show("Kaydı silmek istediğinizden eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                baglanti.Open();
                string sorgu = "DELETE from Adresler WHERE adres_id=@silno ";

                SqlCommand komut = new SqlCommand(sorgu,baglanti);
                komut.Parameters.AddWithValue("@silno", _lblAdresNo.Text);


                komut.ExecuteNonQuery();


                komut.Dispose();
                baglanti.Close();
                //remdeki eski hlini siliyoruz ,
                dataSet.Tables["Adresler"].Clear();

                Listele();
                //text alanları siliyor
                _btnADresTemizle_Click(sender, e);
            }
        }

        private void _dbAdresListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
