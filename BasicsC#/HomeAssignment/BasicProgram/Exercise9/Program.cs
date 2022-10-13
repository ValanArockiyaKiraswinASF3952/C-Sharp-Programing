using System;
namespace Exercise9
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the speed value: ");
            double speed = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the time value: ");
            double time = Convert.ToDouble(Console.ReadLine());
            double distanceTravelled = speed*time*5/18;
            System.Console.WriteLine($"Input speed: {speed}km/h");
            System.Console.WriteLine($"Time: {time}sec");
            System.Console.WriteLine($"Output : {Math.Round(distanceTravelled)} Meters");


        }
    }
}