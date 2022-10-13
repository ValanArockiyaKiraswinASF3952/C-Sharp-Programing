namespace BankingLibrary;
public class Operations
{
    public static void MainMenu()
    {
        List<AccountDetails> accountHolderList = new List<AccountDetails>(); //File
        System.Console.WriteLine("Are You willing to open the Bank Account");
        Console.ReadLine();
        string willing="";
        System.Console.WriteLine("\nRead data");
            System.Console.WriteLine("Admitte");

        do
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

            System.Console.WriteLine("\nAre You willing to open the another bank account.");
            willing = Console.ReadLine().ToLower();

        }while (willing=="yes");
        
        
        foreach(AccountDetails account in accountHolderList)
        {
        System.Console.WriteLine($"\nYour Name is : {account.Name}");
        System.Console.WriteLine($"Your FatherName is : {account.FatherName}");
        System.Console.WriteLine($"Your DOB is: {account.DOB.ToString("dd/MM/yyyy")}");
        System.Console.WriteLine($"Your Gender is : {account.Gender}");
        System.Console.WriteLine($"Your accountType is : {account.AccountType}");
        System.Console.WriteLine("Bank Account Number is : "+(account.AccountNumber));
        System.Console.WriteLine($"Your balance Mark is : {account.Balance}");
        account.Deposite();
        account.Withdraw();
        }
    }
}
