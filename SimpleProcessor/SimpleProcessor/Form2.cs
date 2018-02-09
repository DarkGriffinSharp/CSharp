using SimpleProcessor.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleProcessor
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown, mouseHover;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 323;
                mouseY = MousePosition.Y - 15;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void closeHover(object sender, EventArgs e)
        {
            mouseHover = true;
            if (mouseHover)
            {
                closeButton.Image = Resources.closedq;
            }
        }

        private void closeLeave(object sender, EventArgs e)
        {
            mouseHover = false;
            if (mouseHover == false)
            {
                closeButton.Image = Resources.closed;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var gpuName = SystemInfo.HWID.GetGpuName();
            gpunameTxt.Text = gpuName;

            var hwid = SystemInfo.HWID.GetHardwareID();
            hwidTxt.Text = hwid;

            var macAdress = SystemInfo.HWID.GetMacAddress();
            macTxt.Text = macAdress;

            string externalIP = new System.Net.WebClient().DownloadString("http://icanhazip.com");
            extaddressTxt.Text = externalIP;

            var mainBoard = SystemInfo.HWID.GetMainboardIdentifier();
            mainboardTxt.Text = mainBoard;

            var id = new ManagementObjectSearcher("Select ProcessorID From Win32_processor");
            ManagementObjectCollection idList = id.Get();
            string cpuid = "";
            foreach (ManagementObject mo in idList)
            {
                cpuid = mo["ProcessorID"].ToString();
                break;
            }
            processorTxt.Text = cpuid;
        }

        private void close(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void minimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
