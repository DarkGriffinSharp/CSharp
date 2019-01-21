using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonu
{
    class Program:Filmler
    {
        static bool kontrol = true;

        static void Main(string[] args)
        {
            while (kontrol)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("***************************************************");
                Console.WriteLine("*                                                 *");
                Console.WriteLine("*                    ANA MENÜ                     *");
                Console.WriteLine("*                                                 *");
                Console.WriteLine("***************************************************");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("\n");
                Console.Write("1-> Film Ekleme\n2-> Film Oturma Planı\n3-> Bilet Al\nGiriş: ");
                ConsoleKeyInfo cki = Console.ReadKey();

                switch (cki.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        TxtFilmleriEkle();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        kontrol = true;
                        XmlOku();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        BiletIslemleri b = new BiletIslemleri();
                        b.BiletAl();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Hatalı giriş.");
                        Console.ResetColor();
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}