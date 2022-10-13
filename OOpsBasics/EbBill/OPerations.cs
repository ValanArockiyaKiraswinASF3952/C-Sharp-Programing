using System;
using System.Collections.Generic;
namespace EbBill;
public class Operations 
{
    static CustomerDetails currentCustomer=null;
    static List<CustomerDetails> customerList = new List<CustomerDetails>(); 
    public static void MainMenu()
    {
       string choice = "yes";
            do
            {
            System.Console.WriteLine("Select Option 1.Registration 2.Login 3.Exit ");
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
                    System.Console.WriteLine("Exit");
                    choice="no";
                    break;
                }
            }
            }while(choice=="yes");
    }

        public static void Registration()
        {
            System.Console.WriteLine("EB Bill Details\n");
            System.Console.WriteLine("Enter Name : ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter Phone number : ");
            long phone = long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter mail ID : ");
            string mail = Console.ReadLine();
    
            CustomerDetails customer1 = new CustomerDetails(name,mail,phone); 

            customerList.Add(customer1);

            System.Console.WriteLine("Meter ID is: "+(customer1.MeterID));
        }
    
    public static void Login()
    {
        System.Console.WriteLine("Enter your Registration Number: ");
        string customerNumber = Console.ReadLine().ToUpper();
        foreach (CustomerDetails customer in customerList)
        {
            if (customer.MeterID==customerNumber)
            {
                System.Console.WriteLine("Login successful");
                currentCustomer=customer;
                SubMenu();
            
            }
        }
    }

    public static void SubMenu()
    {
        string choice="yes";
            do{
                System.Console.WriteLine("Select SubMenu Options");
                System.Console.WriteLine("1.Show Details 2.Enter number of Unit 3.Calculate Bill 4.Exit");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Show Details");
                        currentCustomer.ShowDetails();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Enter Number of Unit");
                        currentCustomer.GetUnit();
                    
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Calculate Bill");
                        currentCustomer.CalculateAmount();
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Exit");
                        choice ="no";
                        break;
                    }
                }
            }while(choice=="yes");
    }
}
