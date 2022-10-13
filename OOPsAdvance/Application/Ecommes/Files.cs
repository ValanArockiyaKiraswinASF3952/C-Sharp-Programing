using System;
using System.IO;
using System.Collections.Generic;
namespace EcommerceAplplication
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("Customer"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("Customer");
            }
            if(!File.Exists("Customer/CustomerDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("Customer/CustomerDetails.csv");
            }
            if(!File.Exists("Customer/OrderDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("Customer/OrderDetails.csv");
            }
            if(!File.Exists("Customer/ProductDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("Customer/ProductDetails.csv");
            }
        }
         public static void ReadFile()
        {
            string [] customer = File.ReadAllLines("Customer/CustomerDetails.csv");
            foreach(string data in customer)
            {
            CustomerDetails customers = new CustomerDetails(data);
            Operations.userList.Add(customers);  
            }

            string [] order = File.ReadAllLines("Customer/OrderDetails.csv");
            foreach(string datas in order)
            {
            OrderDetails orders = new OrderDetails(datas);
            Operations.customerList.Add(orders);  
            }

            string [] product = File.ReadAllLines("Customer/ProductDetails.csv");
            foreach(string dat in product)
            {
            ProductDetails products = new ProductDetails(dat);
            Operations.productList.Add(products);  
            }
        }

        public static void WriteToFile()
        {
            string [] customerDetails = new string[Operations.userList.Count];
            for (int i=0;i<Operations.userList.Count;i++)
            {
                customerDetails[i]=Operations.userList[i].CustomerID+","+Operations.userList[i].Name+","+Operations.userList[i].City+","+Operations.userList[i].MobileNumber+","+Operations.userList[i].WalletBalance+","+Operations.userList[i].MailID;
            }
            File.WriteAllLines("Customer/CustomerDetails.csv",customerDetails);

            string [] order = new string[Operations.customerList.Count];
            for (int i=0;i<Operations.customerList.Count;i++)
            {
                order[i]=Operations.customerList[i].OrderID+","+Operations.customerList[i].TotalPrice+","+Operations.customerList[i].PurchaseDate+","+Operations.customerList[i].Quanity+","+Operations.customerList[i].OrderStatus;
            }
            File.WriteAllLines("Customer/OrderDetails.csv",order);

            string [] product = new string[Operations.productList.Count];
            for (int i=0;i<Operations.productList.Count;i++)
            {
                product[i]=Operations.productList[i].ProductID+","+Operations.productList[i].ProductName+","+Operations.productList[i].Price+","+Operations.productList[i].Stock+","+Operations.productList[i].ShipingDuration;
            }
            File.WriteAllLines("Customer/ProductDetails.csv",product);
        }
    }
}