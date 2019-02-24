using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;


namespace Kutuphane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
        public static List<string> value = new List<string>();
        SqlCommand cmd;

        public DataSet dataSet = new DataSet();

        int satir_no;
        //byte secim;

        List<Adresler> adresler = new List<Adresler>();
        Adresler adres = new Adresler();
        
        FormUyeKayit formyeniKayit;
        FormAdresEkle formadresekle;
        FormKitapEkle formkitapekle = new FormKitapEkle();

        private void Form1_Load(object sender, EventArgs e)
        {

            #region YayineviListele

            AdreslerCek(_cmbAdresBilgisi);
            AdreslerCek(_cmbKutuphaneAdres);

            #endregion


            KategoriListele();


            YazarListele();
            KitapListele();

        }

        public void Gizle()
        {
            var formToShow = Application.OpenForms.Cast<Form>()
            .FirstOrDefault(c => c is Form1);
            if (formToShow != null)
            {
                formToShow.Hide();
            }
        }

        public static void Goster()
        {
            var formToShow = Application.OpenForms.Cast<Form>()
            .FirstOrDefault(c => c is Form1);
            if (formToShow != null)
            {
                formToShow.Show();
            }
        }

        public void UyeListele()
        {
            _dbGridUyeler.DataSource = null;
            baglanti.Open();

            string sorgu = "SELECT * FROM UyelerView";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sorgu, baglanti);

            //yeniden datatable oluşturuyoruz.
            DataTable data = new DataTable();


            //databse içerisindeki tablonun ismi,remdeki hali al doldur

            dataAdapter.Fill(data);

            //datasetteki Adresler tablosunu al yükle dbgride
            _dbGridUyeler.DataSource = data;
            _dbGridUyeler.Refresh();
            _dbGridUyeler.Update();


            //_dbGridUyeler.Columns[0].Visible = false;

            //_dbGridUyeler.Columns[7].Visible = false;
            //_dbGridUyeler.Columns[8].Visible = false;

            _dbGridUyeler.Columns[0].HeaderText = "Üye ID";
            _dbGridUyeler.Columns[1].HeaderText = "Adı";
            _dbGridUyeler.Columns[2].HeaderText = "Soyadı";
            _dbGridUyeler.Columns[3].HeaderText = "TC";
            _dbGridUyeler.Columns[4].HeaderText = "Telefon";
            _dbGridUyeler.Columns[5].HeaderText = "Cinsiyet";
            _dbGridUyeler.Columns[6].HeaderText = "E-Posta";
            _dbGridUyeler.Columns[7].HeaderText = "Mahalle";
            _dbGridUyeler.Columns[8].HeaderText = "Sokak";
            _dbGridUyeler.Columns[9].HeaderText = "Cadde";
            _dbGridUyeler.Columns[10].HeaderText = "Şehir";
            _dbGridUyeler.Columns[11].HeaderText = "İlçe";
            _dbGridUyeler.Columns[12].HeaderText = "Posta Kodu";
            //dataadaoter nesenesini ucur
            dataAdapter.Dispose();

            baglanti.Close();


        }

        private void KategoriListele()
        {
            baglanti.Open();

            string sorgu = "select * From Kategoriler";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sorgu, baglanti);

            //yeniden datatable oluşturuyoruz.
            DataTable data = new DataTable();


            //databse içerisindeki tablonun ismi,remdeki hali al doldur

            dataAdapter.Fill(data);

            //datasetteki Adresler tablosunu al yükle dbgride
            _dbGridKategoriler.DataSource = data;
            _dbGridKategoriler.Refresh();
            _dbGridKategoriler.Update();

            _dbGridKategoriler.Columns[0].Visible = false;
            //dataadaoter nesenesini ucur
            dataAdapter.Dispose();
            baglanti.Close();
        }

        public void KitapListele()
        {
            baglanti.Open();

            string sorgu = "select * From  VM_KitaplarListele";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sorgu, baglanti);

            //yeniden datatable oluşturuyoruz.
            DataTable data = new DataTable();


            //databse içerisindeki tablonun ismi,remdeki hali al doldur

            dataAdapter.Fill(data);

            //datasetteki Adresler tablosunu al yükle dbgride
            _dbGridKitaplar.DataSource = data;
            _dbGridKitaplar.Refresh();
            _dbGridKitaplar.Update();

            _dbGridKitaplar.Columns[0].Visible = false;
            //dataadaoter nesenesini ucur
            dataAdapter.Dispose();
            baglanti.Close();
        }

        public void YazarListele()
        {
            try
            {
                baglanti.Open();

                string sorgu = "select * from Yazarlar";

                SqlDataAdapter YazarEviek = new SqlDataAdapter(sorgu, baglanti);

                //yeniden datatable oluşturuyoruz.
                DataTable data = new DataTable();

                //databse içerisindeki tablonun ismi,remdeki hali al doldur

                YazarEviek.Fill(data);

                //datasetteki Adresler tablosunu al yükle dbgride
                _dbGridYazarlar.DataSource = data;
                _dbGridYazarlar.Refresh();
                _dbGridYazarlar.Update();

                _dbGridYazarlar.Columns[0].Visible = false;

                //dataadaoter nesenesini ucur
                YazarEviek.Dispose();
                baglanti.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void YayinEviListele()
        {
            try
            {
                baglanti.Open();

                string sorgu = "select * from Yayinevleri";


                SqlDataAdapter yayinEviCek = new SqlDataAdapter(sorgu, baglanti);

                yayinEviCek.Fill(dataSet, "Yayinevleri");

                _dbGridYayinEvleri.DataSource = dataSet.Tables["Yayinevleri"];

                _dbGridYayinEvleri.Columns[0].Visible = false;

                yayinEviCek.Dispose();
                baglanti.Close();
            }
            catch (Exception)
            {
                throw;
            }


        }

        private void _btnUyeEkle_Click(object sender, EventArgs e)
        {
            Gizle();
            FormUyeKayit formYeni = new FormUyeKayit();
            formYeni.ShowDialog();
        }

        private void _btnAdresEkle_Click(object sender, EventArgs e)
        {
            FormAdresEkle formAdresEkle = new FormAdresEkle();
            formAdresEkle.Show();

        }

        private void _btnYayinEviKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "INSERT INTO [dbo].[Yayinevleri]          ([YayinEviAdi],[adres_id])VALUES(@yayinEviAdi,@adresID)";

                SqlCommand yayiEviEkle = new SqlCommand(sorgu, baglanti);

                yayiEviEkle.Parameters.AddWithValue("@yayinEviAdi", _txtYayinEviAdi.Text);
                yayiEviEkle.Parameters.AddWithValue("@adresID", Convert.ToInt32(_lbladresId.Text));

                baglanti.Open();
                yayiEviEkle.ExecuteNonQuery();
                MessageBox.Show("Kayıt Yapıldı");
                baglanti.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex);
            }



        }

        private void _btnYayinEviSil_Click(object sender, EventArgs e)
        {

            DialogResult sonuc = MessageBox.Show("Yayın evini silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            try
            {

                if (sonuc == DialogResult.Yes)
                {

                    string sorgu = "DELETE FROM Yayinevleri WHERE adres_id='" + satir_no + "'";

                    SqlCommand ysil = new SqlCommand(sorgu, baglanti);

                    //ysil.Parameters.AddWithValue("@sil",satir_no);

                    baglanti.Open();
                    ysil.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Silindi");

                    ysil.Dispose();

                    baglanti.Close();

                    dataSet.Tables["Yayinevleri"].Clear();

                    YayinEviListele();

                    _txtYayinEviAdi.Clear();
                    _cmbAdresBilgisi.SelectedIndex = 0;

                }
            }
            catch (Exception)
            {

                throw;
            }




        }

        private void _dbGridYayinEvleri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            satir_no = Convert.ToInt32(_dbGridYayinEvleri.CurrentRow.Cells[0].Value);


            _txtYayinEviAdi.Text = _dbGridYayinEvleri.CurrentRow.Cells[1].Value.ToString();

            _cmbAdresBilgisi.SelectedIndex = Convert.ToInt32(_dbGridYayinEvleri.CurrentRow.Cells[2].Value);



        }

        public void AdreslerCek(ComboBox comboBox)
        {
            string sorgu = "SELECT * FROM Adresler";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sorgu, baglanti);

            baglanti.Open();

            SqlCommand sql = new SqlCommand();

            sql.Connection = baglanti;
            sql.CommandText = sorgu;

            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);

            SqlDataReader oku = sql.ExecuteReader();



            int i = 0;


            while (oku.Read())
            {

                Adresler[] adreslers =  {
                new Adresler(Convert.ToInt32(dataTable.Rows[i].Field<int>("adres_id")),dataTable.Rows[i].Field<string>("Sokak"),   dataTable.Rows[i].Field<string>("Cadde"))};
                i++;

                //comboBox.DataSource = dataTable;

                //comboBox.ValueMember = dataTable.Columns[0].ColumnName;

                //comboBox.DisplayMember = dataTable.Columns["sokak"].ColumnName+ dataTable.Columns["cadde"].ColumnName;


                //dataAdapter.Fill(dataSet, "Adresler");
                // comboBox.DisplayMember = ;
                //comboBox.ValueMember = adres.adresID.ToString();


                //   comboBox.DataSource = dataSet.Tables["Adresler"];


                //comboBox.ValueMember = adres.adresID.ToString();





                comboBox.Items.AddRange(adreslers);









            }





            baglanti.Close();
            dataAdapter.Dispose();

        }

        public class Adresler
        {
            public int adres_id;
            public string Cadde;
            public string Sokak;

            //public int adresID
            //{
            //     get { return adres_id; }

            //}

            //iki parametreli constructor
            public Adresler(int adres_id, string Cadde, string Sokak)
            {
                this.adres_id = adres_id;
                this.Cadde = Cadde;
                this.Sokak = Sokak;

            }


            //iki parametreli constructor
            public Adresler(int adres_id)
            {
                this.adres_id = adres_id;



            }
            //Parametresiz constructor
            public Adresler()
            {

                Cadde = "";
                Sokak = "";
            }

            public override string ToString()
            {
                return adres_id + " " + Cadde + " " + Sokak;
            }



        }

        private void _btnUyesiSil_Click(object sender, EventArgs e)
        {
            if (value.Count != 0)
            {
                try
                {
                    baglanti.Open();
                    cmd = new SqlCommand($"INSERT INTO Silinenler " +
                        $"(uye_id, uyeAd, uyeSoyad, tcNo, cinsiyet, telefon, eposta) " +
                        $"VALUES " +
                        $"({int.Parse(value[0])}, '{value[1]}', '{value[2]}', '{value[3]}', '{value[5]}', '{value[4]}', '{value[7]}')", baglanti);
                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand($"DELETE FROM Uyeler WHERE uye_id = {value[0]}", baglanti);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    MessageBox.Show($"{value[0]} id'li üye silindi.", "Silme başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    baglanti.Close();
                    UyeListele();
                }
            }
            else
            {
                MessageBox.Show("Seçim yapılmadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _cmbAdresBilgisi_SelectedIndexChanged(object sender, EventArgs e)
        {

            string a = _cmbAdresBilgisi.SelectedItem.ToString();

            string[] parcalar;

            parcalar = a.Split(' ');

            _lbladresId.Text = parcalar[0];
        }

        private void _btnKategoriEkle_Click(object sender, EventArgs e)
        {
            int var = 0;

            try
            {
                //string sorgu = "INSERT INTO [dbo].[Kategoriler]          ([kategoriAd]) VALUES (@kategoriEkle)";
                baglanti.Open();

                //bunraki yazılan store procedurun ismi

                string sorgu = "SP_KategoriEkle";

                SqlCommand kategoriEkle = new SqlCommand(sorgu, baglanti);
               
                // CommendTrype-çekilen sorgunun türünün StoreProcedure oldugunu yanibir metot  oldugunu belirtir.

                kategoriEkle.CommandType = CommandType.StoredProcedure;


                //store procedure --parametre isimi ile buradaki parametre dları aynı olmalı
                kategoriEkle.Parameters.AddWithValue("@KategoriAdi", _txtKategoriEkle.Text);

               

                var= kategoriEkle.ExecuteNonQuery();
                 
                MessageBox.Show(var != 0 ? "İŞLEM BAŞARILI" : "İŞLEM BAŞARISIZ");
                baglanti.Close();

                KategoriListele();

                _dbGridKategoriler.Refresh();
                _dbGridKategoriler.Update();


            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex);
            }





        }

        private void _btnBaglantiAc_Click(object sender, EventArgs e)
        {
            try
            {
                //baglantı acıkmı degılmı kontolunu sağlamak için

                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                    MessageBox.Show("baglantı acıldı");
                    _btnBaglantiAc.Enabled = false;
                    button1.Enabled = true;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void _btnKitapEkle_Click(object sender, EventArgs e)
        {
            FormKitapEkle kitapEkle = new FormKitapEkle();

            kitapEkle.Show();
        }

        private void _btnYazrEkle_Click(object sender, EventArgs e)
        {
            FormYazarEkle yazarEkle = new FormYazarEkle();

            yazarEkle.Show();
        }

        private void _cmbKutuphaneAdres_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = _cmbKutuphaneAdres.SelectedItem.ToString();

            string[] parcalar;

            parcalar = a.Split(' ');

            _lblAdresNo.Text = parcalar[0];
        }

        private void _btnKutuphaneEke_Click(object sender, EventArgs e)
        {
            int var = 0;

            try
            {
                string sorgu = "INSERT INTO [dbo].[Kutuphane] ([KutuphaneAd],[adres_id]) VALUES(@kutuphaneEkle,@adres_id)";

                SqlCommand kutuphaneEkle = new SqlCommand(sorgu, baglanti);

                kutuphaneEkle.Parameters.AddWithValue("@kutuphaneEkle", _txtKutuphaneAdi.Text);

                kutuphaneEkle.Parameters.AddWithValue("@adres_id", _lblAdresNo.Text);

                baglanti.Open();


                var=kutuphaneEkle.ExecuteNonQuery();

                MessageBox.Show(var!=0?"Kayıt yapıldı":"Kayıt başarısız oldu ","Mesaj",MessageBoxButtons.OK);


                baglanti.Close();

                 

                _dbGridKategoriler.Refresh();

                _dbGridKategoriler.Update();



            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //baglantı acıkmı degılmı kontolunu sağlamak için

                if (baglanti.State == ConnectionState.Connecting)
                {
                    baglanti.Close();
                    MessageBox.Show("baglantı kapandı");
                    _btnBaglantiAc.Enabled = true;
                    button1.Enabled = false;
                }
                else if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                    MessageBox.Show("baglantı kapandı");
                    _btnBaglantiAc.Enabled = true;
                    button1.Enabled = false;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (baglanti.State == ConnectionState.Connecting ||
                baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
            if (tabControl1.SelectedTab == tabPage4)
            {
                if (baglanti.State == ConnectionState.Connecting || 
                    baglanti.State == ConnectionState.Open)
                {
                    _btnBaglantiAc.Enabled = false;
                    button1.Enabled = true;
                }
                else
                {
                    _btnBaglantiAc.Enabled = true;
                    button1.Enabled = false;
                }
            }
        }

        private void _btnUyeDuzelt_Click(object sender, EventArgs e)
        {
            if (value.Count != 0)
            {
                Gizle();
                FormUyeDuzelt fud = new FormUyeDuzelt();
                fud.ShowDialog();
            }
            else
            {
                MessageBox.Show("Düzeltme yapmak için seçim yapın", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _dbGridUyeler_SelectionChanged(object sender, EventArgs e)
        {
            value.Clear();
            foreach (DataGridViewRow item in _dbGridUyeler.SelectedRows)
            {
                for (int i = 0; i < item.Cells.Count; i++)
                {
                    value.Add(item.Cells[i].Value.ToString());
                }
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            UyeListele();
        }
    }
}
