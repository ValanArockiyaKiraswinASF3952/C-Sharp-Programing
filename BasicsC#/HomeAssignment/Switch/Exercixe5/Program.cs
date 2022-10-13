using System;
namespace Exercise5
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the Country Name 'India', 'Pakistan', 'Bangladesh'");
            string countryName = (Console.ReadLine());
            switch (countryName)
            {
            case "India":
            System.Console.WriteLine("1.Gambir \n2.Ashwin \n3.Dhoni \n4.Jadeja");
            break;
            
            case "Pakistan":
            System.Console.WriteLine("1.Babar \n2.Afridi \n3.Amir");
            break;

            case "Bangladesh":
            System.Console.WriteLine("1.Rahman \n2.Mustafizur \n3.Saifuddin");
            break;
        
            default:
            System.Console.WriteLine("Unexpected country name");
            break;
            }
        }
    }
}