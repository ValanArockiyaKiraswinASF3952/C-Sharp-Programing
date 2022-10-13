using System;
namespace EbBill
{
    public class CustomerDetails
    {
        private static int s_meterID=1000;
        public string MeterID { get;  }
        
        public string Name { get; set; }  
        public long Phone { get; set; }
        public string Mail { get; set; }
        public int Unit { get; set; }
        public CustomerDetails(string name, string mail, long phone)
        {
            s_meterID++;
            MeterID="EB"+s_meterID;
            Name=name;
            Mail=mail;
            Phone=phone;
        }
        public void CalculateAmount()
        {          
            if (Unit<=100)
            {
                System.Console.WriteLine("Calulate Amount is Free");
            }
            else if (Unit>100 && Unit<=200)
            {
                System.Console.WriteLine("Calculat amount is "+ Unit*3);
            }
            else if (Unit>200 && Unit<=400)
            {
                System.Console.WriteLine("Calculat amount is "+ Unit*5);
            }
            else
            {
                System.Console.WriteLine("Calculat amount is "+ Unit*6);
            }
        }
        public void ShowDetails()
        {
            System.Console.WriteLine("\nMeter ID is: "+(MeterID));
        System.Console.WriteLine($"Coustomer Name is {Name}");
        System.Console.WriteLine($"Coustomer Phone number is {Phone}");
        System.Console.WriteLine($"Coustomer mail is {Mail}");
        }

        public void GetUnit()
        {
            System.Console.WriteLine("Enter the number of unit used : ");
            int units = int.Parse(Console.ReadLine());
            Unit +=units;
        }
    }
}