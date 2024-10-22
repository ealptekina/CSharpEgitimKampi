using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Void Metotlar

			//// Geriye değer dönürmeyen metotlar : 
			//// Customer -->listele,ekle,sil,güncelle
			//// Void

			//void CustomerList()
			//{
			//	Console.WriteLine("Ali Yıldız");
			//	Console.WriteLine("Ayşe Yıldız");
			//	Console.WriteLine("Merve Yıldız");
			//	Console.WriteLine("Ayşe Yıldız");
			//}
			//CustomerList();


			//void Sum() {

			//	int x = 1;
			//	int y = 2;
			//	int z = x+y;
			//	Console.WriteLine(z);
			//}
			//Sum();

			#endregion

			#region Geriye Değer Döndürmeyen String Parametreli Metotlar



			//void WriteMethod(string customerName)
			//{
			//	Console.WriteLine(customerName);

			//}
			//WriteMethod("Mehmet Yıldırım");



			//void CustomerCard(string name, string surname)
			//{
			//	Console.WriteLine("Müşteri: " + name + " " + surname);
			//}
			//CustomerCard("mehmet", "yıldız");
			//CustomerCard("mehmet", "deniz");
			//CustomerCard("deniz", "çorlu");

			#endregion

			#region Geriye Değer Döndürmeyen Int Parametreli Metotlar


			//void Sum(int number1, int number2, int number3)
			//{
			//	int result = number1 + number2 + number3;
			//	Console.WriteLine(result);
			//}
			//Sum(4,5,6);

			#endregion

			#region Geriye Değer Döndüren Metotlar

			// değer dönmüyor karşılığı yok
			//string CustomerName()
			//{
			//	return "Buse Yıldız";
			//}
			//CustomerName();


			//string StudentCard()
			//{
			//	string name = "Ali";
			//	string surname = "Yıldız";

			//	return name + " " + surname;
			//}

			//Console.WriteLine(StudentCard());
			#endregion

			#region Geriye Değer Döndüren String Parametreli Metotlar

			//string CountryCard (string countryName, string capital, string flagColor)
			//{
			//	string cardInfo = countryName + " " + capital + " " + flagColor;
			//	return (cardInfo);
			//}
			//string x, y, z;
			//Console.Write("Ülke Adını Giriniz: ");
			//x = Console.ReadLine();

			//Console.Write("Ülke Başkentini Giriniz: ");
			//y = Console.ReadLine();

			//Console.Write("Bayrak Rengini Giriniz: ");
			//z = Console.ReadLine();


			//Console.WriteLine(CountryCard(x, y, z));
			#endregion

			#region Geriye Değer Döndüren Int Parametreli Metotlar

			//int Sum(int number1, int number2)
			//{
			//	int result = number1 + number2;
			//	return result;
			//}
			//Console.WriteLine(Sum(10, 20));
			//Console.WriteLine(Sum(45, 15));
			//Console.WriteLine(Sum(35, 30));
			//Console.WriteLine(Sum(70, 45));


			#endregion

			#region Örnek Uygulama
			string  ExamResult (string student, int exam1, int exam2, int exam3)
			{
				int result = (exam1 + exam2 + exam3) / 3;
				if (result >= 50)
				{
					return "Öğrenci sınavı geçti";
				}
				else
				{
					return "Öğrenci başarısız oldu";
				}

			}

			Console.WriteLine(ExamResult("Ali", 25, 90, 83));
			Console.WriteLine(ExamResult("Ayşe", 25, 88, 23));
			#endregion

			Console.Read();
		}
	}
}
