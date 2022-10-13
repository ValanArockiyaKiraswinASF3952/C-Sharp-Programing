using System;
namespace OnlineMediaStore
{
    public static class Operations
    {
        static UserDetails currentUser=null;
        static MedicineDetails currentMedicine=null;
        static OrderDetails currentOrder=null;

       
        public static List<OrderDetails> orderList = new List<OrderDetails>();
        public static List<UserDetails> userList = new List<UserDetails>();
        public static List<MedicineDetails> medicineList = new List<MedicineDetails>();
        public static void MainMenu()
        {
            string choice = "yes";
            do
            {
            System.Console.WriteLine("Select Option 1.Registration 2.Login 3.Show Order History 4.Exit ");
            int option = int.Parse(Console.ReadLine());
            
            switch (option)
            {
                case 1:
                {
                    System.Console.WriteLine("Registration");
                    Registration();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Login");
                    Login();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Show Order History");
                    ShowOrder();
                    break;
                }
                case 4:
                {
                    System.Console.WriteLine("Exit");
                    choice="no";
                    break;
                }
            }
            }while(choice=="yes");
        }
        
        public static void Registration()
        {
            System.Console.WriteLine("UserDetails \n");
            System.Console.WriteLine("Enter Name : ");
            string userName = Console.ReadLine();
            System.Console.WriteLine("Enter Age: ");
            int age = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter City: ");
            string city = Console.ReadLine();            
            System.Console.WriteLine("Enter Phone number : ");
            long phoneNumber = long.Parse(Console.ReadLine());
            System.Console.WriteLine("ENter amount: ");
            int balance = int.Parse(Console.ReadLine());

            UserDetails user = new UserDetails(userName,age,city,phoneNumber,balance);
            userList.Add(user);
            
            System.Console.WriteLine("Register number is: "+(user.UserID));
            System.Console.WriteLine("\nUser Added Successfully and UserID – "+(user.UserID));
        }

        public static void Login()
        {
            System.Console.WriteLine("Enter your Registration Number: ");
            string UserID = Console.ReadLine().ToUpper();
            foreach(UserDetails user in userList)
            {
                if (user.UserID==UserID)
                {
                    System.Console.WriteLine("Login Successful");
                    currentUser=user;
                    SubMenu();
                }
            }
        }

        public static void SubMenu()
        {
            string choice="yes";
            do{
                System.Console.WriteLine("Select SubMenu Options");
                System.Console.WriteLine("a.Show Medicine List b.Purchase Medicine c.Cancel Purchase d.Show Purchase History e.Recharge f.Exit");
                char option = char.Parse(Console.ReadLine());
                switch(option)
                {
                    case 'a':
                    {
                        System.Console.WriteLine("Show Medicine List");
                        ShowMedicine();
                        break;
                    }
                    case 'b':
                    {
                        System.Console.WriteLine("Purchase Medicine");
                        PurchaseMedicine();
                        break;
                    }
                    case 'c':
                    {
                        System.Console.WriteLine("Cancel Purchase");
                        CancelOrder();
                        break;
                    }
                    case 'd':
                    {
                        System.Console.WriteLine("Show Purchase History");
                        ShowOrder();
                        break;
                    }
                    case 'e':
                    {
                        System.Console.WriteLine("Recharge");
                        Recharge();
                        break;
                    }
                    case 'f':
                    {
                        System.Console.WriteLine("Exit SubMenu");
                        choice="no";
                        break;
                    }
                }
            }while(choice=="yes");
        }

        public static void ShowMedicine()
        {
            foreach (MedicineDetails medicine in medicineList)
            {
                System.Console.WriteLine("The medicine details ");
                System.Console.WriteLine(medicine.MedicineID+"\t"+medicine.AvilableCount+"\t"+medicine.Price+"\t"+medicine.DateOfExpiry);
            }
        }

