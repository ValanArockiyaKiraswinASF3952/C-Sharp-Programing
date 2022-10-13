using System;
namespace Exercise4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius value: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the height value: ");
            double height = Convert.ToDouble(Console.ReadLine());
            double volumeCylinder = (3.14*radius*radius*height);
            System.Console.WriteLine($"The volume of Cylinder value is : {volumeCylinder}");
        }
    }
}