using HtmlAgilityPack;
using RSSFeed.Properties;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.ServiceModel.Syndication;
using System.Windows.Forms;
using System.Xml;

namespace RSSFeed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Tanımlar
        public string url = string.Empty;
        public XmlReader reader;
        public SyndicationFeed feed;
        public bool kontrol = true;
        public static string title = string.Empty;
        public static string description = string.Empty;
        #endregion

        #region HareketEtme

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #region Kapatma
        private void closeBtn_MouseHover(object sender, EventArgs e)
        {
            closeBtn.BackgroundImage = Resources.exit_red;
        }

        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.BackgroundImage = Resources.exit_black;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        #endregion

        public void RssFeed(string url)
        {
            try
            {
                reader = XmlReader.Create(url);
                feed = SyndicationFeed.Load(reader);
                reader.Close();

                baslikList.Items.Clear();
                foreach (SyndicationItem item in feed.Items)
                {
                    title = item.Title.Text;
                    while (title.Contains("&#39;"))
                    {
                        int index = title.IndexOf("&#39;");
                        string temizString = (index < 0)
                            ? title
                            : title = title.Remove(index, "&#39;".Length);
                    }

                    while (title.Contains("&quot;"))
                    {
                        int index = title.IndexOf("&quot;");
                        string temizString = (index < 0)
                            ? title
                            : title = title.Remove(index, "&quot;".Length);
                    }

                    this.url = url;
                    baslikList.Items.Add(title);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void BosaltBiziSkadi()
        {
            aciklamaText.Clear();
            pictureBox1.Image = null;
        }

        private void logo_MouseDown(object sender, MouseEventArgs e)
        {
            Point p = new Point(0, 33);
            if (e.Button == MouseButtons.Left)
                menu.Show(PointToScreen(p));
        }

        private void logo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Environment.Exit(0);
        }

        private void sonDakikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BosaltBiziSkadi();
            RssFeed("https://www.cnnturk.com/feed/rss/all/news");
        }

        private void türkiyeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BosaltBiziSkadi();
            RssFeed("https://www.cnnturk.com/feed/rss/turkiye/news");
        }

        private void kültürSanatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BosaltBiziSkadi();
            RssFeed("https://www.cnnturk.com/feed/rss/kultur-sanat/news");
        }

        private void bilimTeknolojiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BosaltBiziSkadi();
            RssFeed("https://www.cnnturk.com/feed/rss/bilim-teknoloji/news");
        }

        private void ekonomiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BosaltBiziSkadi();
            RssFeed("https://www.cnnturk.com/feed/rss/ekonomi/news");
        }

        private void sağlıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BosaltBiziSkadi();
            RssFeed("https://www.cnnturk.com/feed/rss/saglik/news");
        }

        private void seyahatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BosaltBiziSkadi();
            RssFeed("https://www.cnnturk.com/feed/rss/seyahat/news");
        }
        
        private void dünyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BosaltBiziSkadi();
            RssFeed("https://www.cnnturk.com/feed/rss/dunya/news");
        }

        private void baslikList_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            foreach (SyndicationItem item in feed.Items)
            {
                title = item.Title.Text;
                while (title.Contains("&#39;"))
                {
                    int index = title.IndexOf("&#39;");
                    string temizString = (index < 0)
                        ? title
                        : title = title.Remove(index, "&#39;".Length);
                }

                while (title.Contains("&quot;"))
                {
                    int index = title.IndexOf("&quot;");
                    string temizString = (index < 0)
                        ? title
                        : title = title.Remove(index, "&quot;".Length);
                }

                if (title == baslikList.SelectedItem.ToString())
                {
                    description = item.Summary.Text;

                    while (description.Contains("&#39;"))
                    {
                        int index = description.IndexOf("&#39;");
                        string temizString = (index < 0)
                            ? description
                            : description = description.Remove(index, "&#39;".Length);
                    }

                    while (description.Contains("&quot;"))
                    {
                        int index = description.IndexOf("&quot;");
                        string temizString = (index < 0)
                            ? description
                            : description = description.Remove(index, "&quot;".Length);
                    }

                    aciklamaText.Text = description;

                    aciklamaText.Text += "\n\nHaberin Tamamı=> " + item.Links[0].Uri;

                    HtmlAgilityPack.HtmlDocument doc = new HtmlWeb().Load(item.Links[0].Uri);
                    var rows = doc.DocumentNode.SelectNodes("//div[@href = '#test']");

                    foreach (var row in rows)
                    {
                        var cells = row.SelectNodes("//img[@class = 'img-responsive lazy']");
                        string[] title = cells[0].OuterHtml.Split('"');
                        //var valueRow = cells[2];

                        pictureBox1.Load(title[1]);
                    }
                }
            }
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}