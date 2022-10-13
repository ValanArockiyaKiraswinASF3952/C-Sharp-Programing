using System.IO;
using System.Collections.Generic;
namespace OnlineGroceryStoreApplication
{
    public class Files
    {
        public static void create()
        {
            if(!Directory.Exists("GroceryStore"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("GroceryStore");
            }

            if (!File.Exists("GroceryStore/CustomerDetails.csv"))
            {
                System.Console.WriteLine("Create File");
                File.Create("GroceryStore/CustomerDetails.csv");
            }

            if(!File.Exists("GroceryStore/ProductDetails.csv"))
            {
                System.Console.WriteLine("Create File");
                File.Create("GroceryStore/ProductDetails.csv");
            }
            
            if(!File.Exists("GroceryStore/BookingDetails.csv"))
            {
                System.Console.WriteLine("Create File");
                File.Create("GroceryStore/BookingDetails.csv");
            }

             if(!File.Exists("GroceryStore/OrderDetails.csv"))
            {
                System.Console.WriteLine("Create File");
                File.Create("GroceryStore/OrderDetails.csv");
            }
        }
        public static void ReadFile()
        {
            string [] customer = File.ReadAllLines("GroceryStore/CustomerDetails.csv");
            foreach(string data in customer)
            {
                CustomerDetails customers = new CustomerDetails(data);
                Operations.customerList.Add(customers);
            }

            string [] product = File.ReadAllLines("GroceryStore/ProductDetails.csv");
            foreach(string data in product)
            {
                ProductDetails products = new ProductDetails(data);
                Operations.productList.Add(products);
            }

            string [] booking = File.ReadAllLines("GroceryStore/BookingDetails.csv");
            foreach(string data in booking)
            {
                BookingDetails book = new BookingDetails(data);
                Operations.bookingList.Add(book);
            }

            string [] order = File.ReadAllLines("GroceryStore/OrderDetails.csv");
            foreach(string data in order)
            {
                OrderDetails orders = new OrderDetails(data);
                Operations.orderList.Add(orders);
            }
        }

        public static void WriteFile()
        {
            string [] CustomerDetails = new string[Operations.customerList.Count];
            for (int i=0; i<Operations.customerList.Count;i++)
            {
                CustomerDetails[i]=Operations.customerList[i].CustomerID+","+Operations.customerList[i].Name+","+Operations.customerList[i].FatherName+","+Operations.customerList[i].Gender+","+Operations.customerList[i].Mobile+","+Operations.customerList[i].DOB+","+Operations.customerList[i].MailID+","+Operations.customerList[i].WalletBalance;
            }

            string [] ProductDetails = new string[Operations.productList.Count];
            for (int i=0; i<Operations.customerList.Count;i++)
            {
                ProductDetails[i]=Operations.productList[i].ProductID;
            }
        }
    }
}