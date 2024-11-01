using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crud: Create Read Update Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");

            Console.WriteLine();

            Console.WriteLine("--------------------------------------");

            #region Kategori Ekleme İşlemi
            //Console.WriteLine("Eklemek istediğiniz Kategori Adı: ");

            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-IMEIVGC\\SQLEXPRESS;Initial Catalog=EgitimKampi;Integrated Security=True");

            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into Category (CategoryName) values (@p1)", connection);

            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Kategori başarıyla eklendi");
            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();

            //Console.Write("Ürün Fiyatı: ");
            //productPrice =decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-IMEIVGC\\SQLEXPRESS;Initial Catalog=EgitimKampi;Integrated Security=True");

            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into Product (ProductName, ProductPrice,ProductStatus) values (@p1,@p2,@p3)", connection);

            //command.Parameters.AddWithValue("@p1", productName);
            //command.Parameters.AddWithValue("@p2", productPrice);
            //command.Parameters.AddWithValue("@p3", true);

            //command.ExecuteNonQuery();

            //connection.Close();
            //Console.WriteLine("Ürün eklemesi başarılı");

            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-IMEIVGC\\SQLEXPRESS;Initial Catalog=EgitimKampi;Integrated Security=True");

            //connection.Open();
            //SqlCommand command = new SqlCommand("select * from Product",connection);

            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();

            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine() ;
            //}



            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-IMEIVGC\\SQLEXPRESS;Initial Catalog=EgitimKampi;Integrated Security=True");

            //connection.Open();

            //SqlCommand command = new SqlCommand("delete from Product where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);

            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Silme işlemi başarılı");

            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-IMEIVGC\\SQLEXPRESS;Initial Catalog=EgitimKampi;Integrated Security=True");

            //connection.Open();

            //SqlCommand command = new SqlCommand("update Product set ProductName=@productName,ProductPrice=@productPrice where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);

            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Güncelleme işlemi başarılı");

            #endregion

            Console.Read();


        }
    }
}
