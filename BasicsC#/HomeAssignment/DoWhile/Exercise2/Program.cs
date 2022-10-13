using System;
namespace Exercise2
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            int conndition=0;
            int n=0;
            do
            {            
                n=n+conndition;
                
                System.Console.WriteLine("Enter the number : ");
                conndition = int.Parse(Console.ReadLine());
                
            }while (conndition>=0);
            System.Console.WriteLine($"The sum is: {n}");
            
                
            
            
        }
    }
}