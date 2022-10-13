using System;
namespace Exercise6
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the temperature: ");
            int temperature = int.Parse(Console.ReadLine());
            if (temperature<0)
            {
                System.Console.WriteLine("Freezing Weather");
            }
            else if ((temperature>=0) && (temperature<10))
            {
                System.Console.WriteLine("Very Cold weather");
            }
            else if ((temperature>=10) && (temperature<20))
            {
                System.Console.WriteLine("Cold weather");
            }
            else if ((temperature>=20)  && (temperature<30))
            {
                System.Console.WriteLine("It's Normal");
            }
            else if ((temperature>=30) && (temperature<40))
            {
                System.Console.WriteLine("It's Hot");
            }
            else 
            {
                System.Console.WriteLine("It's Very Hot");
            }
        }
    }
}