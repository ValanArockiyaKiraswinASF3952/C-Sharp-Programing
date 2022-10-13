using System;
namespace Exercise10
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i,inputValue,tempValue=0;
            Console.WriteLine("Enter The input number");
            inputValue=int.Parse(Console.ReadLine());
            for(i=1;i<=inputValue;i++)
            {
                if(inputValue%i==0)
                {
                    tempValue++;
                }
            }
            if(tempValue==2)
            {
                Console.WriteLine($"{inputValue} is Prime Number");
        
            }
            else
            {
                Console.WriteLine($"{inputValue} is Not a Prime Number");
        
            }
        }
    }
}
