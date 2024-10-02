using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region

            //double number;
            //number = 4.85;
            //Console.WriteLine(number);
            //Console.Read();
            #endregion

            #region
            //double cilekBirimFiyat, elmaBirimFiyat, domatesBirimFiyat, patatesBirimFiyat;

            //cilekBirimFiyat = 5.45;
            //elmaBirimFiyat = 8.63;
            //domatesBirimFiyat = 4.20;
            //patatesBirimFiyat = 9.10;

            //Console.WriteLine("Çilek Birim Fiyat: " + cilekBirimFiyat);
            //Console.WriteLine("Elma Birim Fiyat: " + elmaBirimFiyat);
            //Console.WriteLine("Domates Birim Fiyat: " + domatesBirimFiyat);
            //Console.WriteLine("Patates Birim Fiyat: " + patatesBirimFiyat);

            //Console.WriteLine();
            //Console.WriteLine();

            //double cilekGram, elmaGram, domatesGram, patatesGram;

            //cilekGram = 4.687;
            //elmaGram = 8.614;
            //domatesGram = 7.634;
            //patatesGram = 12.330;

            //Console.WriteLine("Çilek Gram: " + cilekGram);
            //Console.WriteLine("Elma Gram: " + elmaGram);
            //Console.WriteLine("Domates Gram: " + domatesGram);
            //Console.WriteLine("Patates Gram: " + patatesGram);

            //Console.WriteLine();
            //Console.WriteLine();

            //double cilekToplamFiyat, elmaToplamFiyat, domatesToplamFiyat, patatesToplamFiyat;

            //cilekToplamFiyat = cilekBirimFiyat * cilekGram;
            //elmaToplamFiyat = elmaBirimFiyat * elmaGram;
            //domatesToplamFiyat = domatesBirimFiyat * domatesGram;
            //patatesToplamFiyat = patatesBirimFiyat * patatesGram;

            //Console.WriteLine("Çilek Toplam Fiyat: " + cilekToplamFiyat);
            //Console.WriteLine("Elma Toplam Fiyat: " + elmaToplamFiyat);
            //Console.WriteLine("Domates Toplam Fiyat: " + domatesToplamFiyat);
            //Console.WriteLine("Patates Toplam Fiyat: " + patatesToplamFiyat);

            //Console.WriteLine();
            //Console.WriteLine();

            //double alısverisToplamFiyat = cilekToplamFiyat +  elmaToplamFiyat +domatesToplamFiyat * patatesToplamFiyat;

            //// Konsol kodlamasını UTF-8 olarak ayarlıyoruz
            //Console.OutputEncoding = System.Text.Encoding.UTF8;

            //// TL sembolünü kullanan yazı
            //Console.WriteLine("Toplam Alışveriş Ücret: " + alısverisToplamFiyat + " ₺");
            #endregion

            #region Char Değişkenler

            //ABCDEFGH
            //DEF
            //TOPLANTI SAAT 20:00'DE
            //" '

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("****CSharp Hava Yolları Yolcu Bilgileri****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine(); // Kullanıcının girdiği passengerName alınıyor


            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine(); // Kullanıcının girdiği passengerSurname alınıyor

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yaş Bilgisi: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("TC Kimlik Numarası: ");
            //passengerIdentityNumber = Console.ReadLine();


            //Console.WriteLine();
            //Console.WriteLine("---------------");
            //Console.WriteLine("Yolcu: " + passengerName + " " + passengerSurname + " " + passengerDistrict + "/" + passengerCity + " " + passengerAge + " " + passengerIdentityNumber);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //ABC12D

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoeCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı fiyatınızı giriniz: ");
            //shoeCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız tv sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoeCount*shoePrice + computerCount*computerPrice + chairCount*chairPrice + tvCount*tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());


            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.Write("Sınav Ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion
            Console.Read();

        }
    }
}
