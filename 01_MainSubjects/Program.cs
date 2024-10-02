using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Yazıdrma Komutları
            //Console.WriteLine("Selam");
            //Console.Write("Merhaba Dünya");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region String Değişkenler

            // String
            // Degisken_türü degisken_adı;

            //string name;
            //name = "Elif";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;
            //customerName = "Elif";
            //customerSurname = "Alptekin";
            //customerPhone = "+90 500 555 55 55";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine("Müşteri: " +  customerName + customerSurname);
            //Console.WriteLine("Telefon: " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-----------------------------------------------");

            //Console.WriteLine();

            //customerName = "Derya";
            //customerSurname = "Deniz";
            //customerPhone = "+90 400 444 44 44";
            //customerEmail = "info@gmail.com";
            //district = "Çayyolu";
            //city = "Ankara";

            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + customerSurname);
            //Console.WriteLine("Telefon: " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-----------------------------------------------");

            #region Int Değişkenler

            //int

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int limonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");

            Console.WriteLine();
            Console.WriteLine("-----Hamburger Fiyatı: " + hamburgerPrice + "TL");
            Console.WriteLine("-----Cola Fiyatı: " + cokePrice + "TL");
            Console.WriteLine("-----Su Fiyatı: " + waterPrice + "TL");
            Console.WriteLine("-----Kızartma Fiyatı: " + friesPrice + "TL");
            Console.WriteLine("-----Pizza Fiyatı: " + pizzaPrice + "TL");
            Console.WriteLine("-----Limonara Fiyatı: " + limonadePrice + "TL");

            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int limonadeCount;
            
            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLimonadePrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 1;
            limonadeCount = 0;

            totalHamburgerPrice = hamburgerCount*hamburgerPrice;
            Console.WriteLine("---------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");

            totalCokePrice = cokeCount * cokePrice;
            Console.WriteLine("---------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalCokePrice + " TL");


            totalWaterPrice = waterCount * waterPrice;
            Console.WriteLine("---------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalWaterPrice + " TL");


            totalFriesPrice = friesCount * friesPrice;
            Console.WriteLine("---------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalFriesPrice + " TL");


            totalPizzaPrice = pizzaCount * pizzaPrice;
            Console.WriteLine("---------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalPizzaPrice + " TL");

            totalLimonadePrice = limonadeCount * limonadeCount;
            Console.WriteLine("---------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalLimonadePrice + " TL");

            Console.WriteLine("---------------------------");
            Console.WriteLine();

            int toplamHesap = totalHamburgerPrice+totalCokePrice+totalWaterPrice+totalFriesPrice+totalPizzaPrice+totalLimonadePrice;
            Console.WriteLine("Toplam Hesap: " + toplamHesap + " TL");

            #endregion

            #endregion
            Console.Read();
        }
    }
}
