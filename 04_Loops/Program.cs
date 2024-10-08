using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region For DÖngüsü


            // For (x;,y;z;) x: başlangıc,y: bitiş, z: artış veya azalış

            //int i;
            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("Eğitim Kamp");
            //}


            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}


            //Console.Write("Lütfen ekrana yazılmasını istediğniz adedi giriniz: ");
            //int bitisDegeri = int.Parse(Console.ReadLine());

            //for (int i = 1; i < bitisDegeri; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}

            //Console.Read();

            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //int toplamDeger = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    toplamDeger += i;
            //}
            //Console.WriteLine(toplamDeger);

            //int totalValue = 0;

            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;

            //    }
            //}

            //Console.WriteLine(totalValue);


            //int count = 0;

            //for (int i = 1; i <=50; i++)
            //{
            //    if (i % 7 == 0) 
            //    {
            //    count++;
            //    }
            //}

            //Console.WriteLine(count);

            //int bakteri = 1;
            //for (int i = 1; i <=24; i++)
            //{
            //    bakteri *= 2;
            //    Console.WriteLine(i + ".Saat Sonunda : " +  bakteri);

            //}

            #endregion

            #region While Döngüsü

            //int i = 1;
            //while (i <= 10) { 

            //    Console.WriteLine("Merhaba");
            //    i++;
            //}


            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);
            #endregion

            #region Örnek Sınav Sorusu

            // Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.
            //456  

            //Console.WriteLine("Lütfen 3 basamaklı bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hundreds = number / 100;

            //sum = ones + tens + hundreds;
            //Console.WriteLine(sum);




            #endregion

            Console.Read();

        }
    }
}
