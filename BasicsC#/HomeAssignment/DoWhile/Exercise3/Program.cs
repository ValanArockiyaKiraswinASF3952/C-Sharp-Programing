using System;
namespace Exercise3
{
    class Program
    {
        public static void Main(string[] args)
        {          
            int  n1=0,n2=1,n3,number;
            System.Console.WriteLine("Input number of terms to display : ");
            number = int.Parse(Console.ReadLine());
            System.Console.Write($"{n1} {n2} ");
            do
            {
                
                n3=n1+n2;
                System.Console.Write($"{n3} ");
                n1=n2;
                n2=n3;
            }while(number>0);
            
        }
    }
}