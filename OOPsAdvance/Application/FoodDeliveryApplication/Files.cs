using System;
using System.IO;
using System.Collections.Generic;
namespace FoodDeliveryApplication
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("Food"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("Food");
            }
            if(!File.Exists("Food/CustomerRegistration.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("Food/CustomerRegistration.csv");
            }
            if(!File.Exists("Food/FoodDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("Food/FoodDetails.csv");
            }
            if(!File.Exists("Food/BookingDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("Food/BookingDetails.csv");
            }
            if(!File.Exists("Food/OrderDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("Food/OrderDetails.csv");
            }
        } 



         public static void ReadFile()
        {
            string [] students = File.ReadAllLines("Food/CustomerRegistration.csv");
            foreach(string data in students)
            {
            CustomerRegistration student = new CustomerRegistration(data);
            Operations.customerList.Add(student);  
            }

            string [] department = File.ReadAllLines("Food/FoodDetails.csv");
            foreach(string data in department)
            {
            FoodDetails dept = new FoodDetails(data);
            Operations.foodList.Add(dept);  
            }

            string [] admission = File.ReadAllLines("Food/BookingDetails.csv");
            foreach(string dat in admission)
            {
            BookingDetails addmission = new BookingDetails(dat);
            Operations.bookList.Add(addmission);  
            }

            string [] order = File.ReadAllLines("Food/OrderDetails.csv");
            foreach(string datas in order)
            {
            OrderDetails addmissions = new OrderDetails(datas);
            Operations.orderList.Add(addmissions);  
            }
            
        }
        public static void WriteToFile()
        {
            
            string [] CustomerRegistration = new string[Operations.customerList.Count];
            for (int i=0;i<Operations.customerList.Count;i++)
            {
                CustomerRegistration[i]=Operations.customerList[i].CustomerID+","+Operations.customerList[i].Name+","+Operations.customerList[i].FatherName+","+Operations.customerList[i].Gender+","+Operations.customerList[i].Mobile+","+Operations.customerList[i].DOB+","+Operations.customerList[i].MailID+","+Operations.customerList[i].Location+","+Operations.customerList[i].WalletBalance;
            }
            File.WriteAllLines("Food/CustomerRegistration.csv",CustomerRegistration); 

            string [] FoodDetails = new string[Operations.foodList.Count];
            for (int i=0;i<Operations.foodList.Count;i++)
            {
                FoodDetails[i]=Operations.foodList[i].FoodID+","+Operations.foodList[i].FoodName+","+Operations.foodList[i].PricePerQuantity;
            }
            File.WriteAllLines("Food/FoodDetails.csv",FoodDetails);

            string [] BookingDetails = new string[Operations.bookList.Count];
            for (int i=0;i<Operations.bookList.Count;i++)
            {
                BookingDetails[i]=Operations.bookList[i].BookingID+","+Operations.bookList[i].CusdtomerID+","+Operations.bookList[i].TotalPrice+","+Operations.bookList[i].DateOfBooking+","+Operations.bookList[i].BookingStatus;
            }
            File.WriteAllLines("Food/BookingDetails.csv",BookingDetails);
            
            string [] OrderDetails = new string[Operations.orderList.Count];
            for (int i=0;i<Operations.orderList.Count;i++)
            {
                OrderDetails[i]=Operations.orderList[i].OrderID+","+Operations.orderList[i].BookingID+","+Operations.orderList[i].FoodID+","+Operations.orderList[i].PurchaseCount+","+Operations.orderList[i].PriceOfOrder;
            }
            File.WriteAllLines("Food/OrderDetails.csv",OrderDetails);
        }
    }
   
}