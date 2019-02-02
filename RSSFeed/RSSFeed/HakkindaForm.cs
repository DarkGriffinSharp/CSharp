using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSSFeed
{
    public partial class HakkindaForm : Form
    {
        public HakkindaForm()
        {
            InitializeComponent();
        }
        Random rand = new Random();

        private void randomTimer_Tick(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
