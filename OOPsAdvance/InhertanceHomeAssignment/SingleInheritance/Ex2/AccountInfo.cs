using System;
namespace Ex2
{
    public class AccountInfo:PersonalInfo
    {
        private static int s_accountId =1000;
        public string AccountID { get; set; }
        public string Branch { get; set; }
        public string IfscCode { get; set; }
        public int Balance { get; set; }

        public AccountInfo(string name, string fatherName, int phone, string mail, DateTime dob, string gender,string branch, string ifscCode):base( name, fatherName,phone, mail, dob, gender)
        {
            AccountID="AID"+s_accountId++;
            Branch=branch;
            IfscCode=ifscCode;
        }
        public void BalanceCheck()
        {
            System.Console.WriteLine("Enter the Balance:");
            Balance+=int.Parse(Console.ReadLine());
            System.Console.WriteLine("The Account Balance :"+Balance);        
            
        }

        public void ShowDetails()
        {
            System.Console.WriteLine("Enter the Account Id: "+AccountID);
            Show();
            System.Console.WriteLine("Enter the Branch: "+Branch);
            System.Console.WriteLine("Enter the ifsc code: "+IfscCode);

        }
    }
}