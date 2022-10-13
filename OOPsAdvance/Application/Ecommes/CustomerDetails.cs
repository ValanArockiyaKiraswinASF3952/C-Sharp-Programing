using System;
namespace EcommerceAplplication
{
    public class CustomerDetails
    {
         private static int s_customerID=1000;
        public string CustomerID{get;}
        public string Name{get;set;}
        public string City {get;set;}
        public long MobileNumber{get;set;}
        public double WalletBalance {get;set;}
        public string MailID{get;set;}

        public CustomerDetails(string name,string city,long mobileNumber,double walletBalance,string mailID)
        {
            s_customerID++;
            CustomerID="CID"+s_customerID;
            Name =name;
            City=city;
            MobileNumber=mobileNumber;
            WalletBalance=walletBalance;
            MailID=mailID;
        }

        public CustomerDetails(string data)
        {
            string [] values = data.Split(',');
            s_customerID=int.Parse(values[0].Remove(0,3));
            CustomerID=values[0];
            Name=values[1];
            City=values[2];
            MobileNumber=long.Parse(values[3]);
            WalletBalance=double.Parse(values[4]);
            MailID=values[5];
        }

        public void     DisplayWalletBalance()
        {
            System.Console.WriteLine("Your Current Wallet Balance Is : "+WalletBalance);
            System.Console.WriteLine("If You want to Recharge \nSay YES or NO ");
            string check=Console.ReadLine().ToUpper();
            if(check=="YES")
            {
                System.Console.WriteLine("Enter the Amount To be Recharge : ");
                double currentWalletBalance=double.Parse(Console.ReadLine());
                WalletBalance=currentWalletBalance+WalletBalance;
                System.Console.WriteLine("\n ");
                System.Console.WriteLine("Your Current Wallet Balance after Recharge : "+WalletBalance);
                System.Console.WriteLine("\n ");

            }
            
            
        }
    }
}