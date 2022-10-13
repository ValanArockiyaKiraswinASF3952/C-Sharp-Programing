using System;
namespace Exercise3
{
    class Program
    {
        public static void Main(string[] args)
        {
            int  n1=0,n2=1,n3,i=0,number;
            System.Console.WriteLine("Input number of terms to display : ");
            number = int.Parse(Console.ReadLine());
            
            if (number<0)
            {
                System.Console.WriteLine("Please Enter the positive number");
            }
            else
            {
                while(number>i)
                {
                
                    n3=n1+n2;
                    System.Console.Write($"{n1} ");
                    n1=n2;
                    n2=n3;
                    i++;
                }
            }
              
        }
    }
}