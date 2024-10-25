using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//Ado.net

			Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi sistemi *****");
			Console.WriteLine();
			Console.WriteLine();

			string tableNumber;

			Console.WriteLine("---------------------------------------");

			Console.WriteLine("1- Kategoriler");
			Console.WriteLine("2- Ürünler");
			Console.WriteLine("3- Siparişler");
			Console.WriteLine("4- Çıkış Yap");
			Console.WriteLine("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
			tableNumber = Console.ReadLine();
			Console.WriteLine("---------------------------------------");

			// SQL bağlantısı oluşturuluyor. Bağlantı için gerekli bilgiler "Data Source" ve "Initial Catalog" alanlarında belirtilmiştir.
			// "Data Source" sunucuyu (ve örneğin adını), "Initial Catalog" ise kullanılacak veritabanını ifade eder.
			// "Integrated Security=True" ise, Windows kimlik doğrulamasını kullanarak bağlanılacağını belirtir.
			SqlConnection connection = new SqlConnection("Data Source=DESKTOP-IMEIVGC\\SQLEXPRESS;Initial Catalog=EgitimKampi;Integrated Security=True");

			// Bağlantı açılıyor, böylece veritabanına erişim sağlanabilir.
			connection.Open();

			// SQL sorgusunu tanımlıyoruz. Bu komut, "Category" adlı tablodan tüm kayıtları seçmek için "SELECT * FROM Category" sorgusunu çalıştıracaktır.
			SqlCommand command = new SqlCommand("select * from Category", connection);

			// SQL sorgusundan elde edilen verileri geçici olarak tutmak için bir SqlDataAdapter nesnesi oluşturuluyor.
			// SqlDataAdapter, komutu çalıştırarak sonuçları alır ve "DataTable" gibi veri yapılarıyla uyumlu hale getirir.
			SqlDataAdapter adapter = new SqlDataAdapter(command);

			// Verileri geçici olarak saklamak için bir DataTable nesnesi oluşturuluyor.
			// DataTable, sonuçların saklanacağı bir veri yapısıdır.
			DataTable dt = new DataTable();

			// Adapter aracılığıyla alınan veriler, DataTable'a (dt) yükleniyor.
			// Böylece SQL'den alınan tüm veriler, DataTable nesnesinde saklanmış olur.
			adapter.Fill(dt);

			// Bağlantı kapatılıyor,
			connection.Close();

			// dt (DataTable) nesnesindeki her bir satırı sırayla döngüye alıyoruz.
			foreach (DataRow row in dt.Rows)
            {
				// row (DataRow) nesnesinin her bir hücresini (sütun değerini) döngüye alıyoruz.
				foreach (var item in row.ItemArray)
				{
					// Hücredeki veriyi string olarak alıp ekrana yazdırıyoruz.
					Console.Write(item.ToString());
				}
				Console.WriteLine();
            }

            Console.Read();
		}
	}
}
