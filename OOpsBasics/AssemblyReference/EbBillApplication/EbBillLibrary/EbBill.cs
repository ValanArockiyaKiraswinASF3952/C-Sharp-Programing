using System;
namespace EbBillLibrary
{
    public class CustomerDetails
    {
        private static int s_meterID=1000;
        public string MeterID { get;  }
        
        public string Name { get; set; }  
        public long Phone { get; set; }
        public string Mail { get; set; }
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
            System.Console.WriteLine("Enter Unit used");
            int calculateAmount = int.Parse(Console.ReadLine());
            if (calculateAmount<=100)
            {
                System.Console.WriteLine("Calulate Amount is Free");
            }
            else if (calculateAmount>100 && calculateAmount<=200)
            {
                System.Console.WriteLine("Calculat amount is "+ calculateAmount*3);
            }
            else if (calculateAmount>200 && calculateAmount<=400)
            {
                System.Console.WriteLine("Calculat amount is "+ calculateAmount*5);
            }
            else
            {
                System.Console.WriteLine("Calculat amount is "+ calculateAmount*6);
            }
        }
    }
}