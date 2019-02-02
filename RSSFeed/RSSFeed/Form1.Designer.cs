namespace RSSFeed
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sonDakikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.türkiyeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dünyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kültürSanatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilimTeknolojiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekonomiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sağlıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seyahatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baslikGroup = new System.Windows.Forms.GroupBox();
            this.baslikList = new System.Windows.Forms.ListBox();
            this.icerikGroup = new System.Windows.Forms.GroupBox();
            this.aciklamaText = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.menu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.baslikGroup.SuspendLayout();
            this.icerikGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 32);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.BackgroundImage = global::RSSFeed.Properties.Resources.exit_black;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtn.Location = new System.Drawing.Point(746, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(32, 32);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 1;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            this.closeBtn.MouseHover += new System.EventHandler(this.closeBtn_MouseHover);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = global::RSSFeed.Properties.Resources.logo;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(32, 32);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.logo_MouseDoubleClick);
            this.logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.logo_MouseDown);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kapatToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(181, 70);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sonDakikaToolStripMenuItem,
            this.türkiyeToolStripMenuItem,
            this.dünyaToolStripMenuItem,
            this.kültürSanatToolStripMenuItem,
            this.bilimTeknolojiToolStripMenuItem,
            this.ekonomiToolStripMenuItem,
            this.sağlıkToolStripMenuItem,
            this.seyahatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 32);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sonDakikaToolStripMenuItem
            // 
            this.sonDakikaToolStripMenuItem.Name = "sonDakikaToolStripMenuItem";
            this.sonDakikaToolStripMenuItem.Size = new System.Drawing.Size(87, 21);
            this.sonDakikaToolStripMenuItem.Text = "Son Dakika";
            this.sonDakikaToolStripMenuItem.Click += new System.EventHandler(this.sonDakikaToolStripMenuItem_Click);
            // 
            // türkiyeToolStripMenuItem
            // 
            this.türkiyeToolStripMenuItem.Name = "türkiyeToolStripMenuItem";
            this.türkiyeToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
            this.türkiyeToolStripMenuItem.Text = "Türkiye";
            this.türkiyeToolStripMenuItem.Click += new System.EventHandler(this.türkiyeToolStripMenuItem_Click);
            // 
            // dünyaToolStripMenuItem
            // 
            this.dünyaToolStripMenuItem.Name = "dünyaToolStripMenuItem";
            this.dünyaToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.dünyaToolStripMenuItem.Text = "Dünya";
            this.dünyaToolStripMenuItem.Click += new System.EventHandler(this.dünyaToolStripMenuItem_Click);
            // 
            // kültürSanatToolStripMenuItem
            // 
            this.kültürSanatToolStripMenuItem.Name = "kültürSanatToolStripMenuItem";
            this.kültürSanatToolStripMenuItem.Size = new System.Drawing.Size(95, 21);
            this.kültürSanatToolStripMenuItem.Text = "Kültür Sanat";
            this.kültürSanatToolStripMenuItem.Click += new System.EventHandler(this.kültürSanatToolStripMenuItem_Click);
            // 
            // bilimTeknolojiToolStripMenuItem
            // 
            this.bilimTeknolojiToolStripMenuItem.Name = "bilimTeknolojiToolStripMenuItem";
            this.bilimTeknolojiToolStripMenuItem.Size = new System.Drawing.Size(106, 21);
            this.bilimTeknolojiToolStripMenuItem.Text = "Bilim Teknoloji";
            this.bilimTeknolojiToolStripMenuItem.Click += new System.EventHandler(this.bilimTeknolojiToolStripMenuItem_Click);
            // 
            // ekonomiToolStripMenuItem
            // 
            this.ekonomiToolStripMenuItem.Name = "ekonomiToolStripMenuItem";
            this.ekonomiToolStripMenuItem.Size = new System.Drawing.Size(73, 21);
            this.ekonomiToolStripMenuItem.Text = "Ekonomi";
            this.ekonomiToolStripMenuItem.Click += new System.EventHandler(this.ekonomiToolStripMenuItem_Click);
            // 
            // sağlıkToolStripMenuItem
            // 
            this.sağlıkToolStripMenuItem.Name = "sağlıkToolStripMenuItem";
            this.sağlıkToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.sağlıkToolStripMenuItem.Text = "Sağlık";
            this.sağlıkToolStripMenuItem.Click += new System.EventHandler(this.sağlıkToolStripMenuItem_Click);
            // 
            // seyahatToolStripMenuItem
            // 
            this.seyahatToolStripMenuItem.Name = "seyahatToolStripMenuItem";
            this.seyahatToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.seyahatToolStripMenuItem.Text = "Seyahat";
            this.seyahatToolStripMenuItem.Click += new System.EventHandler(this.seyahatToolStripMenuItem_Click);
            // 
            // baslikGroup
            // 
            this.baslikGroup.Controls.Add(this.baslikList);
            this.baslikGroup.Dock = System.Windows.Forms.DockStyle.Left;
            this.baslikGroup.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslikGroup.ForeColor = System.Drawing.Color.DarkRed;
            this.baslikGroup.Location = new System.Drawing.Point(0, 57);
            this.baslikGroup.Name = "baslikGroup";
            this.baslikGroup.Size = new System.Drawing.Size(274, 475);
            this.baslikGroup.TabIndex = 2;
            this.baslikGroup.TabStop = false;
            this.baslikGroup.Text = "Başlıklar";
            // 
            // baslikList
            // 
            this.baslikList.Dock = System.Windows.Forms.DockStyle.Left;
            this.baslikList.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslikList.FormattingEnabled = true;
            this.baslikList.HorizontalScrollbar = true;
            this.baslikList.ItemHeight = 18;
            this.baslikList.Location = new System.Drawing.Point(3, 18);
            this.baslikList.Name = "baslikList";
            this.baslikList.Size = new System.Drawing.Size(269, 454);
            this.baslikList.TabIndex = 0;
            this.baslikList.SelectedIndexChanged += new System.EventHandler(this.baslikList_SelectedIndexChanged);
            // 
            // icerikGroup
            // 
            this.icerikGroup.Controls.Add(this.aciklamaText);
            this.icerikGroup.Controls.Add(this.pictureBox1);
            this.icerikGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.icerikGroup.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.icerikGroup.ForeColor = System.Drawing.Color.DarkRed;
            this.icerikGroup.Location = new System.Drawing.Point(274, 57);
            this.icerikGroup.Name = "icerikGroup";
            this.icerikGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.icerikGroup.Size = new System.Drawing.Size(504, 475);
            this.icerikGroup.TabIndex = 3;
            this.icerikGroup.TabStop = false;
            this.icerikGroup.Text = "İçerikler";
            // 
            // aciklamaText
            // 
            this.aciklamaText.Dock = System.Windows.Forms.DockStyle.Top;
            this.aciklamaText.Location = new System.Drawing.Point(3, 258);
            this.aciklamaText.Name = "aciklamaText";
            this.aciklamaText.ReadOnly = true;
            this.aciklamaText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.aciklamaText.Size = new System.Drawing.Size(498, 214);
            this.aciklamaText.TabIndex = 1;
            this.aciklamaText.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(3, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(498, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 532);
            this.Controls.Add(this.icerikGroup);
            this.Controls.Add(this.baslikGroup);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.menu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.baslikGroup.ResumeLayout(false);
            this.icerikGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sonDakikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem türkiyeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dünyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kültürSanatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilimTeknolojiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekonomiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sağlıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seyahatToolStripMenuItem;
        private System.Windows.Forms.GroupBox baslikGroup;
        private System.Windows.Forms.ListBox baslikList;
        private System.Windows.Forms.GroupBox icerikGroup;
        private System.Windows.Forms.RichTextBox aciklamaText;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

