using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //string[] colors = new string[4];

            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[5]);


            //int[] numbers = new int[10];
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;

            //numbers[7] = 40;
            //numbers[8] = 50;

            //Console.WriteLine(numbers[7]);


            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };
            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}



            //int[] numbers = { 1, 15, 33, 125, 488, 522, 7456, 2365, 1120, 333 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}



            //char[] sembols = { 'a', 'b', 'c', '*', '-' };
            //for (int i = 0; i < sembols.Length; i++)
            //{
            //    Console.WriteLine(sembols[i]);

            //}

            //int[] myArray = { 1, 2, 3, 4, 5, 60, 7, 800, 9785, 101, 11, 121, 103, 174, 15 };

            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i]>maxNumber)
            //    {
            //        maxNumber = myArray[i];

            //    }
            //}
            //Console.WriteLine(maxNumber);


            //string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            //Console.WriteLine(persons.Length);

            // Array sıralama Sort
            //int[] numbers = { 1, 42, 93, 34, 15, 36 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            // Diziyi tersten sırlama yapıyor
            //int[] numbers = { 1, 42, 93, 34, 15, 36 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            #endregion

            #region Dizi Metotları

            //string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "merve");

            //Console.WriteLine(index);

            // Dizinin en büyük ve en küçük elemanını bulma
            //int[] numbers = { 1, 20, 34, 48, 56, 60, 80, 94, 120, 135, 450, 652, 780, 895, 777, 99, 41, 22 };
            //Console.WriteLine("Dizinin En büyük Elemanı: " + numbers.Max() + " Dizinin En Küçük elemanı: " + numbers.Min());

            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i]=Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("---------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] sayi = { 1, 2, 3, 4, 5, 6 };

            //int toplam = 0;

            //for (int i = 0; i < sayi.Length; i++)
            //{
            //    toplam = sayi[i] + toplam;
            //}
            //Console.WriteLine(toplam);


            int[] sayilar = { 1, 20, 30, 41, 33, 55, 42, 43, 65, 66, 77, 72, 71, 80, 83, 84, 90, 99 };

            Console.WriteLine("Dizinin Çift Sayıları..");


            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {

                    Console.WriteLine(numbers[i]);
                }
               
            }
            Console.WriteLine();
            Console.WriteLine("-----------------");

            Console.WriteLine("Dizinin Tek Sayıları..");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {

                    Console.WriteLine(numbers[i]);
                }

            }

            #endregion

            Console.Read();
        }
    }
}
