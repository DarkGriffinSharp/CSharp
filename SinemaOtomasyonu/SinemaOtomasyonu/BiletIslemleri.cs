using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SinemaOtomasyonu
{
    public partial class Filmler
    {
        public class BiletIslemleri
        {
            public int counter = 0;
            Random rnd;
            public string No { get; set; }
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string Koltuk { get; set; }
            public List<object> xmlList = new List<object>();
            public bool x = true;

            public void BiletAl()
            {
                xtw = new XmlTextWriter(konum + @"Dosyalar\" + "Alinanlar.xml", Encoding.GetEncoding("utf-8"));
                try
                {
                    rnd = new Random();
                    Console.Clear();
                    Console.Write("Alınacak bilet sayısı: ");
                    ConsoleKeyInfo cki = Console.ReadKey();
                    Console.WriteLine();
                    counter = Convert.ToInt32(cki.KeyChar.ToString());
                    do
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            No += rnd.Next(0, 100).ToString();
                        }

                        do
                        {
                            Console.Write("Adı: ");
                            Ad = Console.ReadLine();
                            Console.Write("Soyadı: ");
                            Soyad = Console.ReadLine();
                            Console.Clear();

                        } while (Ad == "" && Soyad == "");

                        kontrol = false;
                        XmlOku();

                        do
                        {
                            x = true;
                            Console.Write("Seçmek istediğiniz koltuk(1-20): ");
                            Koltuk = Console.ReadLine();
                            SatirTemizle();
                            if (koltukList[int.Parse(Koltuk) - 1] == "Dolu")
                            {
                                x = false;
                            }

                        } while (!(int.Parse(Koltuk) >= 1) && !(int.Parse(Koltuk) <= 20) || x == false);
                        
                        xtw.Formatting = Formatting.Indented;
                        xtw.WriteStartDocument();
                        xtw.WriteComment("Satın Alanlar");
                        xtw.WriteStartElement(Film);
                        xtw.WriteStartElement($"Koltuk{Koltuk}");
                        xtw.WriteString($"{No} - {Ad} - {Soyad}");
                        xtw.WriteEndElement();
                        xtw.WriteEndElement();
                        
                        counter--;
                        Console.Clear();
                    } while (counter > 0);
                    xtw.Close();

                }
                catch (Exception)
                {
                    xtw.Close();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Hata oluştu, ana menüye dönülüyor.");
                    System.Threading.Thread.Sleep(1000);
                    Console.ResetColor();
                }
            }
        }
    }
}