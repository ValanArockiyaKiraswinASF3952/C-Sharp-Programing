using System;
using System.Collections.Generic;
namespace EbBillLibrary;
class Program 
{
    public static void Main(string[] args)
    {
        List<CustomerDetails> customerList = new List<CustomerDetails>(); 
        System.Console.WriteLine("\nEB Bill Calculation.");
        string willing = "";

        do
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

            System.Console.WriteLine("Are you enter another EB customer details :");
            willing = Console.ReadLine().ToLower();

        }while (willing=="yes");
        
        foreach(CustomerDetails customer in customerList)
        {
        System.Console.WriteLine("\nMeter ID is: "+(customer.MeterID));
        System.Console.WriteLine($"Coustomer Name is {customer.Name}");
        System.Console.WriteLine($"Coustomer Phone number is {customer.Phone}");
        System.Console.WriteLine($"Coustomer mail is {customer.Mail}");
        
        customer.CalculateAmount();
        }
    }
}
