using System;
namespace OnlineGroceryStoreApplication
{
    public class CustomerDetails:PersonalDetails,IBalance
    {
        private static int s_customerID=1000;
        public string CustomerID { get; set; }
        public double WalletBalance { get; set; }

        public CustomerDetails(string name,string fatherName,Gender gender,long mobile,DateTime dob,string mailID,double walletBalance):base( name, fatherName, gender, mobile, dob, mailID)
        {
            s_customerID++;
            CustomerID="CID"+s_customerID;
            WalletBalance=walletBalance;
        }

        public CustomerDetails(string data)
        {
            string [] values = data.Split(',');
            s_customerID=int.Parse(values[0].Remove(0,3));
            CustomerID=values[0];
            Name=values[1];
            FatherName=values[2];
            Gender=Enum.Parse<Gender>(values[3]);
            Mobile=long.Parse(values[4]);
            DOB = DateTime.Parse(values[5]);
            MailID=values[6];
            WalletBalance=double.Parse(values[6]);
        }

        public void WalletReacharge()
        {
            System.Console.WriteLine("Enter the amount you want to Reacharge: ");
            double amount=double.Parse(Console.ReadLine());
            WalletBalance += amount;
            System.Console.WriteLine("The current wallet balnce is : "+WalletBalance);
        }
        public void ShowCustomerDetails()
        {
            System.Console.WriteLine("\nCustomerID      : "+CustomerID);
            System.Console.WriteLine("WalletBalance   : "+WalletBalance);
            System.Console.WriteLine("Name            : "+Name);
            System.Console.WriteLine("Father Name     : "+FatherName);
            System.Console.WriteLine("Gender          : "+Gender);
            System.Console.WriteLine("Moble number    : "+Mobile);
            System.Console.WriteLine("DOB             : "+DOB.ToString("dd/MM/yyyy"));
            System.Console.WriteLine("Mail ID         : "+MailID);
        }
    }
}