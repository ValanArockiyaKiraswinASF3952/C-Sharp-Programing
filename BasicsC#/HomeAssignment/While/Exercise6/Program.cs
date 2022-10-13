using System;
namespace Exercise6
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i=1,j=1,count=0;
            System.Console.WriteLine("Odd number list: ");

            while (i<=100)
            {
                if (i%2!=0)
                {
                    System.Console.Write(i);
                    if (i !=99)
                    {
                        System.Console.Write(", ");
                    }
                }
                i++;
            }
            i=1;
        
        
            Console.WriteLine("Even number list: ");

            while (i<=100)
            {
                if (i%2==0)
                {
                    System.Console.Write(i);
                    if (i!=100)
                    {
                        System.Console.Write(", ");
                    }
                }
                i++;

            }
            i=1;

            
            System.Console.WriteLine("Prime number list: ");

            while (i<100)
            {
                while(j<=i)
                {
                    if (i%j==0)
                    {
                        count++;
                    }
                    j++;
                }
                if (count==2)
                {
                    System.Console.Write(i);
                    if (i !=97)
                    {
                        System.Console.Write(", ");
                    }
                }
                count=0;
                j=1;
                i++;
            }
        }
        
    }
}