using System;
namespace Exercise3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Amount of Celsius : ");
            float celsius = float.Parse(Console.ReadLine());
            float kelvin = (float) celsius + 273;
            float fahrenhiet = (float) ((celsius * 9/5) + 32 );
            Console.WriteLine("Fahrenhiet = "+fahrenhiet);
            Console.WriteLine("Kelvin = "+kelvin);

        }
    }
}