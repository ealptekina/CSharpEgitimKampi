using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If

            //Console.WriteLine("Lütfen Şifreyi Giriniz: ");

            //string password = Console.ReadLine();

            //if (password == "abcd") {

            //    Console.WriteLine("Şifreniz Doğru Tebrikler");
            //}
            //else
            //{
            //    Console.WriteLine("Şifreniz Hatalı Lütfen Tekrar Deneyin!");
            //}


            //string capital, countr;

            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //countr = Console.ReadLine();

            //if (capital == "Ankara" && countr == "Türkiye")
            //{
            //    Console.Write("Veriler Doğrulandı");
            //}
            //else
            //{
            //    Console.Write("Hatalı Bilgi!");
            //}



            //int sayi;

            //Console.Write("Sayı Giriniz: ");
            //sayi = int.Parse(Console.ReadLine());

            //if (sayi == 5)
            //{

            //    Console.Write("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Hatalı!");
            //}



            //int sinav1, sinav2, sinav3, ort;
            //string result = "Hata";

            //Console.Write("Sınav 1: ");
            //sinav1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 2: ");
            //sinav2 = int.Parse(Console.ReadLine());


            //Console.Write("Sınav 3: ");
            //sinav3 = int.Parse(Console.ReadLine());


            //ort = (sinav1 + sinav2 + sinav3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " + ort);

            //if (ort > 0 && ort <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if (ort > 50 && ort <= 70)
            //{
            //    result = "Sonuç orta";
            //}
            //if (ort > 70 && ort <= 84)
            //{
            //    result = "Sonuç iyi";
            //}
            //if (ort > 84 && ort <= 100)
            //{
            //    result = "Sonuç çok iyi";
            //}

            //Console.WriteLine(result);


            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");

            //city = Console.ReadLine();

            //if (city == "adana" || city == "ankara" || city == "istanbul" || city == "bursa" || city == "eskişehir")
            //{

            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}




            //Console.Write("Lütfen kullanıcı adınızı giriniz: ");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.Write("Bu kullanıcı adı kabul edilemez");

            //}
            //else
            //{
            //    Console.Write("Hoşgeldiniz");
            //}

            //Console.Read();
            #endregion

            #region Mod

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1.sayıyı giriniz: ");

            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("1.sayının 2.sayıya bölümünden kalan: " +  result);

            //Console.Write("Lütfen sayı giriniz: ");
            //int number =int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Çift sayı");
            //}
            //else
            //{
            //    Console.Write("Tek sayı");
            //}

            #endregion

            #region Char

            //char team;
            //Console.Write("Lütfen takımınız için bir harf giriniz: ");

            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' || team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team == 'f' || team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'b' || team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}
            //if (team == 't' || team == 'T')
            //{
            //    Console.Write("Trabzon");
            //}


            //Console.Read();

            #endregion

            #region Örnek Proje Uygulaması

            //Console.Write("****** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("------------------------------------");

            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");

            //Console.WriteLine("------------------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.WriteLine("Detayını görmek istediğini menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------------Ana Yemekler-----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasülye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("-----------------Ana Yemekler-----------------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------------Çorbalar-----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine("-----------------Çorbalar-----------------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------------Pizzalar-----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Karışık Pizza");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("4-Etli Pizza");
            //    Console.WriteLine("-----------------Pizzalar-----------------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------------İçecekler-----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Cola");
            //    Console.WriteLine("2-Su");
            //    Console.WriteLine("3-Soda");
            //    Console.WriteLine("4-Meyve Suyu");
            //    Console.WriteLine("-----------------İçecekler-----------------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------------Tatlılar-----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Şekerpare");
            //    Console.WriteLine("2-Sütlaç");
            //    Console.WriteLine("3-Kadayıf");
            //    Console.WriteLine("-----------------Tatlılar-----------------");
            //    Console.WriteLine();

            //}









            //Console.Read();

            #endregion

            #region Swich Case

            //int ayNum;
            //Console.WriteLine("Lütfen Ay Girişi Yapınız: ");

            //ayNum = int.Parse(Console.ReadLine());

            //switch (ayNum)
            //{
            //    case 1:
            //        Console.WriteLine("Ocak");
            //        break;
            //    case 2:
            //        Console.WriteLine("Ocak");
            //        break;
            //    case 3:
            //        Console.WriteLine("Şubat");
            //        break;
            //    case 4:
            //        Console.WriteLine("Nisan");
            //        break;
            //    case 5:
            //        Console.WriteLine("Mayıs");
            //        break;
            //    case 6:
            //        Console.WriteLine("Haziran");
            //        break;
            //    case 7:
            //        Console.WriteLine("Temmuz");
            //        break;
            //    case 8:
            //        Console.WriteLine("Ağustos");
            //        break;
            //    case 9:
            //        Console.WriteLine("Eylül");
            //        break;
            //    case 10:
            //        Console.WriteLine("Ekim");
            //        break;
            //    case 11:
            //        Console.WriteLine("Kasım");
            //        break;
            //    case 12:
            //        Console.WriteLine("Aralık");
            //        break;
            //    default: Console.WriteLine("Hatalı Giriş"); break;
            //}


            //Console.Read();

            #endregion

            #region Hesap Makinesi (Switch Case)


            //int sayi1, sayi2, sonuc;
            //char sembol;

            //Console.WriteLine("Lütfen 1. sayıyı giriniz: ");
            //sayi1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 2. sayıyı giriniz: ");
            //sayi2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Giriniz: ");
            //sembol = char.Parse(Console.ReadLine());

            //switch (sembol)
            //{
            //    case '+':
            //        sonuc = sayi1 + sayi2;
            //        Console.WriteLine("Toplam: " + sonuc); break;
            //    case '-':
            //        sonuc = sayi1 - sayi2;
            //        Console.WriteLine("Fark: " + sonuc); break;
            //    case '*':
            //        sonuc = sayi1 * sayi2;
            //        Console.WriteLine("Çarpım: " + sonuc); break;
            //    case '%':
            //        sonuc = sayi1 % sayi2;
            //        Console.WriteLine("Bölüm: " + sonuc); break;

            //    default: Console.WriteLine("Hatalı Giriş"); break;
            //}

            //Console.Read();
            #endregion
        }
    }
}
