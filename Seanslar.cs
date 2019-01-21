using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Drawing;
using System.Collections;

namespace SinemaOtomasyonu
{
    public partial class Filmler
    {
        #region Tanımlar
        public static string konum = AppDomain.CurrentDomain.BaseDirectory;
        static XmlTextWriter xtw;
        //XmlTextReader xtr;
        static string day = DateTime.Today.DayOfWeek.ToString();
        public static int sayac = 1;
        public static int i = 0;
        public static List<string> koltukList = new List<string>();
        public static bool kontrol = true;
        public static string Film { get; set; }
        #endregion

        #region Koltuklar
        public static void Koltuklar(int koltuk, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            if (koltuk >= 10)
            {
                Console.Write(koltuk + " ");
                Console.Write("|_|");
            }
            else
            {
                Console.Write(" " + koltuk + " ");
                Console.Write("|_|");
            }
            Console.ResetColor();
        }
        #endregion

        #region SeansXMLİşlemleri
        public static void SeansEkle(string filmAdi)
        {
#pragma warning disable IDE0017 // Simplify object initialization
            xtw = new XmlTextWriter(konum + @"Dosyalar\" + filmAdi +".xml", Encoding.GetEncoding("utf-8"));
#pragma warning restore IDE0017 // Simplify object initialization
            xtw.Formatting = Formatting.Indented;
            xtw.WriteStartDocument();
            xtw.WriteComment(DateTime.Today.DayOfWeek.ToString());
            xtw.WriteStartElement(DateTime.Today.DayOfWeek.ToString());
            for (int i = 0; i < 20; i++)
            {
                xtw.WriteStartElement($"Koltuk{i+1}");
                xtw.WriteString("Boş");
                xtw.WriteEndElement();
            }
            xtw.WriteEndElement();
            xtw.WriteEndDocument();
            xtw.Close();
        }

        public static void XmlOku()
        {
            sayac = 1;
            try
            {
                //xtr = new XmlTextReader(konum + @"Dosyalar\a.xml");
                //while (xtr.Read())
                //{
                //    if (xtr.IsStartElement())
                //    {

                //    }
                //}
                int index;
                #warning İndex hatası almamak için ^_^ do while();
                do
                {
                    TxtFilmleriOku();
                    int x = 1;
                    foreach (var item in arrayList)
                    {
                        Console.WriteLine($"{x++}) {item}");
                    }

                    Console.Write("\nBakmak istediğiniz filmi tuşlayın: ");
                    ConsoleKeyInfo cki = Console.ReadKey();

                    Console.Clear();
                    index = Convert.ToInt32(cki.KeyChar.ToString());
                } while (index > 4);

                Film = arrayList[index - 1].ToString();
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(AppDomain.CurrentDomain.BaseDirectory + @"\Dosyalar\" + arrayList[index-1] + ".xml");
                koltukList.Clear();
                foreach (XmlNode item in xmlDoc.ChildNodes)
                {
                    GetChildren(item);
                }
                KoltukSirala();
            }
            catch (Exception)
            {
                Console.WriteLine("Hata oluştu, ana menüye dönülüyor");
            }
        }

        private static void GetChildren(XmlNode node)
        {
            try
            {
                if (node.LocalName == $"Koltuk{sayac}")
                {
                    if (node.InnerText == "Boş")
                    {
                        koltukList.Add(node.InnerText);
                    }
                    else if (node.InnerText == "Dolu")
                    {
                        koltukList.Add(node.InnerText);
                    }
                    sayac++;
                }
                else
                {
                    foreach (XmlNode item in node.ChildNodes)
                    {
                        GetChildren(item);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void KoltukSirala()
        {
            do
            {
                i = 0;
                Dikdortgen d = new Dikdortgen(30, 0, new Point(0, 0), ConsoleColor.White);
                d.Cizdir();
                Console.WriteLine("\n");

                foreach (var item in koltukList)
                {
                    if (item == "Boş")
                    {
                        Koltuklar(i + 1, ConsoleColor.Green);
                        i++;
                    }
                    else
                    {
                        Koltuklar(i + 1, ConsoleColor.Red);
                        i++;
                    }
                    if (i % 5 == 0)
                    {
                        Console.WriteLine();
                    }
                }

                Console.WriteLine();
                if (kontrol)
                {
                    Console.Write("Geri dönmek için 'Backspace': ");
                    ConsoleKeyInfo cki = Console.ReadKey();
                    if (cki.Key == ConsoleKey.Backspace)
                    {
                        Console.WriteLine();
                        break;
                    }
                }
                else
                {
                    break;
                }
            } while (true);
        }
        #endregion

//#error Film-Seans a göre koltuk alımı, hepsi dolu ise yer yok hatası, XML'den okunup yapılacak;

    }
}