using System;
using System.Collections.Generic;
namespace OnlineGroceryStoreApplication;
         
class  Operations
{
      public static List<CustomerDetails> customerList = new List<CustomerDetails>();
        static CustomerDetails currentCustomer = null;

        public static List<ProductDetails> productList = new List<ProductDetails>();
        public static List<OrderDetails> orderList = new List<OrderDetails>();
       public static List<BookingDetails> bookingList = new List<BookingDetails>();
        
    
    public static void MainMenu()
    {
        AddDefaultData();
         string choice="yes";
         do
            {
                System.Console.WriteLine("You enter into the do while loop");
                // System.Console.WriteLine("Do you want to Continue");
                // choice = Console.ReadLine();
                
                System.Console.WriteLine("Select the option \n1. Customer Registration  \n2. Customer Login \n3. Exit");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        //System.Console.WriteLine("\nYou have selected Customer Registration.\n");
                        CustomerRegistration();
                        break;
                    }
                     case 2:
                    {
                        //System.Console.WriteLine("\nYou have selected Customer Login.\n");
                        CustomerLogin();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("\nYou have selected Exit MainMenu.\n");
                        choice = "no";
                        break;
                    }
                }
                
                
                
            }while(choice=="yes");
            
    }
    public static void CustomerRegistration()
    {
        System.Console.WriteLine("Customer Registration Method Call");
        System.Console.WriteLine("Enter Customer Name:");
        string name = Console.ReadLine();
        System.Console.WriteLine("Enter Father Name: ");
        string fatherName = Console.ReadLine();
        System.Console.WriteLine("Enter the Gender: ");
        Gender gender = Enum.Parse<Gender>(Console.ReadLine());
        System.Console.WriteLine("Enetr the mobile number: ");
        long mobile = long.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the DAte Of Birth");
        DateTime dob = DateTime.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the mail ID: ");
        string mailID = Console.ReadLine();
        System.Console.WriteLine("Enter the Balnce Amount; ");
        double walletBalance = double.Parse(Console.ReadLine());
        
        CustomerDetails customer = new CustomerDetails(name,fatherName,gender,mobile,dob,mailID,walletBalance);
        customerList.Add(customer);
        System.Console.WriteLine("The Customer ID is"+customer.CustomerID);
    }
    public static void CustomerLogin()
    {
        System.Console.WriteLine("Customer Login Method Call");
        System.Console.WriteLine("Enter the Customer login ID:");
        string loginId = Console.ReadLine().ToUpper();
        bool flag = true;
        foreach(CustomerDetails customer in customerList)
            {
                if(loginId==customer.CustomerID)
                {
                    System.Console.WriteLine("Login Successfull");
                    flag = false;
                    currentCustomer=customer;
                    SubMenu();
                    
                }
            }
            if(flag)
            {
                System.Console.WriteLine("Invalid UserID");
            }
    }
    public static void SubMenu()
    {
        string choice = "yes";
        do
        {
        System.Console.WriteLine("Select the option \n1.Show Customer Details \n2.Show Product Details \n3.Wallet Recharge \n4.Take Order \n5.Modify Order Quantity  \n6.Cancel Order \n7.Exit");
        int option = int.Parse(Console.ReadLine());
        
        switch(option)
        {
            case 1:
            {
                System.Console.WriteLine("Show Customer Details");
                currentCustomer.ShowCustomerDetails();
                break;
            }
            case 2:
            {
                System.Console.WriteLine("Show Product Details");
                ShowProductDetails();
                break;
            }
            case 3:
            {
                System.Console.WriteLine("Wallet Recharge");
                currentCustomer.WalletReacharge();
                break;
            }
            case 4:
            {
                System.Console.WriteLine("Take Order");
                TakeOrder();
                break;
            }
            case 5:
            {
                System.Console.WriteLine("Modify Order Quantity");
                ModifyOrder();
                break;
            }
            case 6:
            {
                System.Console.WriteLine("Cancel Order");
                CancelOrder();
                break;
            }
            case 7:
            {
                System.Console.WriteLine("Exit SubMenu");
                choice = "no";
                break;
            }
        }
    }while(choice=="yes");
    }
    public static void AddDefaultData()
    {
        //Customer Details Default Data
        CustomerDetails customer1 = new CustomerDetails("Ravi","Ettapparajan",Gender.Male,974774646,new DateTime(1999,11,11),"ravi@gmail.com",10000 );
        //customer1.ShowCustomerDetails();
        customerList.Add(customer1);
        CustomerDetails customer2 = new CustomerDetails("Baskaran","Sethurajan",Gender.Male,847575775,new DateTime(1999,11,11),"baskaran@gmail.com",15000);
        customerList.Add(customer2);
        //customer2.ShowCustomerDetails();

        

        //Product Details Default Data
        ProductDetails product1 = new ProductDetails("Sugar",20,40);
        ProductDetails product2 = new ProductDetails("Rice",100,50);
        ProductDetails product3 = new ProductDetails("Milk",10,40);
        ProductDetails product4 = new ProductDetails("Coffee",10,10);
        ProductDetails product5 = new ProductDetails("Tea",10,10);
        ProductDetails product6 = new ProductDetails("Masala Powder",10,20);
        ProductDetails product7 = new ProductDetails("Salt",10,10);
        ProductDetails product8 = new ProductDetails("Turmeric Powder",10,25);
        ProductDetails product9 = new ProductDetails("Chilli Powderr",10,20);
        ProductDetails product10 = new ProductDetails("Groundnut Oil",10,140);
        // product1.ShowProductDetails();
        // product2.ShowProductDetails();
        // product3.ShowProductDetails();
        // product4.ShowProductDetails();
        // product5.ShowProductDetails();
        // product6.ShowProductDetails();
        // product7.ShowProductDetails();
        // product8.ShowProductDetails();
        // product9.ShowProductDetails();
        // product10.ShowProductDetails();
        productList.Add(product1);
        productList.Add(product2);
        productList.Add(product3);
        productList.Add(product4);
        productList.Add(product5);
        productList.Add(product6);
        productList.Add(product7);
        productList.Add(product8);
        productList.Add(product9);
        productList.Add(product10);



        //Booking Details Default Data
        BookingDetails booking1 = new BookingDetails("CID3001",220,new DateTime(2022,07,26),BookingStatus.Booked);
        BookingDetails booking2 = new BookingDetails("CID3002",400,new DateTime(2022,07,26),BookingStatus.Booked);
        BookingDetails booking3 = new BookingDetails("CID3003",280,new DateTime(2022,07,26),BookingStatus.Cancelled);
        BookingDetails booking4 = new BookingDetails("CID3004",0,new DateTime(2022,07,26),BookingStatus.Initiated);
        // booking1.ShowBookingDetails();
        // booking2.ShowBookingDetails();
        // booking3.ShowBookingDetails();
        // booking4.ShowBookingDetails();
        bookingList.Add(booking1);
        bookingList.Add(booking2);
        bookingList.Add(booking3);
        bookingList.Add(booking4);
        

        //Order Details Default Data
        OrderDetails order1 = new OrderDetails("BID3001","PID101",2,80);
        OrderDetails order2 = new OrderDetails("BID3001","PID102",2,100);
        OrderDetails order3 = new OrderDetails("BID3001","PID103",1,40);
        OrderDetails order4 = new OrderDetails("BID3002","PID101",1,40);
        OrderDetails order5 = new OrderDetails("BID3002","PID102",4,200);
        OrderDetails order6 = new OrderDetails("BID3002","PID110",1,140);
        OrderDetails order7 = new OrderDetails("BID3002","PID109",1,20);
        OrderDetails order8 = new OrderDetails("BID3003","PID102",2,100);
        OrderDetails order9 = new OrderDetails("BID3003","PID108",4,100);
        OrderDetails order10 = new OrderDetails("BID3003","PID101",2,80);
        
        orderList.Add(order1);
        orderList.Add(order2);
        orderList.Add(order3);
        orderList.Add(order4);
        orderList.Add(order5);
        orderList.Add(order6);
        orderList.Add(order7);
        orderList.Add(order8);
        orderList.Add(order9);
        orderList.Add(order10);
    }

    public static void ShowProductDetails()
    {
        System.Console.WriteLine("Show Product Details");
        foreach(ProductDetails product in productList)
            {
                product.ShowProductDetails();
            }
    }

    public static void TakeOrder()
    {
        double totalPrice=0;

        System.Console.WriteLine("Take Order");
        //Create a booking object
        BookingDetails booking = new BookingDetails(currentCustomer.CustomerID,0,DateTime.Now,BookingStatus.Initiated);
        List<OrderDetails> tempOrderList = new List<OrderDetails>();
        string choice = "yes";
        do
        {
        //Show the product details
        ShowProductDetails();
        //select the product & check the Product
        System.Console.WriteLine("Select the product from above list in ProductID: ");
        string productId = Console.ReadLine().ToUpper();
        bool temp =true;
        foreach(ProductDetails product in productList)
            {
                if(productId==product.ProductID)
                {
                    temp = false;
                    //Get the quqntity and compare wuth availability
                    System.Console.WriteLine("Select the quantity from above list in the product: ");
                    int quantity = int.Parse(Console.ReadLine());
                    
                    if(quantity<=product.QuantityAvailable)
                    {
                        product.QuantityAvailable -= quantity;
                        //calculate the price and compare with customer wallet
                        double totalAmount = (double) quantity*product.PricePerQuantity;
                         
                       
                            //Take order & create Object & add in local order list.
                            OrderDetails order = new OrderDetails(booking.BookingID,product.ProductID,quantity,totalAmount);
                            tempOrderList.Add(order);
                            System.Console.WriteLine("Order Conformed Sucessfully");
                      
                         
                    }
                    else
                    {
                        System.Console.WriteLine("Invalid count");
                    }
                }
                if(temp)
                {
                    System.Console.WriteLine("Invalid Product ID");
                    break;
                    

                }
            }
            System.Console.WriteLine("");
            System.Console.WriteLine("Do you want another product to card.");
            choice = Console.ReadLine();
            
        }while(choice=="yes");

        foreach(OrderDetails order in tempOrderList)
        {
            totalPrice += order.PriceOfOrder; 
        }

        System.Console.WriteLine("Do you want to Booked the product(yes/no)");
        string option = Console.ReadLine();
        
        if(option=="yes")
        {
            //string choice="yes";
            while(choice=="yes")
            {
                if(totalPrice<=currentCustomer.WalletBalance)
                {
                    currentCustomer.WalletBalance-=totalPrice;
                    booking.BookingStatus=BookingStatus.Booked;
                    booking.TotalPrice=totalPrice;
                    bookingList.Add(booking);
                    orderList.AddRange(tempOrderList);
                    System.Console.WriteLine("booking Conformed; "+booking.BookingID);
                    choice="no";
                }
                else
                {
                    double sufficientAmount = totalPrice-currentCustomer.WalletBalance;
                    System.Console.WriteLine("Balance is Insufficient \nThe Amount you want is :"+sufficientAmount);
                    System.Console.WriteLine("Please Reacharge your Wallet");
                    currentCustomer.WalletReacharge();
                }
            }        
        }
        else
        {
            int flag=0;
            foreach(OrderDetails order in orderList)
            {
                foreach(ProductDetails product in productList)
                {
                    if(order.ProductID==product.ProductID)
                    {
                        product.QuantityAvailable += order.PurchaseCount;
                    }
                }
            }
            if(flag==0)
            {
                System.Console.WriteLine("Card Deleted Succcessfully");
            }
        }
    }
    public static void ModifyOrder()
    {
        System.Console.WriteLine("Modify Order");
    }

    public static void CancelOrder()
    {
        System.Console.WriteLine("Modify Order");
    }
}