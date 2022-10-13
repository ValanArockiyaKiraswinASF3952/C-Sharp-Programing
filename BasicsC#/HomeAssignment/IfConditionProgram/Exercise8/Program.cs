using System;
namespace Exercise8
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the Sugar Level: ");
            int sugarLevel = int.Parse(Console.ReadLine());
            
            if (sugarLevel<90)
            {
                System.Console.WriteLine("Low sugar");
            }
            else if ((sugarLevel>=90) && (sugarLevel<130))
            {
                System.Console.WriteLine("Normal");
            }
            else if ((sugarLevel>=130) && (sugarLevel<140))
            {
                System.Console.WriteLine("Medium");
            }
            else if ((sugarLevel>=140) && (sugarLevel<170))
            {
                System.Console.WriteLine("High sugar – Try to reduce it from now");
            }
            else
            {
                System.Console.WriteLine("You are a very high Sugar Patient ");
            }
        }
    }
}