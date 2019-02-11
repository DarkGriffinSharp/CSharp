using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paintology
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int pin = 0;
        int colorPickerPin = 0;

        #region HareketEtme

        private Point MouseDownLocation;
        private Point MouseDownLocation1;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void toolPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && toolPanel.Dock == DockStyle.None)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void toolPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && toolPanel.Dock == DockStyle.None)
            {
                toolPanel.Left = e.X + toolPanel.Left - MouseDownLocation.X;
                toolPanel.Top = e.Y + toolPanel.Top - MouseDownLocation.Y;
            }
        }

        private void colorPicker_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && colorPickerPin == 1)
            {
                MouseDownLocation1 = e.Location;
            }
        }

        private void colorPicker_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && colorPickerPin == 1)
            {
                colorPicker.Left = e.X + colorPicker.Left - MouseDownLocation1.X;
                colorPicker.Top = e.Y + colorPicker.Top - MouseDownLocation1.Y;
            }
        }
        #endregion

        private void closeBox_MouseHover(object sender, EventArgs e)
        {
            closeBox.Image = Properties.Resources.close_hover;
        }

        private void closeBox_MouseLeave(object sender, EventArgs e)
        {
            closeBox.Image = Properties.Resources.close_leave;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int buyukluk = panel1.Size.Width;
            closeBox.Location = new Point(buyukluk - 37, 4);
            colorPicker.Location = new Point(59, 554);
        }

        private void closeBox_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pinBox_Click(object sender, EventArgs e)
        {
            if (pin == 0)
            {
                pin = 1;
                pinBox.Image = Properties.Resources.pin;
                toolPanel.Dock = DockStyle.None;
            }
            else
            {
                pin = 0;
                pinBox.Image = Properties.Resources.push_pin;
                toolPanel.Dock = DockStyle.Left;
            }
        }

        private void pinBox_MouseHover(object sender, EventArgs e)
        {
            if (pin == 0)
            {
                pinBox.Image = Properties.Resources.pin;
            }
            else
            {
                pinBox.Image = Properties.Resources.push_pin;
            }
        }

        private void pinBox_MouseLeave(object sender, EventArgs e)
        {
            if (pin != 1)
            {
                pinBox.Image = Properties.Resources.push_pin;
            }
            else
            {
                pinBox.Image = Properties.Resources.pin;
            }
        }

        private void closeTool_Click(object sender, EventArgs e)
        {
            toolPanel.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            colorPicker.Hide();
        }

        private void colorPin_Click(object sender, EventArgs e)
        {
            if (colorPickerPin == 0)
            {
                colorPickerPin = 1;
                colorPin.Image = Properties.Resources.pin;
            }
            else
            {
                colorPickerPin = 0;
                colorPin.Image = Properties.Resources.push_pin;
            }
        }

        private void colorPin_MouseHover(object sender, EventArgs e)
        {
            if (colorPickerPin == 0)
            {
                colorPin.Image = Properties.Resources.pin;
            }
            else
            {
                colorPin.Image = Properties.Resources.push_pin;
            }
        }

        private void colorPin_MouseLeave(object sender, EventArgs e)
        {
            if (colorPickerPin != 1)
            {
                colorPin.Image = Properties.Resources.push_pin;
            }
            else
            {
                colorPin.Image = Properties.Resources.pin;
            }
        }

        private void openFolder_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "image files (*.png)|*.png|" +
                "image files (*.jpg)|*.jpg";
            ofd.ShowDialog();
        }
    }
}
