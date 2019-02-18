using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;

namespace Paintology
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listOfPoints = new ArrayList();
            kalemx = false;
            graph = CreateGraphics();

            foreach (FontFamily item in FontFamily.Families)
            {
                fonts.Items.Add(item.Name);
            }
        }

        #region Tanımlar
        Graphics graph;
        int colorPickerPin = 0;
        int returner;
        public Graphics g;
        ArrayList listOfPoints;
        bool kalemx;
        List<Point> points = new List<Point>();
        private List<Point> polygonPoints = new List<Point>();
        private int sayac = 0;
        Color renk;
        Pen kalem;
        #endregion

        #region Dikdortgen
        Rectangle dikdortgen;
        Point LocationXY;
        Point LocationX1Y1;
        bool isMouseDown = false;
        #endregion

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
                if (toolPanel.Location.X >= 0 && toolPanel.Location.Y >= 0)
                {
                    toolPanel.Left = e.X + toolPanel.Left - MouseDownLocation.X;

                    toolPanel.Top = e.Y + toolPanel.Top - MouseDownLocation.Y;
                }
                else
                {
                    toolPanel.Location = new Point(0, 40);
                    toolPanel.Dock = DockStyle.Left;
                }
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
            if (e.Button == MouseButtons.Left && colorPickerPin == 1 &&
                (colorPicker.Bounds.Width < this.Size.Width && colorPicker.Bounds.Height < this.Size.Height))
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
            colorPicker.Location = new Point(439, 3);
        }

        private void closeBox_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void closeTool_Click(object sender, EventArgs e)
        {
            toolPanel.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            colorPicker.Hide();
        }

        private void openFolder_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "images file";
            ofd.Filter = "*.png|*.png|" +
                "*.jpg|*.jpg";

            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Image bitMap = Image.FromFile(ofd.FileName);
                BackgroundImageLayout = ImageLayout.Center;
                BackgroundImage = bitMap;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            LocationXY = e.Location;
            switch (returner)
            {
                case 1:
                    Point p = new Point(e.X, e.Y);
                    listOfPoints.Add(p);
                    kalemx = true;
                    break;
                case 2:
                    dikdortgen = new Rectangle();
                    isMouseDown = true;
                    break;
                case 3:
                    isMouseDown = true;
                    break;
                case 4:
                    points.Add(new Point(e.X, e.Y));
                    break;
                case 5:
                    Brush b = new SolidBrush(renk);
                    graph.DrawString(stringAl.Text, 
                        new Font(fonts.SelectedItem.ToString(), kalinlikTrack.Value), 
                        b, e.Location);
                    break;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (returner)
            {
                case 1:
                    kalemx = false;
                    break;
                case 2:
                    LocationX1Y1 = e.Location;
                    isMouseDown = false;
                    break;
                case 3:
                    LocationX1Y1 = e.Location;
                    isMouseDown = false;
                    break;
                case 4:
                    ÜcgenOlusturma(sender, e);
                    if (polygonPoints.Count > 3)
                    {
                        polygonPoints.Clear();
                    }
                    break;
                case 5:

                    break;
            }
        }

        private void DrawLine(Point p1, Point p2)
        {
            Graphics G = this.CreateGraphics();
            G.DrawLine(kalem, p1, p2);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            kalem = new Pen(renk, kalinlikTrack.Value);
            if (e.Button == MouseButtons.Left)
            {
                g = CreateGraphics();
                Point points = new Point(e.X, e.Y);

                switch (returner)
                {
                    case 1:
                        if (kalemx == true)
                        {
                            if (listOfPoints.Count > 0)
                            {
                                g.DrawLine(kalem, (Point)listOfPoints[listOfPoints.Count - 1], points);
                                listOfPoints.Add(points);
                            }
                        }
                        break;
                    case 2:
                        if (isMouseDown == true)
                        {
                            Refresh();
                            LocationX1Y1 = e.Location;
                            dikdortgen.X = Math.Min(LocationXY.X, LocationX1Y1.X);
                            dikdortgen.Y = Math.Min(LocationXY.Y, LocationX1Y1.Y);
                            dikdortgen.Width = Math.Abs(LocationXY.X - LocationX1Y1.X);
                            dikdortgen.Height = Math.Abs(LocationXY.Y - LocationX1Y1.Y);
                            graph.DrawRectangle(kalem, dikdortgen);
                        }
                        break;
                    case 3:
                        if (isMouseDown == true)
                        {
                            Pen p = new Pen(Color.Red, 1);
                            dikdortgen = new Rectangle();
                            LocationX1Y1 = e.Location;
                            dikdortgen.X = Math.Min(LocationXY.X, LocationX1Y1.X);
                            dikdortgen.Y = Math.Min(LocationXY.Y, LocationX1Y1.Y);
                            dikdortgen.Width = Math.Abs(LocationXY.X - LocationX1Y1.X);
                            dikdortgen.Height = Math.Abs(LocationXY.Y - LocationX1Y1.Y);
                            Refresh();
                            graph.DrawEllipse(kalem, dikdortgen);
                        }
                        break;
                    case 5:
                        
                        break;
                }
            }
        }

        private void toolboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolPanel.Show();
        }

        private void colorpickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorPicker.Show();
        }

        private void Secim(object sender, EventArgs e)
        {
            PictureBox pb = (sender as PictureBox);
            string isim = pb.Name;

            switch (isim)
            {
                case "lineBox":
                    returner = 1;
                    FixedBox(returner, pb, rectangleBox, ellipseBox, triangleBox, leftArrowBox);
                    break;
                case "rectangleBox":
                    returner = 2;
                    FixedBox(returner, pb, lineBox, ellipseBox, triangleBox, leftArrowBox);
                    break;
                case "ellipseBox":
                    returner = 3;
                    FixedBox(returner, pb, rectangleBox, lineBox, triangleBox, leftArrowBox);
                    break;
                case "triangleBox":
                    returner = 4;
                    FixedBox(returner, pb, rectangleBox, ellipseBox, lineBox, leftArrowBox);
                    break;
                case "leftArrowBox":
                    returner = 5;
                    FixedBox(returner, pb, rectangleBox, ellipseBox, triangleBox, lineBox);
                    break;
            }
        }

        private void FixedBox(int donenDeger, PictureBox component, PictureBox pb1, PictureBox pb2, PictureBox pb3, PictureBox pb4)
        {
            component.BorderStyle = BorderStyle.None;
            component.BackColor = Color.Gray;
            pb1.BorderStyle = BorderStyle.None;
            pb1.BackColor = Color.Gray;
            pb2.BorderStyle = BorderStyle.None;
            pb2.BackColor = Color.Gray;
            pb3.BorderStyle = BorderStyle.None;
            pb3.BackColor = Color.Gray;
            pb4.BorderStyle = BorderStyle.None;
            pb4.BackColor = Color.Gray;
            stringAl.Visible = false;
            fonts.Visible = false;

            switch (donenDeger)
            {
                case 1:
                    component.BorderStyle = BorderStyle.Fixed3D;
                    component.BackColor = Color.Silver;
                    break;
                case 2:
                    component.BorderStyle = BorderStyle.Fixed3D;
                    component.BackColor = Color.Silver;
                    break;
                case 3:
                    component.BorderStyle = BorderStyle.Fixed3D;
                    component.BackColor = Color.Silver;
                    break;
                case 4:
                    component.BorderStyle = BorderStyle.Fixed3D;
                    component.BackColor = Color.Silver;
                    break;
                case 5:
                    component.BorderStyle = BorderStyle.Fixed3D;
                    component.BackColor = Color.Silver;
                    stringAl.Visible = true;
                    fonts.Visible = true;
                    fonts.Items.RemoveAt(0);
                    fonts.SelectedIndex = 0;
                    break;
            }
        }

        private void kalinlikTrack_ValueChanged(object sender, EventArgs e)
        {
            kalinlikLbl.Text = kalinlikTrack.Value.ToString();
        }

        private void ÜcgenOlusturma(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    //draw line
                    polygonPoints.Add(new Point(e.X, e.Y));
                    if (polygonPoints.Count > 1)
                    {
                        //draw line
                        this.DrawLine(polygonPoints[polygonPoints.Count - 2], polygonPoints[polygonPoints.Count - 1]);
                    }
                    break;

                case MouseButtons.Right:
                    //finish polygon
                    if (polygonPoints.Count > 2)
                    {
                        //draw last line
                        this.DrawLine(polygonPoints[polygonPoints.Count - 1], polygonPoints[0]);
                        polygonPoints.Clear();
                    }
                    break;
            }
        }

        private void stringAl_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                stringAl.ReadOnly = false;
                stringAl.ForeColor = Color.Black;
                stringAl.Clear();
                sayac++;
            }
        }

        private void RenkSecimi(object sender, EventArgs e)
        {
            renk = (sender as PictureBox).BackColor;
            pnlSecilenRenk.BackColor = renk;
        }

        private void newBox_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            this.BackgroundImage = null;
        }

        private void screenShoter_Click(object sender, EventArgs e)
        {
            Hide();
            ScreenCapture sc = new ScreenCapture();
            Image image = sc.CaptureScreen();
            BackgroundImage = image;
            Show();
        }
    }
}