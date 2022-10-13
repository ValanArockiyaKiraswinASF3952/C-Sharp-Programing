using System;
namespace Exercise5
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Test Data");
            System.Console.WriteLine("Enter the Maths mark: ");
            float mathsMark = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter the Chemistry mark: ");
            float chemistryMark = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter the Physics mark: ");
            float physicsMark = Convert.ToInt32(Console.ReadLine());

            float total = (mathsMark+chemistryMark+physicsMark);
            float percentage = ((total/600)*100);
            if (percentage>75)
            {
                System.Console.WriteLine("The Candiadate is eligible for addmision");
            }
            else
            {
                System.Console.WriteLine("The candidate is Not eligible for addmision");
            }
        }
    }
}