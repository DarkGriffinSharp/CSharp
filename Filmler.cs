using System;
using System.Collections;
using System.IO;

namespace SinemaOtomasyonu
{
    partial class Filmler
    {
        #region Tanımlamalar
        public static string txtKonum = AppDomain.CurrentDomain.BaseDirectory + @"\Dosyalar\Filmler.txt";
        static Queue queue = new Queue();
        static ArrayList arrayList = new ArrayList();
        public static string FilmAdi { get; set; }
        #endregion

        #region Ortalama
        /// <summary>
        /// Mesajı ortaya yazdırma
        /// </summary>
        /// <param name="message"></param>
        public static void Ortala(string message)
        {
            Console.SetCursorPosition((Console.WindowWidth - message.Length) / 2, Console.CursorTop);
            Console.Write(message);
        }
        #endregion

        #region SatırTemizleme
        /// <summary>
        /// En son kullanılan ConsoleCursor'u temizleme
        /// </summary>
        public static void SatirTemizle()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
        #endregion

        #region MetinBelgesiİşlemleri
        public static void TxtFilmleriEkle()
        {
            try
            {
                Ortala("VİZYONDAKİ FİLMLERİ EKLEME\n");

                for (int i = 0; i < 4; i++)
                {
                    Ortala("Film adını girin: ");
                    queue.Enqueue(Console.ReadLine());
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    SatirTemizle();
                }

                using (StreamWriter sw = new StreamWriter(txtKonum))
                {
                    do
                    {
                        sw.WriteLine(queue.Dequeue());
                    } while (0 < queue.Count);
                }

                TxtFilmleriOku();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void TxtFilmleriOku()
        {
            try
            {
                arrayList = new ArrayList();
                int satirSayisi = File.ReadAllLines(txtKonum).Length;
                using (StreamReader sr = new StreamReader(txtKonum))
                {
                    for (int i = 0; i < satirSayisi; i++)
                    {
                        arrayList.Add(sr.ReadLine());
                    }
                    sr.Dispose();
                    sr.Close();
                }

                XmlFilmleriOlustur();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void XmlFilmleriOlustur()
        {
            foreach (var item in arrayList)
            {
                if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Dosyalar\" + item + ".xml"))
                {
                    FileStream fs = new FileStream(AppDomain.CurrentDomain.BaseDirectory + @"\Dosyalar\" + item + ".xml", FileMode.Create, FileAccess.ReadWrite);
                    fs.Close();
                    fs.Dispose();

                    SeansEkle(item.ToString());
                }
            }
        }
        #endregion
    }
}