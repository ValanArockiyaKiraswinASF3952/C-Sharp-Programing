using System;
using System.Collections;
namespace FoodDeliveryApplication
{
    public static class Operations
    {
        static CustomerRegistration currentCustomer=null;
        static FoodDetails currentFood=null;
        // static BookingDetails currentBooking=null;
        // static OrderDetails currentOrder=null;

        public static List<CustomerRegistration> customerList = new List<CustomerRegistration>();
        public static List<FoodDetails> foodList = new List<FoodDetails>();
        public static  List<BookingDetails> bookList = new List<BookingDetails>();
        public static  List<OrderDetails> orderList = new List<OrderDetails>();

        public static void MainMenu()
        {
            string choice = "yes";
            do
            {
            System.Console.WriteLine("Select Option 1.Customer Registration 2.Customer Login 3.Exit ");
            int option = int.Parse(Console.ReadLine());
            
            switch (option)
            {
                case 1:
                {
                    System.Console.WriteLine("Customer Registration");
                    Registration();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Customer Login");
                    Login();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Exit");
                    choice="no";
                    break;
                }
            }
            }while(choice=="yes");

        }   

        // public static void DefaultValues()
        // {
        //     CustomerRegistration customer1 = new CustomerRegistration("Ravi","Ettapparajan",Gender.Male,974774646,new DateTime(11/11/1999),"ravi@gmail.com","Chennai",10000);
        //     customerList.Add(customer1);

        //     FoodDetails food1 = new FoodDetails("Chicken Biriyani",100);
        //     foodList.Add(food1);
        //     FoodDetails food2 = new FoodDetails("Mutton Biriyani",150);
        //     foodList.Add(food2);

        //     BookingDetails book1 = new BookingDetails("CID3001",580,new DateTime(26/07/2022),BookingStatus.Booked);
        //     bookList.Add(book1);

        //     OrderDetails order1 = new OrderDetails("BID3001","FID101",2,200);
        //     orderList.Add(order1);
        // }
        public static void Registration()
        {
            System.Console.WriteLine("Enter amount to reacharge: ");
            double walletBalance = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the name: ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter the father name: ");
            string fatherName = Console.ReadLine();
            System.Console.WriteLine("Enter the gender: ");
            Gender gender = Enum.Parse<Gender>(System.Console.ReadLine());
            System.Console.WriteLine("Enter the Mobile number: ");
            long mobile = long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the DOB: ");
            DateTime dob = DateTime.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the Mail ID: ");
            string mailID = Console.ReadLine();
            System.Console.WriteLine("Enter the Location: ");
            string location = Console.ReadLine();

            CustomerRegistration customer2 = new CustomerRegistration(name,fatherName,gender,mobile,dob,mailID,location,walletBalance);
            customerList.Add(customer2);
            //currentCustomer.ShowCustomerRegistration();
            System.Console.WriteLine("Your customer ID is : "+customer2.CustomerID);

        }
        public static void Login()
        {
            System.Console.WriteLine("Enter your Registration Number: ");
            string customerId = Console.ReadLine().ToUpper();
            foreach(CustomerRegistration customer in customerList)
            {
                if (customer.CustomerID==customerId)
                {
                    System.Console.WriteLine("Login Successful");
                    currentCustomer=customer;
                    SubMenu();
                }
                else
                {
                    System.Console.WriteLine("Invalid CustomerID");
                    break;
                }
            }
        }
        public static void SubMenu()
        {
            string choice="yes";
            do{
                System.Console.WriteLine("Select SubMenu Options");
                System.Console.WriteLine("1.Show Food Item Details 2.Order Food 3.Cancel Order 4.Cancel Booking 5.Order History 6.Reacharge Wallet 7.Exit");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Show Food Item Details");
                        ShowFoodIdemDetails();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Order Food");
                        
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Cancel Order");
                       
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Cancel Booking");
                        break;
                    }
                    case 5:
                    {
                        System.Console.WriteLine("Order History");
                        break;
                    }
                    case 6:
                    {
                        System.Console.WriteLine("Reacharge Wallet");
                        break;
                    }
                    case 7:
                    {
                        System.Console.WriteLine("Exit SubMenu");
                        choice="no";
                        break;
                    }
                }
            }while(choice=="yes");
        }
        public static void ShowFoodIdemDetails()
        {
            foreach(FoodDetails food in foodList)
            {
                System.Console.WriteLine($"{food.FoodID}           {food.FoodName}                   {food.PricePerQuantity}");
            }
        }
        public static void OrderFood()
        {
            double totalPrice=0;
            string choice="yes";
            List<BookingDetails> booksList = new List<BookingDetails>();
            BookingDetails book = new BookingDetails(currentCustomer.CustomerID,0,DateTime.Now,BookingStatus.Initiated);
           do
           {
                foreach (FoodDetails food in foodList)
                {
                    currentFood.ShowFoodDetails();
                }
                System.Console.WriteLine("Which Food you want to bye entyer the Food ID:");
                string foodId = Console.ReadLine();
                foreach (FoodDetails food in foodList)
                {
                    if(foodId==food.FoodID)
                    {
                        System.Console.WriteLine("Enter the quantity of the food: ");
                        int quantity=int.Parse(Console.ReadLine());
                        
                        if(quantity==food.PricePerQuantity)
                        {
                            totalPrice = quantity*food.PricePerQuantity;
                            if(totalPrice<=currentCustomer.WalletBalance)
                            {
                                OrderDetails order = new OrderDetails(book.BookingID,food.FoodID,quantity,totalPrice);
                                orderList.Add(order);
                                currentCustomer.WalletBalance-=totalPrice;
                                System.Console.WriteLine("Booking Successfull -- booking ID :"+book.BookingID);
                            }
                        }
                    }
                }
                System.Console.WriteLine("Do you want to purchase another food (yes/no)");

                choice = Console.ReadLine();
                

           }while(choice=="yes");

           foreach(BookingDetails booking in bookList)
           {
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
                    // bookingList.Add(booking);
                    // orderList.AddRange(tempOrderList);
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
                foreach(FoodDetails food in foodList)
                {
                    if(order.FoodID==food.FoodID)
                    {
                        food.PricePerQuantity += order.PurchaseCount;
                    }
                }
            }
            if(flag==0)
            {
                System.Console.WriteLine("Card Deleted Succcessfully");
            }
        }
           }

        }

    }
}