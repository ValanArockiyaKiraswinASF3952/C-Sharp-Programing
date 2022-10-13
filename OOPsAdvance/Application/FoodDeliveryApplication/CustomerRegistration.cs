using System;
using System.IO;
namespace FoodDeliveryApplication
{
    public class CustomerRegistration:PersonalDetails,IBalance
    {
        
        private static int s_customerID=10000;
        public string CustomerID { get; set; }
        public double WalletBalance { get; set; }

        public CustomerRegistration(string name, string fatherName, Gender gender, long mobile, DateTime dob, string mailID, string location,double walletBalance):base( name,  fatherName,  gender,  mobile,  dob,  mailID,  location)
        {
            s_customerID++;
            CustomerID="CID"+s_customerID;
            WalletBalance=walletBalance;
        }
        
        public CustomerRegistration(string data):base( data)
       {
        string [] values = data.Split(',');
        s_customerID=int.Parse(values[0].Remove(0,3));
        CustomerID=values[0];
         
        WalletBalance=double.Parse(values[8]);
       }
        public void WalletReacharge()
        {
            System.Console.WriteLine("Enter amount to reacharge: ");
            WalletBalance = double.Parse(Console.ReadLine());
        }
        
        public void ShowCustomerRegistration()
        {
            //System.Console.WriteLine("Your customer ID is : "+CusdtomerID);
            WalletReacharge();            
            ShowPersonalDetails();
        }
    }
}