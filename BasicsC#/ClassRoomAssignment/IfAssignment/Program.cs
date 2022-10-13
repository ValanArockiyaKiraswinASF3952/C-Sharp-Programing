using System;
namespace GradeMark
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the input: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if ((a>80) && (a<100))
            {
                System.Console.WriteLine("Grade A");
            }
            else if ((a>60) && (a<=80))
            {
                System.Console.WriteLine("Grade B");
            }
            else if ((a>35) && (a<=60))
            {
                System.Console.WriteLine("Grade C");
            }
            else if ((a<=35) && (a>0))
            {
                System.Console.WriteLine("Grade D");
            }
            else
            {
                System.Console.WriteLine("Invalid Input");
            }

        }
    }

}