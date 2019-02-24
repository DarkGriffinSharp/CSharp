namespace Kutuphane
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this._uyeler = new System.Windows.Forms.GroupBox();
            this._dbGridUyeler = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._btnAdresEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this._txtUyeAra = new System.Windows.Forms.TextBox();
            this._btnUyeAra = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this._btnUyeDuzelt = new System.Windows.Forms.Button();
            this._btnUyesiSil = new System.Windows.Forms.Button();
            this._btnUyeEkle = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._dbGridKitaplar = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._lblAdresNo = new System.Windows.Forms.Label();
            this._cmbKutuphaneAdres = new System.Windows.Forms.ComboBox();
            this._txtKutuphaneAdi = new System.Windows.Forms.TextBox();
            this._btnKutuphaneEke = new System.Windows.Forms.Button();
            this._txtKitapAdi = new System.Windows.Forms.TextBox();
            this._btnKitapAra = new System.Windows.Forms.Button();
            this._btnKitapDuzelt = new System.Windows.Forms.Button();
            this._btnKitapSil = new System.Windows.Forms.Button();
            this._btnKitapEkle = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this._dbGridYazarlar = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this._txtYazarAdi = new System.Windows.Forms.TextBox();
            this._btnYazarAra = new System.Windows.Forms.Button();
            this._btnYazarDuzelt = new System.Windows.Forms.Button();
            this._btnYazarSil = new System.Windows.Forms.Button();
            this._btnYazrEkle = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this._btnBaglantiAc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this._txtKategoriEkle = new System.Windows.Forms.TextBox();
            this._dbGridKategoriler = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this._btnKitapTemizle = new System.Windows.Forms.Button();
            this._btnKategoriEkle = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this._lbladresId = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._cmbAdresBilgisi = new System.Windows.Forms.ComboBox();
            this._txtYayinEviAdi = new System.Windows.Forms.TextBox();
            this._dbGridYayinEvleri = new System.Windows.Forms.DataGridView();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this._btnYayinEviSil = new System.Windows.Forms.Button();
            this._btnYayinEviKaydet = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this._btnEmanetTmamla = new System.Windows.Forms.Button();
            this._btnEmanetKaydet = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._dtepicturTelsimTa = new System.Windows.Forms.DateTimePicker();
            this._dtepicturVerilisTa = new System.Windows.Forms.DateTimePicker();
            this._cmbVerilenKitap = new System.Windows.Forms.ComboBox();
            this._cmbKitapveruye = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farklıKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baskıÖnizlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yineleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tümünüSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.özelleştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçeneklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.içindekilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dizinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this._uyeler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dbGridUyeler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dbGridKitaplar)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dbGridYazarlar)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dbGridKategoriler)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dbGridYayinEvleri)).BeginInit();
            this.groupBox11.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox12.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.ımageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 426);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this._uyeler);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.ImageIndex = 5;
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Üyeler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // _uyeler
            // 
            this._uyeler.Controls.Add(this._dbGridUyeler);
            this._uyeler.Location = new System.Drawing.Point(8, 73);
            this._uyeler.Name = "_uyeler";
            this._uyeler.Size = new System.Drawing.Size(781, 309);
            this._uyeler.TabIndex = 4;
            this._uyeler.TabStop = false;
            this._uyeler.Text = "Üyeler";
            // 
            // _dbGridUyeler
            // 
            this._dbGridUyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dbGridUyeler.Location = new System.Drawing.Point(6, 19);
            this._dbGridUyeler.Name = "_dbGridUyeler";
            this._dbGridUyeler.Size = new System.Drawing.Size(770, 281);
            this._dbGridUyeler.TabIndex = 1;
            this._dbGridUyeler.SelectionChanged += new System.EventHandler(this._dbGridUyeler_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._btnAdresEkle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this._txtUyeAra);
            this.groupBox1.Controls.Add(this._btnUyeAra);
            this.groupBox1.Controls.Add(this._btnUyeDuzelt);
            this.groupBox1.Controls.Add(this._btnUyesiSil);
            this.groupBox1.Controls.Add(this._btnUyeEkle);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 61);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // _btnAdresEkle
            // 
            this._btnAdresEkle.Location = new System.Drawing.Point(329, 16);
            this._btnAdresEkle.Name = "_btnAdresEkle";
            this._btnAdresEkle.Size = new System.Drawing.Size(112, 38);
            this._btnAdresEkle.TabIndex = 8;
            this._btnAdresEkle.Text = "Adres Ekle";
            this._btnAdresEkle.UseVisualStyleBackColor = true;
            this._btnAdresEkle.Click += new System.EventHandler(this._btnAdresEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Üye Adı";
            // 
            // _txtUyeAra
            // 
            this._txtUyeAra.Location = new System.Drawing.Point(582, 34);
            this._txtUyeAra.Name = "_txtUyeAra";
            this._txtUyeAra.Size = new System.Drawing.Size(100, 20);
            this._txtUyeAra.TabIndex = 5;
            // 
            // _btnUyeAra
            // 
            this._btnUyeAra.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this._btnUyeAra.ImageIndex = 8;
            this._btnUyeAra.ImageList = this.ımageList1;
            this._btnUyeAra.Location = new System.Drawing.Point(688, 15);
            this._btnUyeAra.Name = "_btnUyeAra";
            this._btnUyeAra.Size = new System.Drawing.Size(84, 39);
            this._btnUyeAra.TabIndex = 4;
            this._btnUyeAra.Text = "Ara";
            this._btnUyeAra.UseVisualStyleBackColor = true;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "database.ico");
            this.ımageList1.Images.SetKeyName(1, "edit.ico");
            this.ımageList1.Images.SetKeyName(2, "factory.ico");
            this.ımageList1.Images.SetKeyName(3, "file-import.ico");
            this.ımageList1.Images.SetKeyName(4, "folder-blue.ico");
            this.ımageList1.Images.SetKeyName(5, "group.ico");
            this.ımageList1.Images.SetKeyName(6, "add-user.ico");
            this.ımageList1.Images.SetKeyName(7, "delete-user.ico");
            this.ımageList1.Images.SetKeyName(8, "view.ico");
            this.ımageList1.Images.SetKeyName(9, "user.ico");
            this.ımageList1.Images.SetKeyName(10, "file-edit.ico");
            this.ımageList1.Images.SetKeyName(11, "file-new.ico");
            this.ımageList1.Images.SetKeyName(12, "file-up.ico");
            // 
            // _btnUyeDuzelt
            // 
            this._btnUyeDuzelt.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this._btnUyeDuzelt.ImageIndex = 9;
            this._btnUyeDuzelt.ImageList = this.ımageList1;
            this._btnUyeDuzelt.Location = new System.Drawing.Point(216, 16);
            this._btnUyeDuzelt.Name = "_btnUyeDuzelt";
            this._btnUyeDuzelt.Size = new System.Drawing.Size(107, 39);
            this._btnUyeDuzelt.TabIndex = 3;
            this._btnUyeDuzelt.Text = "Düzelt";
            this._btnUyeDuzelt.UseVisualStyleBackColor = true;
            this._btnUyeDuzelt.Click += new System.EventHandler(this._btnUyeDuzelt_Click);
            // 
            // _btnUyesiSil
            // 
            this._btnUyesiSil.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this._btnUyesiSil.ImageIndex = 7;
            this._btnUyesiSil.ImageList = this.ımageList1;
            this._btnUyesiSil.Location = new System.Drawing.Point(114, 16);
            this._btnUyesiSil.Name = "_btnUyesiSil";
            this._btnUyesiSil.Size = new System.Drawing.Size(96, 39);
            this._btnUyesiSil.TabIndex = 1;
            this._btnUyesiSil.Text = "Sil";
            this._btnUyesiSil.UseVisualStyleBackColor = true;
            this._btnUyesiSil.Click += new System.EventHandler(this._btnUyesiSil_Click);
            // 
            // _btnUyeEkle
            // 
            this._btnUyeEkle.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this._btnUyeEkle.ImageIndex = 6;
            this._btnUyeEkle.ImageList = this.ımageList1;
            this._btnUyeEkle.Location = new System.Drawing.Point(8, 16);
            this._btnUyeEkle.Name = "_btnUyeEkle";
            this._btnUyeEkle.Size = new System.Drawing.Size(100, 39);
            this._btnUyeEkle.TabIndex = 2;
            this._btnUyeEkle.Text = "Ekle";
            this._btnUyeEkle.UseVisualStyleBackColor = true;
            this._btnUyeEkle.Click += new System.EventHandler(this._btnUyeEkle_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.ImageIndex = 4;
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kitaplar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._dbGridKitaplar);
            this.groupBox2.Location = new System.Drawing.Point(6, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(781, 300);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitaplar";
            // 
            // _dbGridKitaplar
            // 
            this._dbGridKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dbGridKitaplar.Location = new System.Drawing.Point(6, 19);
            this._dbGridKitaplar.Name = "_dbGridKitaplar";
            this._dbGridKitaplar.Size = new System.Drawing.Size(770, 281);
            this._dbGridKitaplar.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._lblAdresNo);
            this.groupBox3.Controls.Add(this._cmbKutuphaneAdres);
            this.groupBox3.Controls.Add(this._txtKutuphaneAdi);
            this.groupBox3.Controls.Add(this._btnKutuphaneEke);
            this.groupBox3.Controls.Add(this._txtKitapAdi);
            this.groupBox3.Controls.Add(this._btnKitapAra);
            this.groupBox3.Controls.Add(this._btnKitapDuzelt);
            this.groupBox3.Controls.Add(this._btnKitapSil);
            this.groupBox3.Controls.Add(this._btnKitapEkle);
            this.groupBox3.Location = new System.Drawing.Point(6, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(778, 70);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İşlemler";
            // 
            // _lblAdresNo
            // 
            this._lblAdresNo.AutoSize = true;
            this._lblAdresNo.Location = new System.Drawing.Point(457, 54);
            this._lblAdresNo.Name = "_lblAdresNo";
            this._lblAdresNo.Size = new System.Drawing.Size(35, 13);
            this._lblAdresNo.TabIndex = 31;
            this._lblAdresNo.Text = "label1";
            this._lblAdresNo.Visible = false;
            // 
            // _cmbKutuphaneAdres
            // 
            this._cmbKutuphaneAdres.FormattingEnabled = true;
            this._cmbKutuphaneAdres.Location = new System.Drawing.Point(329, 36);
            this._cmbKutuphaneAdres.Name = "_cmbKutuphaneAdres";
            this._cmbKutuphaneAdres.Size = new System.Drawing.Size(121, 21);
            this._cmbKutuphaneAdres.TabIndex = 30;
            this._cmbKutuphaneAdres.SelectedIndexChanged += new System.EventHandler(this._cmbKutuphaneAdres_SelectedIndexChanged);
            // 
            // _txtKutuphaneAdi
            // 
            this._txtKutuphaneAdi.Location = new System.Drawing.Point(329, 11);
            this._txtKutuphaneAdi.Name = "_txtKutuphaneAdi";
            this._txtKutuphaneAdi.Size = new System.Drawing.Size(121, 20);
            this._txtKutuphaneAdi.TabIndex = 8;
            // 
            // _btnKutuphaneEke
            // 
            this._btnKutuphaneEke.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this._btnKutuphaneEke.ImageIndex = 10;
            this._btnKutuphaneEke.ImageList = this.ımageList1;
            this._btnKutuphaneEke.Location = new System.Drawing.Point(456, 11);
            this._btnKutuphaneEke.Name = "_btnKutuphaneEke";
            this._btnKutuphaneEke.Size = new System.Drawing.Size(142, 46);
            this._btnKutuphaneEke.TabIndex = 7;
            this._btnKutuphaneEke.Text = "Kütüphane Ekle";
            this._btnKutuphaneEke.UseVisualStyleBackColor = true;
            this._btnKutuphaneEke.Click += new System.EventHandler(this._btnKutuphaneEke_Click);
            // 
            // _txtKitapAdi
            // 
            this._txtKitapAdi.Location = new System.Drawing.Point(644, 9);
            this._txtKitapAdi.Name = "_txtKitapAdi";
            this._txtKitapAdi.Size = new System.Drawing.Size(128, 20);
            this._txtKitapAdi.TabIndex = 5;
            // 
            // _btnKitapAra
            // 
            this._btnKitapAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnKitapAra.ImageIndex = 8;
            this._btnKitapAra.ImageList = this.ımageList1;
            this._btnKitapAra.Location = new System.Drawing.Point(644, 31);
            this._btnKitapAra.Name = "_btnKitapAra";
            this._btnKitapAra.Size = new System.Drawing.Size(128, 23);
            this._btnKitapAra.TabIndex = 4;
            this._btnKitapAra.Text = "Ara";
            this._btnKitapAra.UseVisualStyleBackColor = true;
            // 
            // _btnKitapDuzelt
            // 
            this._btnKitapDuzelt.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this._btnKitapDuzelt.ImageIndex = 10;
            this._btnKitapDuzelt.ImageList = this.ımageList1;
            this._btnKitapDuzelt.Location = new System.Drawing.Point(203, 16);
            this._btnKitapDuzelt.Name = "_btnKitapDuzelt";
            this._btnKitapDuzelt.Size = new System.Drawing.Size(97, 39);
            this._btnKitapDuzelt.TabIndex = 3;
            this._btnKitapDuzelt.Text = "Düzelt";
            this._btnKitapDuzelt.UseVisualStyleBackColor = true;
            // 
            // _btnKitapSil
            // 
            this._btnKitapSil.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this._btnKitapSil.ImageIndex = 12;
            this._btnKitapSil.ImageList = this.ımageList1;
            this._btnKitapSil.Location = new System.Drawing.Point(114, 16);
            this._btnKitapSil.Name = "_btnKitapSil";
            this._btnKitapSil.Size = new System.Drawing.Size(83, 39);
            this._btnKitapSil.TabIndex = 1;
            this._btnKitapSil.Text = "Sil";
            this._btnKitapSil.UseVisualStyleBackColor = true;
            // 
            // _btnKitapEkle
            // 
            this._btnKitapEkle.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this._btnKitapEkle.ImageIndex = 11;
            this._btnKitapEkle.ImageList = this.ımageList1;
            this._btnKitapEkle.Location = new System.Drawing.Point(8, 16);
            this._btnKitapEkle.Name = "_btnKitapEkle";
            this._btnKitapEkle.Size = new System.Drawing.Size(100, 39);
            this._btnKitapEkle.TabIndex = 2;
            this._btnKitapEkle.Text = "Ekle";
            this._btnKitapEkle.UseVisualStyleBackColor = true;
            this._btnKitapEkle.Click += new System.EventHandler(this._btnKitapEkle_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.ImageIndex = 1;
            this.tabPage3.Location = new System.Drawing.Point(4, 37);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 385);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Yazarlar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this._dbGridYazarlar);
            this.groupBox4.Location = new System.Drawing.Point(6, 71);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(781, 309);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Yazarlar";
            // 
            // _dbGridYazarlar
            // 
            this._dbGridYazarlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dbGridYazarlar.Location = new System.Drawing.Point(6, 19);
            this._dbGridYazarlar.Name = "_dbGridYazarlar";
            this._dbGridYazarlar.Size = new System.Drawing.Size(770, 281);
            this._dbGridYazarlar.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this._txtYazarAdi);
            this.groupBox5.Controls.Add(this._btnYazarAra);
            this.groupBox5.Controls.Add(this._btnYazarDuzelt);
            this.groupBox5.Controls.Add(this._btnYazarSil);
            this.groupBox5.Controls.Add(this._btnYazrEkle);
            this.groupBox5.Location = new System.Drawing.Point(6, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(778, 61);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "İşlemler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yazar Adi";
            // 
            // _txtYazarAdi
            // 
            this._txtYazarAdi.Location = new System.Drawing.Point(582, 34);
            this._txtYazarAdi.Name = "_txtYazarAdi";
            this._txtYazarAdi.Size = new System.Drawing.Size(100, 20);
            this._txtYazarAdi.TabIndex = 5;
            // 
            // _btnYazarAra
            // 
            this._btnYazarAra.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this._btnYazarAra.ImageIndex = 8;
            this._btnYazarAra.ImageList = this.ımageList1;
            this._btnYazarAra.Location = new System.Drawing.Point(688, 15);
            this._btnYazarAra.Name = "_btnYazarAra";
            this._btnYazarAra.Size = new System.Drawing.Size(84, 39);
            this._btnYazarAra.TabIndex = 4;
            this._btnYazarAra.Text = "Ara";
            this._btnYazarAra.UseVisualStyleBackColor = true;
            // 
            // _btnYazarDuzelt
            // 
            this._btnYazarDuzelt.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this._btnYazarDuzelt.ImageIndex = 10;
            this._btnYazarDuzelt.ImageList = this.ımageList1;
            this._btnYazarDuzelt.Location = new System.Drawing.Point(216, 16);
            this._btnYazarDuzelt.Name = "_btnYazarDuzelt";
            this._btnYazarDuzelt.Size = new System.Drawing.Size(107, 39);
            this._btnYazarDuzelt.TabIndex = 3;
            this._btnYazarDuzelt.Text = "Düzelt";
            this._btnYazarDuzelt.UseVisualStyleBackColor = true;
            // 
            // _btnYazarSil
            // 
            this._btnYazarSil.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this._btnYazarSil.ImageIndex = 12;
            this._btnYazarSil.ImageList = this.ımageList1;
            this._btnYazarSil.Location = new System.Drawing.Point(114, 16);
            this._btnYazarSil.Name = "_btnYazarSil";
            this._btnYazarSil.Size = new System.Drawing.Size(96, 39);
            this._btnYazarSil.TabIndex = 1;
            this._btnYazarSil.Text = "Sil";
            this._btnYazarSil.UseVisualStyleBackColor = true;
            // 
            // _btnYazrEkle
            // 
            this._btnYazrEkle.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this._btnYazrEkle.ImageIndex = 11;
            this._btnYazrEkle.ImageList = this.ımageList1;
            this._btnYazrEkle.Location = new System.Drawing.Point(8, 16);
            this._btnYazrEkle.Name = "_btnYazrEkle";
            this._btnYazrEkle.Size = new System.Drawing.Size(100, 39);
            this._btnYazrEkle.TabIndex = 2;
            this._btnYazrEkle.Text = "Ekle";
            this._btnYazrEkle.UseVisualStyleBackColor = true;
            this._btnYazrEkle.Click += new System.EventHandler(this._btnYazrEkle_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this._btnBaglantiAc);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.groupBox7);
            this.tabPage4.ImageIndex = 0;
            this.tabPage4.Location = new System.Drawing.Point(4, 37);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 385);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Kategori";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Çevrımdışı";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _btnBaglantiAc
            // 
            this._btnBaglantiAc.Location = new System.Drawing.Point(36, 14);
            this._btnBaglantiAc.Name = "_btnBaglantiAc";
            this._btnBaglantiAc.Size = new System.Drawing.Size(75, 23);
            this._btnBaglantiAc.TabIndex = 22;
            this._btnBaglantiAc.Text = "Baglan";
            this._btnBaglantiAc.UseVisualStyleBackColor = true;
            this._btnBaglantiAc.Click += new System.EventHandler(this._btnBaglantiAc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Image = global::Kutuphane.Properties.Resources.paste;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(308, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 0, 13, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "     Kategori Ekle";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox8);
            this.groupBox7.Controls.Add(this._dbGridKategoriler);
            this.groupBox7.Controls.Add(this.groupBox6);
            this.groupBox7.Location = new System.Drawing.Point(8, 62);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(776, 315);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Kategori Bilgileri";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this._txtKategoriEkle);
            this.groupBox8.Location = new System.Drawing.Point(13, 30);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(369, 58);
            this.groupBox8.TabIndex = 24;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Kategori Bilgisi/Adı";
            // 
            // _txtKategoriEkle
            // 
            this._txtKategoriEkle.Location = new System.Drawing.Point(15, 26);
            this._txtKategoriEkle.Name = "_txtKategoriEkle";
            this._txtKategoriEkle.Size = new System.Drawing.Size(318, 20);
            this._txtKategoriEkle.TabIndex = 9;
            // 
            // _dbGridKategoriler
            // 
            this._dbGridKategoriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dbGridKategoriler.Location = new System.Drawing.Point(413, 30);
            this._dbGridKategoriler.Name = "_dbGridKategoriler";
            this._dbGridKategoriler.Size = new System.Drawing.Size(341, 265);
            this._dbGridKategoriler.TabIndex = 23;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this._btnKitapTemizle);
            this.groupBox6.Controls.Add(this._btnKategoriEkle);
            this.groupBox6.Location = new System.Drawing.Point(13, 94);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(369, 58);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "İşlemler";
            // 
            // _btnKitapTemizle
            // 
            this._btnKitapTemizle.Image = global::Kutuphane.Properties.Resources.delete;
            this._btnKitapTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnKitapTemizle.Location = new System.Drawing.Point(198, 16);
            this._btnKitapTemizle.Name = "_btnKitapTemizle";
            this._btnKitapTemizle.Size = new System.Drawing.Size(161, 40);
            this._btnKitapTemizle.TabIndex = 1;
            this._btnKitapTemizle.Text = "Kategori Sil";
            this._btnKitapTemizle.UseVisualStyleBackColor = true;
            // 
            // _btnKategoriEkle
            // 
            this._btnKategoriEkle.Image = global::Kutuphane.Properties.Resources.add;
            this._btnKategoriEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnKategoriEkle.Location = new System.Drawing.Point(19, 15);
            this._btnKategoriEkle.Name = "_btnKategoriEkle";
            this._btnKategoriEkle.Size = new System.Drawing.Size(162, 40);
            this._btnKategoriEkle.TabIndex = 0;
            this._btnKategoriEkle.Text = "Kategori Ekle";
            this._btnKategoriEkle.UseVisualStyleBackColor = true;
            this._btnKategoriEkle.Click += new System.EventHandler(this._btnKategoriEkle_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this._lbladresId);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.groupBox9);
            this.tabPage5.ImageIndex = 2;
            this.tabPage5.Location = new System.Drawing.Point(4, 37);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(792, 385);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "YayınEvi";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // _lbladresId
            // 
            this._lbladresId.AutoSize = true;
            this._lbladresId.Location = new System.Drawing.Point(743, 35);
            this._lbladresId.Name = "_lbladresId";
            this._lbladresId.Size = new System.Drawing.Size(41, 13);
            this._lbladresId.TabIndex = 24;
            this._lbladresId.Text = "label12";
            this._lbladresId.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Image = global::Kutuphane.Properties.Resources.paste;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(308, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 0, 13, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 29);
            this.label5.TabIndex = 23;
            this.label5.Text = "     YayınEvi Ekle";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.groupBox10);
            this.groupBox9.Controls.Add(this._dbGridYayinEvleri);
            this.groupBox9.Controls.Add(this.groupBox11);
            this.groupBox9.Location = new System.Drawing.Point(8, 51);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(776, 315);
            this.groupBox9.TabIndex = 22;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Yayın Evleri";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label7);
            this.groupBox10.Controls.Add(this.label6);
            this.groupBox10.Controls.Add(this._cmbAdresBilgisi);
            this.groupBox10.Controls.Add(this._txtYayinEviAdi);
            this.groupBox10.Location = new System.Drawing.Point(16, 19);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(387, 80);
            this.groupBox10.TabIndex = 24;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Yayın Evi/Bilgiler";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Adres Bilgisi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = " Adı";
            // 
            // _cmbAdresBilgisi
            // 
            this._cmbAdresBilgisi.FormattingEnabled = true;
            this._cmbAdresBilgisi.Location = new System.Drawing.Point(236, 45);
            this._cmbAdresBilgisi.Name = "_cmbAdresBilgisi";
            this._cmbAdresBilgisi.Size = new System.Drawing.Size(145, 21);
            this._cmbAdresBilgisi.TabIndex = 29;
            this._cmbAdresBilgisi.SelectedIndexChanged += new System.EventHandler(this._cmbAdresBilgisi_SelectedIndexChanged);
            // 
            // _txtYayinEviAdi
            // 
            this._txtYayinEviAdi.Location = new System.Drawing.Point(6, 46);
            this._txtYayinEviAdi.Name = "_txtYayinEviAdi";
            this._txtYayinEviAdi.Size = new System.Drawing.Size(210, 20);
            this._txtYayinEviAdi.TabIndex = 28;
            // 
            // _dbGridYayinEvleri
            // 
            this._dbGridYayinEvleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dbGridYayinEvleri.Location = new System.Drawing.Point(13, 106);
            this._dbGridYayinEvleri.Name = "_dbGridYayinEvleri";
            this._dbGridYayinEvleri.Size = new System.Drawing.Size(741, 189);
            this._dbGridYayinEvleri.TabIndex = 23;
            this._dbGridYayinEvleri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dbGridYayinEvleri_CellClick);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this._btnYayinEviSil);
            this.groupBox11.Controls.Add(this._btnYayinEviKaydet);
            this.groupBox11.Location = new System.Drawing.Point(413, 19);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(341, 81);
            this.groupBox11.TabIndex = 22;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "İşlemler";
            // 
            // _btnYayinEviSil
            // 
            this._btnYayinEviSil.Image = global::Kutuphane.Properties.Resources.delete;
            this._btnYayinEviSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnYayinEviSil.Location = new System.Drawing.Point(196, 22);
            this._btnYayinEviSil.Name = "_btnYayinEviSil";
            this._btnYayinEviSil.Size = new System.Drawing.Size(127, 40);
            this._btnYayinEviSil.TabIndex = 1;
            this._btnYayinEviSil.Text = "YayınEvi Sil";
            this._btnYayinEviSil.UseVisualStyleBackColor = true;
            this._btnYayinEviSil.Click += new System.EventHandler(this._btnYayinEviSil_Click);
            // 
            // _btnYayinEviKaydet
            // 
            this._btnYayinEviKaydet.Image = global::Kutuphane.Properties.Resources.add;
            this._btnYayinEviKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnYayinEviKaydet.Location = new System.Drawing.Point(19, 22);
            this._btnYayinEviKaydet.Name = "_btnYayinEviKaydet";
            this._btnYayinEviKaydet.Size = new System.Drawing.Size(162, 40);
            this._btnYayinEviKaydet.TabIndex = 0;
            this._btnYayinEviKaydet.Text = "Yayınevi Ekle";
            this._btnYayinEviKaydet.UseVisualStyleBackColor = true;
            this._btnYayinEviKaydet.Click += new System.EventHandler(this._btnYayinEviKaydet_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.groupBox13);
            this.tabPage6.Controls.Add(this.groupBox12);
            this.tabPage6.ImageIndex = 3;
            this.tabPage6.Location = new System.Drawing.Point(4, 37);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(792, 385);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "EmananetKitaplar";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.dataGridView2);
            this.groupBox13.Location = new System.Drawing.Point(20, 114);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(750, 263);
            this.groupBox13.TabIndex = 1;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Emanet Listesi";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(738, 230);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.groupBox14);
            this.groupBox12.Controls.Add(this.label11);
            this.groupBox12.Controls.Add(this.label10);
            this.groupBox12.Controls.Add(this.label9);
            this.groupBox12.Controls.Add(this.label8);
            this.groupBox12.Controls.Add(this._dtepicturTelsimTa);
            this.groupBox12.Controls.Add(this._dtepicturVerilisTa);
            this.groupBox12.Controls.Add(this._cmbVerilenKitap);
            this.groupBox12.Controls.Add(this._cmbKitapveruye);
            this.groupBox12.Location = new System.Drawing.Point(20, 14);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(750, 94);
            this.groupBox12.TabIndex = 0;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Emanet ver";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this._btnEmanetTmamla);
            this.groupBox14.Controls.Add(this._btnEmanetKaydet);
            this.groupBox14.Location = new System.Drawing.Point(481, 19);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(263, 64);
            this.groupBox14.TabIndex = 16;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "İşlemler";
            // 
            // _btnEmanetTmamla
            // 
            this._btnEmanetTmamla.Image = global::Kutuphane.Properties.Resources.db_download;
            this._btnEmanetTmamla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnEmanetTmamla.Location = new System.Drawing.Point(137, 19);
            this._btnEmanetTmamla.Name = "_btnEmanetTmamla";
            this._btnEmanetTmamla.Size = new System.Drawing.Size(120, 39);
            this._btnEmanetTmamla.TabIndex = 1;
            this._btnEmanetTmamla.Text = "Geri Al";
            this._btnEmanetTmamla.UseVisualStyleBackColor = true;
            // 
            // _btnEmanetKaydet
            // 
            this._btnEmanetKaydet.Image = global::Kutuphane.Properties.Resources.door;
            this._btnEmanetKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnEmanetKaydet.Location = new System.Drawing.Point(15, 19);
            this._btnEmanetKaydet.Name = "_btnEmanetKaydet";
            this._btnEmanetKaydet.Size = new System.Drawing.Size(116, 39);
            this._btnEmanetKaydet.TabIndex = 0;
            this._btnEmanetKaydet.Text = "Emanet Ver";
            this._btnEmanetKaydet.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(308, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Teslim Tarihi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(308, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Veriliş Tarihi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(155, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Verilen Kitap";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Kitap verilecek üye";
            // 
            // _dtepicturTelsimTa
            // 
            this._dtepicturTelsimTa.Enabled = false;
            this._dtepicturTelsimTa.Location = new System.Drawing.Point(311, 24);
            this._dtepicturTelsimTa.Name = "_dtepicturTelsimTa";
            this._dtepicturTelsimTa.Size = new System.Drawing.Size(156, 20);
            this._dtepicturTelsimTa.TabIndex = 4;
            // 
            // _dtepicturVerilisTa
            // 
            this._dtepicturVerilisTa.Location = new System.Drawing.Point(311, 67);
            this._dtepicturVerilisTa.Name = "_dtepicturVerilisTa";
            this._dtepicturVerilisTa.Size = new System.Drawing.Size(156, 20);
            this._dtepicturVerilisTa.TabIndex = 3;
            // 
            // _cmbVerilenKitap
            // 
            this._cmbVerilenKitap.FormattingEnabled = true;
            this._cmbVerilenKitap.Location = new System.Drawing.Point(158, 46);
            this._cmbVerilenKitap.Name = "_cmbVerilenKitap";
            this._cmbVerilenKitap.Size = new System.Drawing.Size(133, 21);
            this._cmbVerilenKitap.TabIndex = 1;
            // 
            // _cmbKitapveruye
            // 
            this._cmbKitapveruye.FormattingEnabled = true;
            this._cmbKitapveruye.Location = new System.Drawing.Point(21, 46);
            this._cmbKitapveruye.Name = "_cmbKitapveruye";
            this._cmbKitapveruye.Size = new System.Drawing.Size(121, 21);
            this._cmbKitapveruye.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.düzenToolStripMenuItem,
            this.araçlarToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.açToolStripMenuItem,
            this.toolStripSeparator,
            this.kaydetToolStripMenuItem,
            this.farklıKaydetToolStripMenuItem,
            this.toolStripSeparator1,
            this.yazdırToolStripMenuItem,
            this.baskıÖnizlemeToolStripMenuItem,
            this.toolStripSeparator2,
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "&Dosya";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yeniToolStripMenuItem.Image")));
            this.yeniToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.yeniToolStripMenuItem.Text = "Y&eni";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("açToolStripMenuItem.Image")));
            this.açToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.açToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.açToolStripMenuItem.Text = "&Aç";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(151, 6);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kaydetToolStripMenuItem.Image")));
            this.kaydetToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.kaydetToolStripMenuItem.Text = "&Kaydet";
            // 
            // farklıKaydetToolStripMenuItem
            // 
            this.farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
            this.farklıKaydetToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.farklıKaydetToolStripMenuItem.Text = "&Farklı Kaydet";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // yazdırToolStripMenuItem
            // 
            this.yazdırToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yazdırToolStripMenuItem.Image")));
            this.yazdırToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            this.yazdırToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.yazdırToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.yazdırToolStripMenuItem.Text = "Y&azdır";
            // 
            // baskıÖnizlemeToolStripMenuItem
            // 
            this.baskıÖnizlemeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("baskıÖnizlemeToolStripMenuItem.Image")));
            this.baskıÖnizlemeToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.baskıÖnizlemeToolStripMenuItem.Name = "baskıÖnizlemeToolStripMenuItem";
            this.baskıÖnizlemeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.baskıÖnizlemeToolStripMenuItem.Text = "&Baskı Önizleme";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(151, 6);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.çıkışToolStripMenuItem.Text = "Çı&kış";
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geriAlToolStripMenuItem,
            this.yineleToolStripMenuItem,
            this.toolStripSeparator3,
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapıştırToolStripMenuItem,
            this.toolStripSeparator4,
            this.tümünüSeçToolStripMenuItem});
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.düzenToolStripMenuItem.Text = "D&üzen";
            // 
            // geriAlToolStripMenuItem
            // 
            this.geriAlToolStripMenuItem.Name = "geriAlToolStripMenuItem";
            this.geriAlToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.geriAlToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.geriAlToolStripMenuItem.Text = "&Geri Al";
            // 
            // yineleToolStripMenuItem
            // 
            this.yineleToolStripMenuItem.Name = "yineleToolStripMenuItem";
            this.yineleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.yineleToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.yineleToolStripMenuItem.Text = "Yi&nele";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(155, 6);
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kesToolStripMenuItem.Image")));
            this.kesToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.kesToolStripMenuItem.Text = "&Kes";
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kopyalaToolStripMenuItem.Image")));
            this.kopyalaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.kopyalaToolStripMenuItem.Text = "K&opyala";
            // 
            // yapıştırToolStripMenuItem
            // 
            this.yapıştırToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yapıştırToolStripMenuItem.Image")));
            this.yapıştırToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            this.yapıştırToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.yapıştırToolStripMenuItem.Text = "&Yapıştır";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(155, 6);
            // 
            // tümünüSeçToolStripMenuItem
            // 
            this.tümünüSeçToolStripMenuItem.Name = "tümünüSeçToolStripMenuItem";
            this.tümünüSeçToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.tümünüSeçToolStripMenuItem.Text = "&Tümünü Seç";
            // 
            // araçlarToolStripMenuItem
            // 
            this.araçlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.özelleştirToolStripMenuItem,
            this.seçeneklerToolStripMenuItem});
            this.araçlarToolStripMenuItem.Name = "araçlarToolStripMenuItem";
            this.araçlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.araçlarToolStripMenuItem.Text = "&Araçlar";
            // 
            // özelleştirToolStripMenuItem
            // 
            this.özelleştirToolStripMenuItem.Name = "özelleştirToolStripMenuItem";
            this.özelleştirToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.özelleştirToolStripMenuItem.Text = "&Özelleştir";
            // 
            // seçeneklerToolStripMenuItem
            // 
            this.seçeneklerToolStripMenuItem.Name = "seçeneklerToolStripMenuItem";
            this.seçeneklerToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.seçeneklerToolStripMenuItem.Text = "&Seçenekler";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.içindekilerToolStripMenuItem,
            this.dizinToolStripMenuItem,
            this.araToolStripMenuItem,
            this.toolStripSeparator5,
            this.hakkındaToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "&Yardım";
            // 
            // içindekilerToolStripMenuItem
            // 
            this.içindekilerToolStripMenuItem.Name = "içindekilerToolStripMenuItem";
            this.içindekilerToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.içindekilerToolStripMenuItem.Text = "İçi&ndekiler";
            // 
            // dizinToolStripMenuItem
            // 
            this.dizinToolStripMenuItem.Name = "dizinToolStripMenuItem";
            this.dizinToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.dizinToolStripMenuItem.Text = "Di&zin";
            // 
            // araToolStripMenuItem
            // 
            this.araToolStripMenuItem.Name = "araToolStripMenuItem";
            this.araToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.araToolStripMenuItem.Text = "A&ra";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(130, 6);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.hakkındaToolStripMenuItem.Text = "&Hakkında...";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kutuphane";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this._uyeler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dbGridUyeler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dbGridKitaplar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dbGridYazarlar)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dbGridKategoriler)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dbGridYayinEvleri)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farklıKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baskıÖnizlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yineleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tümünüSeçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem özelleştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçeneklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem içindekilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dizinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.GroupBox _uyeler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox _txtUyeAra;
        private System.Windows.Forms.Button _btnUyeAra;
        private System.Windows.Forms.Button _btnUyeDuzelt;
        private System.Windows.Forms.Button _btnUyesiSil;
        private System.Windows.Forms.Button _btnUyeEkle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox _txtKitapAdi;
        private System.Windows.Forms.Button _btnKitapAra;
        private System.Windows.Forms.Button _btnKitapDuzelt;
        private System.Windows.Forms.Button _btnKitapSil;
        private System.Windows.Forms.Button _btnKitapEkle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView _dbGridYazarlar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtYazarAdi;
        private System.Windows.Forms.Button _btnYazarAra;
        private System.Windows.Forms.Button _btnYazarDuzelt;
        private System.Windows.Forms.Button _btnYazarSil;
        private System.Windows.Forms.Button _btnYazrEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox _txtKategoriEkle;
        private System.Windows.Forms.DataGridView _dbGridKategoriler;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button _btnKitapTemizle;
        private System.Windows.Forms.Button _btnKategoriEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _txtYayinEviAdi;
        private System.Windows.Forms.DataGridView _dbGridYayinEvleri;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button _btnYayinEviSil;
        private System.Windows.Forms.Button _btnYayinEviKaydet;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker _dtepicturTelsimTa;
        private System.Windows.Forms.DateTimePicker _dtepicturVerilisTa;
        private System.Windows.Forms.ComboBox _cmbVerilenKitap;
        private System.Windows.Forms.ComboBox _cmbKitapveruye;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Button _btnEmanetTmamla;
        private System.Windows.Forms.Button _btnEmanetKaydet;
        private System.Windows.Forms.Button _btnAdresEkle;
        public System.Windows.Forms.ComboBox _cmbAdresBilgisi;
        private System.Windows.Forms.Label _lbladresId;
        private System.Windows.Forms.Button _btnBaglantiAc;
        public System.Windows.Forms.ComboBox _cmbKutuphaneAdres;
        private System.Windows.Forms.TextBox _txtKutuphaneAdi;
        private System.Windows.Forms.Button _btnKutuphaneEke;
        private System.Windows.Forms.Label _lblAdresNo;
        public System.Windows.Forms.DataGridView _dbGridKitaplar;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView _dbGridUyeler;
    }
}

