using System;
using System.Collections.Generic;
namespace BankDetails;
public static class Operations 
{
    static int Balance=0;
    static AccountDetails currentAccount = null;
    static List<AccountDetails> accountHolderList = new List<AccountDetails>(); //File
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
            System.Console.WriteLine("\nEnter your Account Details \n");
            System.Console.WriteLine("Enter Name : ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter Father Name : ");
            string fatherName = Console.ReadLine();
            System.Console.WriteLine("Enter DOB dd/MM/yyyy: ");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.WriteLine("Enter gender: ");
            Gender gender =Enum.Parse<Gender>( Console.ReadLine(),true);
            System.Console.WriteLine("Enter Account Type (savings/current): ");
            string accountType = Console.ReadLine();           

            AccountDetails account1 = new AccountDetails(name,fatherName,dob,gender,accountType);  //Application form printout

            accountHolderList.Add(account1);

            System.Console.WriteLine("Bank Account Number is "+(account1.AccountNumber));

        }
        public static void Login()
        {
            System.Console.WriteLine("Enter your Account Number: ");
            string accountNumber = Console.ReadLine().ToUpper();
            foreach(AccountDetails account in accountHolderList)
            {
                if (account.AccountNumber==accountNumber)
                {
                    System.Console.WriteLine("Login Successful");
                    currentAccount=account;
                    SubMenu();
                }
            }
        }
        public static void SubMenu()
        {
            string choice="yes";
            do{
                System.Console.WriteLine("Select SubMenu Options");
                System.Console.WriteLine("1.Show Details 2.Check Balance 3.Exit");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Show Details");
                        currentAccount.ShowDetails();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Check Balance");                        
                          System.Console.WriteLine("Enter the deposite amount : ");
                               int deposite=int.Parse(Console.ReadLine());
                         Balance += deposite;                    
                         System.Console.WriteLine("Enter the withdraw amount : ");
                            int withdraw=int.Parse(Console.ReadLine());
                            Balance -= withdraw;       
                        System.Console.WriteLine("The current balance is : "+Balance);
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Exit SubMenu");
                        choice="no";
                        break;
                    }
                }
            }while(choice=="yes");
    }
}
  