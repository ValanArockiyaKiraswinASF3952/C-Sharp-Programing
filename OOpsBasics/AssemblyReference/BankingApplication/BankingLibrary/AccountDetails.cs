
namespace BankingLibrary
{
    public enum Gender{Default,Male,Female,TransGender}
    public class AccountDetails
    {
        private static int s_accountnumber =1000;

          public int AccountNumber { get; }
        
       // private static _name="valan"; //Field Declaration
       // public string Name { get{return _name;} set{_name=value;} }  
        
        public string Name { get; set; }  //Auto Property
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
        public string AccountType { get; set; }
      
        public double Balance { get; set; }

        /*public AccountDetails()
        {
            Balance=0;
        }*/

        public AccountDetails(string name, string fatherName, DateTime dob, Gender gender, string accountType)
        {
            s_accountnumber++;
            AccountNumber=s_accountnumber;
            Name=name;
            FatherName=fatherName;
            DOB=dob;
            Gender=gender;
            AccountType=accountType;
            Balance=0;
        }
         //Methods
        public void Deposite()
        {
            System.Console.WriteLine("Enter the deposite amount : ");
            double deposite= double.Parse(Console.ReadLine());
            Balance += deposite;
            ShowBalance();
        }
        public void Withdraw()
        {
            System.Console.WriteLine("Enter the withdraw amount : ");
            double withdraw= double.Parse(Console.ReadLine());
            Balance -= withdraw;
            ShowBalance();

        }
        public void ShowBalance()
        {
            System.Console.WriteLine("The current balance is : "+Balance);
        }
    
    }
}