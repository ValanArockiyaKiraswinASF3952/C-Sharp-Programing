using System;
using System.Collections.Generic;
namespace EcommerceAplplication
{
    public static class Operations
    {
        public static List<OrderDetails> customerList=new List<OrderDetails>();
        public static List<ProductDetails> productList=new List<ProductDetails>();
        public static List<CustomerDetails> userList=new List<CustomerDetails>();
        static CustomerDetails currentUser =null;

        public static void MainMenu()
        {
            string choice="yes";
            do
            {
                System.Console.WriteLine("Select The Operations To be Performed ");
                System.Console.WriteLine("Select the Options \n1.Customer Registration \n2.Login And Purchase\n3.Exit ");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        CustomerRegistration();
                        break;
                    }
                    case 2:
                    {
                        LoginAndPurchase();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine();
                        choice="no";
                        break;
                    }
                }
            }while(choice=="yes");
        }

        public static void CustomerRegistration()
        {
            System.Console.WriteLine("Enter your Name : ");
            string customerName=Console.ReadLine();
            System.Console.WriteLine("Enter the City :");
            string city =Console.ReadLine();
            System.Console.WriteLine("Enter your Phone Number :");
            long mobileNumber=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Mail ID : ");
            string mailID=Console.ReadLine();
            System.Console.WriteLine("Enter Your Wallet Balance : ");
            double walletBalance=double.Parse(Console.ReadLine());
            CustomerDetails details=new CustomerDetails(customerName,city,mobileNumber,walletBalance,mailID);
            userList.Add(details);
            System.Console.WriteLine("\nCustomerID is "+details.CustomerID);
        }
        public static void LoginAndPurchase()
        {
          
            foreach(CustomerDetails detail in userList)
            {
                System.Console.WriteLine("Enter Your Customer ID :");
                string checkID=Console.ReadLine();
               
                if(checkID==detail.CustomerID)
                {
                   
                    currentUser=detail;
                    SubMenu();

                }
                else
                {
                    System.Console.WriteLine("Invalid customer ID" );
                }
                
            }
          
        }
        public static void SubMenu()
        {
            Char choice;
            do
            {
                System.Console.WriteLine("Select The Sub Menu");
                System.Console.WriteLine("Select the Options \na.Purchase \nb.OrderHistory\nc.Cancel Order\nd.Wallet balance \ne.Exit ");
                choice=char.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 'a':
                    {
                   
                        Purchase();
                        break;
                    }
                     case 'b':
                    {
                        OrderHistory();
                        break;
                    }
                     case 'c':
                    {
                        CancelOrder();
                        break;
                    }
                     case 'd':
                    {
                        currentUser.DisplayWalletBalance();
                        break;
                    }
                     case 'e':
                    {
                        //Exit
                        break;
                    }

                }


            }while(choice!='e');
        }
        
        public static void Purchase()
        {
            System.Console.WriteLine($"Product ID \t  Prodruct Name \t  Available Stock Quantity   Price Per Quanity \t   Shipping Duration\t  ");
            System.Console.WriteLine("\n");
            foreach(ProductDetails product in productList)
            {
                System.Console.WriteLine($" {product.ProductID} \t    {product.ProductName} \t     {product.Stock}     \t  {product.Price}    \t {product.ShipingDuration} ");
      
            }            
            System.Console.WriteLine("Enter the Product ID ");
            string checkProductID=Console.ReadLine();
            
            foreach(ProductDetails product in productList)
            {
                
               if(checkProductID==product.ProductID)
               {
                    DateTime deliveryDate;
                    double totalPrice=0;
                    System.Console.WriteLine("Enter the Count of the Product ");  
                    int productCount=int.Parse(Console.ReadLine());
                    DateTime purchaseDate = DateTime.Now;
                   if(product.Stock<productCount)
                   {
                        System.Console.WriteLine("Required Count Not Available");
                       System.Console.WriteLine("Available Count "+product.Stock);
                      
                   }
                   else
                   {
                        totalPrice = (productCount*product.Price)+50;
                        if(totalPrice>currentUser.WalletBalance)
                        {
                            Console.WriteLine("Insuffecient Wallet Balance!\n Please recharge your wallet");
                        }
                        else
                        {
                            currentUser.WalletBalance = currentUser.WalletBalance-totalPrice;
                            product.Stock = product.Stock-productCount;
                            deliveryDate = purchaseDate.AddDays(product.ShipingDuration);
                            Console.WriteLine($"Order placed successfully! Your order will be delivered on {deliveryDate.ToString("dd/MM/yyyy")}");
                        }
                   }
               }
      
            }

            
        }
        public static void OrderHistory()
        {
            foreach(OrderDetails order in customerList)
            {
                System.Console.WriteLine("Enter Your Customer ID :");
                string checkID=Console.ReadLine();
                if(checkID==order.CustomerID)
                {
                    System.Console.WriteLine("");
                    System.Console.WriteLine($"{order.CustomerID}   {order.ProductID}    {order.TotalPrice}    {order.Quanity}    {order.OrderStatus}");
                }
            }
        }

        public static void CancelOrder()
        {
            OrderHistory();
            System.Console.WriteLine("Select the orderId which one you want to be canceled");
            string cancelOredrId= Console.ReadLine();
            foreach(OrderDetails order in customerList)
            {
                if(cancelOredrId==order.OrderID)
                {
                    //Increase the product availability count by the count of product purchased in the order to be cancelled.
                    foreach(ProductDetails product in productList)
                    {
                        if(order.OrderID==product.ProductID)
                        {
                            product.Stock+=order.Quanity;
                            product.Price += order.TotalPrice;
                            order.OrderStatus=OrderStatus.Canceled;
                            System.Console.WriteLine("Order cancel successfully");
                        }
                    }
                }
            }
        }
        


    }
}