        public static void PurchaseMedicine()
        {
            foreach (MedicineDetails medicine in medicineList)
            {
                System.Console.WriteLine("The medicine details ");
                System.Console.WriteLine(medicine.MedicineID+"\t"+medicine.AvilableCount+"\t"+medicine.Price+"\t"+medicine.DateOfExpiry);
            }

            System.Console.WriteLine("Enter medicine ID which medicine you want to bye");
            string medicineID = Console.ReadLine();
            foreach(MedicineDetails medicine in medicineList)
            {
                if(medicineID==medicine.MedicineID)
                {
                    currentMedicine=medicine;
                    System.Console.WriteLine("Enter the Number of Medicine You Want  ");
                    int selectNumber=int.Parse(Console.ReadLine());
                    if(selectNumber<currentMedicine.AvilableCount && selectNumber>0)
                    {
                        int totalPrice1=currentMedicine.Price*selectNumber;
                        if(currentUser.Balance>totalPrice1)
                        {
                            currentMedicine.AvilableCount--;
                            currentUser.Balance=currentUser.Balance-totalPrice1;
                            OrderDetails order=new OrderDetails(currentUser.UserID,currentMedicine.MedicineID,currentMedicine.AvilableCount,totalPrice1,DateTime.Now,OrderStatus.Purchased);
                            orderList.Add(order);
                            System.Console.WriteLine(currentMedicine.AvilableCount);
                            System.Console.WriteLine("Medicine Purchased Successfully");
                        }
                        else{
                        System.Console.WriteLine("You Don't have a Money to Buy");
                        }
                   
                        Recharge();
                    }


                }
            }
        }

        public static void ShowOrder()
        {
            foreach(OrderDetails order in orderList)
            {
                System.Console.WriteLine(order.OrderDate+" "+order.MedicineID+" "+order.TotalPrice+" "+order.OrderDate+" "+order.OrderStatus);

            }
        }

        public static void Recharge()
        {
            System.Console.WriteLine("Before Recharge :"+currentUser.Balance);
            string choice1="";
            System.Console.WriteLine("Do you Want to Recharge");
            choice1=Console.ReadLine();

            
            while(choice1=="yes")
            {
                
                System.Console.WriteLine("Enter the Amount to rechare");
                int topUp=int.Parse(Console.ReadLine());
                currentUser.Balance+=topUp;
                System.Console.WriteLine("After Rechareg :"+currentUser.Balance);

                System.Console.WriteLine("Do you want to recharge again");
                choice1=Console.ReadLine();
                

            }
        }
    
    public static void CancelOrder()
        {
            
            
            foreach(OrderDetails order in orderList)
            {
                if(currentUser.UserID==order.UserID)
                {
                    currentOrder=order;
                    System.Console.WriteLine(currentOrder.OrderID+" "+currentOrder.UserID+" "+currentOrder.MedicineID+" "+currentOrder.MedicineCount+" "+currentOrder.TotalPrice+" "+currentOrder.OrderDate+" "+currentOrder.OrderStatus);
                    System.Console.WriteLine("Select the OrderId to cancel");
                    string tempId=Console.ReadLine();
                    if(tempId==currentOrder.OrderID)
                    {
                        if(currentOrder.OrderStatus==OrderStatus.Purchased)
                        {
                           foreach(MedicineDetails medicine in medicineList)
                           {
                            if(order.MedicineID==medicine.MedicineID)
                            {
                                
                                currentMedicine=medicine;
                                
                            }
                           }
                           currentMedicine.AvilableCount++;
                           currentOrder.OrderStatus=OrderStatus.Cancelled;            
                           currentUser.Balance=currentUser.Balance+currentOrder.TotalPrice;
                           System.Console.WriteLine(currentMedicine.AvilableCount);
                           System.Console.WriteLine(currentUser.Balance);        
                        }
                        
                        
                        
                    }
                }
            }
           
            

        }
    
    }
}