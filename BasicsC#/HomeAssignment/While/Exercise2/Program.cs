using System;
namespace Exercise2
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the input: ");
            int number= int.Parse(Console.ReadLine());

            int count=0;
            int x=0;
            int y = 0;
            System.Console.Write("Number-");
            while (count<number)
            {
                
                count +=1;
                x=count*count;
                y=x+0;
                
                System.Console.Write($"{count} ");
                
            }
            System.Console.WriteLine($"\nCount :{count}");
            System.Console.WriteLine($"Sum : {y}");
              
        }
    }
}