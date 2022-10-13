using System;
namespace MethodPractice
{
    class Program 
    {
        public static void Main(string[] args)
        {
            
             
            //Method with arguments and with return type
            int number1 = 2, number2 = 2;
            int sum = Addition(number1,number2);
            System.Console.WriteLine($"The sum is: {sum}");
           

            int Addition(int value1, int value2)
            
            {
                int sum;
                sum=value1+value2;
                return sum;
            }


            //Method with arguments and without return type
            Subraction(number1,number2);
            void Subraction(int value1, int value2)
            {
                int sub;
                sub = value1-value2;
                System.Console.WriteLine($"Subraction: {sub}");
            }

            //Method without arguments and with return type
            int product1 = Multiplication();

            System.Console.WriteLine($"The Multiple: {Multiplication()}");
            int Multiplication()
            {
                int data1=2,  data2=2;
                int product;
                product =data1*data2;
                return product;
            }

            //Method without arguments and without return type
            int val1=2, val2=2;
            Division();
            void Division()
            {
               
                int div = val1/val2;
                System.Console.WriteLine($"Division: {div}");
            }
        }
    }
}