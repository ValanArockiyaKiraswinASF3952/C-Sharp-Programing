using System;
namespace Ex3
{
    public enum AccountType{Default, Saving, Balance}
    public class Saving:PersonalInfo,ICalculate
    {
        private static int s_accountNumber=100000;
        public string AccountNumber { get; set; }
        public AccountType AccountType { get; set; }
        public Saving(AccountType accountType)
        {
            AccountNumber="ANO"+s_accountNumber++;
            AccountType=accountType;

        }
        int balance=0;
        public void Deposite()
        {
            System.Console.WriteLine("Enter the amount you want to deposite:");
            int deposite = int.Parse(Console.ReadLine());
            deposite+=balance;  
        }
        public void Withdraw()
        {
            System.Console.WriteLine("Enter the amount you want to Withdraw:");
            int withdraw = int.Parse(Console.ReadLine());
            withdraw+=balance;            
        }
        public void Balance()
        {
            System.Console.WriteLine("The amount Balance is:"+balance);
        }
    }
}