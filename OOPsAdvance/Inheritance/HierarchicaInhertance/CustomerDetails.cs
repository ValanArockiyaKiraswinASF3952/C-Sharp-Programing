using System;
namespace HierarchicaInhertance
{
    public class CustomerDetails:Employement
    {
        private static int s_customerId=1000;
        public string CustomerId { get; set; }
        public double Balance { get; set; }


        public CustomerDetails(string aid, string name,string fatherName, Gender gender, int phone):base(aid, name,fatherName,gender,phone)
        {
            s_customerId++;
            CustomerId="CID"+s_customerId;
        }
        public void Reacharge()
        {
            System.Console.WriteLine("Enter amount to reacharge: ");
            Balance += double.Parse(Console.ReadLine());
        }
        public void ShowCustomer()
        {
            System.Console.WriteLine("Customer Id : "+CustomerId);
            ShowDetails();
            System.Console.WriteLine("Balance Amount: "+Balance);
        }
    }
}