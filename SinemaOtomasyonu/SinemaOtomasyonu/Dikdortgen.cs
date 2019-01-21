using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace SinemaOtomasyonu
{
    public class Dikdortgen
    {
        #region Tanımlar
        private int hWidth;
        private int hHeight;
        private Point hLocation;
        private ConsoleColor hBorderColor;
        #endregion

        #region YapıcıMetot
        public Dikdortgen(int width, int height, Point location, ConsoleColor borderColor)
        {
            hWidth = width;
            hHeight = height;
            hLocation = location;
            hBorderColor = borderColor;
        }
        #endregion

        #region ÇözünürlükLokasyonRenk
        public Point Location
        {
            get { return hLocation; }
            set { hLocation = value; }
        }

        public int Width
        {
            get { return hWidth; }
            set { hWidth = value; }
        }

        public int Height
        {
            get { return hHeight; }
            set { hHeight = value; }
        }

        public ConsoleColor BorderColor
        {
            get { return hBorderColor; }
            set { hBorderColor = value; }
        }
        #endregion

        #region Çizme
        public void Cizdir()
        {
            string s = "╔";
            string space = "";
            string temp = "";
            for (int i = 0; i < Width; i++)
            {
                space += " ";
                s += "═";
            }

            for (int j = 0; j < Location.X; j++)
                temp += " ";

            s += "╗" + "\n";

            for (int i = 0; i < Height; i++)
                s += temp + "║" + space + "║" + "\n";

            s += temp + "╚";
            for (int i = 0; i < Width; i++)
                s += "═";

            s += "╝" + "\n";

            Console.ForegroundColor = BorderColor;
            Console.CursorTop = hLocation.Y;
            Console.CursorLeft = hLocation.X;
            Console.WriteLine("\t     Perde");
            Console.Write(s);
            Console.ResetColor();
        }
        #endregion
    }
}
