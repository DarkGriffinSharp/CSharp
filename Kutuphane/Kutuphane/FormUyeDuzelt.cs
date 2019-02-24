using System;
using System.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class FormUyeDuzelt : Form
    {
        public FormUyeDuzelt()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);

        private void FormUyeDuzelt_Load(object sender, EventArgs e)
        {
            label1.Text = $"ID:{Form1.value[0]}'in Üye Bilgilerini Düzenle";
            _txtUyeAdi.Text = Form1.value[1];
            _txtUyeSoyad.Text = Form1.value[2];
            _txtUyeTCNo.Text = Form1.value[3];
            _txtTelefon.Text = Form1.value[4];
            _txtEposta.Text = Form1.value[6];
        }

        private void FormUyeDuzelt_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.Goster();
            var formToShow = Application.OpenForms.Cast<Form1>()
           .FirstOrDefault(c => c is Form1);
            if (formToShow != null)
            {
                formToShow.UyeListele();
            }
        }

        private void FormUyeDuzelt_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Sadece düzeltmek istediğiniz alanı/alanları değiştirin dolu alanları boş bırakmayın", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void _btnUyeDuzeltmeyiKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand($"UPDATE Uyeler SET " +
                    $"tcNo = {_txtUyeTCNo.Text}," +
                    $"uyeAd = '{_txtUyeAdi.Text}'," +
                    $"uyeSoyad = '{_txtUyeSoyad.Text}'," +
                    $"telefon = '{_txtTelefon.Text}'," +
                    $"eposta = '{_txtEposta.Text}' " +
                    $"WHERE uye_id = {Form1.value[0]}",
                    baglanti);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Düzeltme başarılı.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                baglanti.Close();
                Close();
            }
        }
    }
}
