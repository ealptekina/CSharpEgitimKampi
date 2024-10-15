using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Foreach Döngüsü

            //Foreach(1;2;3;4)
            //1: Değişken Türü
            //2: Değişken adı
            //3: In
            //4: Liste,Koleksiyon,Dizi


            //string[] cities = { "milano", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}


            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //foreach (int i in numbers)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //int total = 0;

            //foreach (int number in numbers)
            //{
            //    total += number;
            //}
            //Console.WriteLine(total);


            #endregion

            #region Listeleme

            //List<int> numbers = new List<int>()
            //{
            //    1, 2, 3, 4, 5, 6, 7, 8, 9
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            #endregion

            #region Bir Kelimeyi Harflere Ayırma

            //string kelime = "Merhaba";

            //foreach (char s in kelime)
            //{
            //    Console.WriteLine(s);
            //}

            #endregion

            #region Klavyeden öğrenci sayısı,öğrenci ismini,sınav not ve ortalama hesaplama işlemi

            Console.WriteLine("*****C# Eğitim Kampı Sınav Uygulaması*****");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------");

            // Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("Sınıfınızda kaç öğrenci var: ");
            int ogrenciSayisi = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("---------------------------------------");

            // Öğrenci isimlerini ve notlarını saklayacak diziler
            string[] ogrenciAdi = new string[ogrenciSayisi];
            double[] ogrenciSinavNotlari = new double[ogrenciSayisi];

            for (int i = 0; i < ogrenciSayisi; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                ogrenciAdi[i] = Console.ReadLine();

                double toplamSinavSonuclari = 0;

                // Her öğrenci için 3 sınav notu girişi
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{ogrenciAdi[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");

                    double value = double.Parse(Console.ReadLine());
                    toplamSinavSonuclari += value; // Notları topluyoruz.
                }

                ogrenciSinavNotlari[i] = toplamSinavSonuclari / 3; // Ortalama hesaplama
            }

            // Öğrencilerin isimlerini ve ortalamalarını yazdırma
            for (int i = 0; i < ogrenciSayisi; i++)
            {
                Console.WriteLine($"{ogrenciAdi[i]} isimli öğrencinin sınav ortalaması: {ogrenciSinavNotlari[i]:F2}");

                if (ogrenciSinavNotlari[i]>=50)
                {
                    Console.WriteLine($"{ogrenciAdi[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{ogrenciAdi[i]} adlı öğrenci dersten kaldı");
                }
            }
            // Bu örnekte, sayı 123.456789 iken "F2" ile sadece iki ondalık basamağı (123.46) ekrana yazdırılır.

            #endregion
            Console.Read();
        }
    }
}
