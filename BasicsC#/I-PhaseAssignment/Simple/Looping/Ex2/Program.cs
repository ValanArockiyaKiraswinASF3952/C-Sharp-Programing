using System;
namespace Ex2;
class Program 
{
    public static void Main(string[] args)
    {
       int number=0, square=0;

        for (int i=1;i<100;i++)
        {
            if (i%2!=0)
            {
                number = i*i;
                square += number;
                
            }
        }
        
        System.Console.WriteLine("The sum of square of given odd values range 1- 99 is: "+square);

        
    }
}