using System;
namespace Exercise9
{
    class Program
    {
        public static void Main(string[] args)
        {
            int input,digit,temp;
            Console.WriteLine("Enter the input number: ");
            input=int.Parse(Console.ReadLine());
            double ssum=0;
            for (temp=input;input!=0;input=input/10)
            {
                digit=input % 10;
                ssum=ssum+(digit*digit*digit);
            }
            if (ssum==temp)
            {
                Console.WriteLine($"{temp} is an Armstrong Number");
            }
            else
            {
                Console.WriteLine($"{temp} is not an Armstrong Number"); 
            }            
        
        }
    }

}
