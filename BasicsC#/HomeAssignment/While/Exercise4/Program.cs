using System;
namespace Exercise4
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number=0,flag=0;
            System.Console.WriteLine("Enter the number: ");
            bool result =int.TryParse(Console.ReadLine(),out number);
            while (result!=true)
            {
                System.Console.WriteLine("Invailid Number.");
                System.Console.WriteLine("Enter the number again: ");
                result =int.TryParse(Console.ReadLine(),out number);

            }
            if (number<=5 && number>=1)
            {
                flag=1;
            }
            if (flag==1)
            {
                System.Console.WriteLine("It is valid.");
                System.Console.WriteLine("It is present in range");
            }
            else
            {
                System.Console.WriteLine("It is Invalid.");
                
            }
              
        }
    }
}