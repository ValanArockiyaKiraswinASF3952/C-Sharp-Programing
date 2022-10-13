using System;
namespace Exercise8
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the meter value: ");
            double meter = Convert.ToDouble(Console.ReadLine());
            
            double centiMeterValue = meter*100;
            double milliMeterValue = centiMeterValue*100;
            double inchValue = milliMeterValue*100;
            double footValue = inchValue*100;
            double mileValue = footValue*100;

            System.Console.WriteLine($"The centimeter value of {meter} is {centiMeterValue}");
            System.Console.WriteLine($"The centimeter value of {meter} is {milliMeterValue}");
            System.Console.WriteLine($"The centimeter value of {meter} is {inchValue}");
            System.Console.WriteLine($"The centimeter value of {meter} is {footValue}");
            System.Console.WriteLine($"The centimeter value of {meter} is {mileValue}");




        }
    }
}