using System;
namespace DoWhileAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            string conndition=" ";
            do
            {
                System.Console.WriteLine("\n1.Addition \n2.subraractionraction\n3.Multiplication \n4.divisorision) ");
                System.Console.WriteLine("\nEnter any number: ");
                int number = Convert.ToInt32(Console.ReadLine());
            
                switch (number)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Enter Number1: ");
                        int number1=int.Parse(Console.ReadLine());
                        System.Console.WriteLine("Enter Number2: ");
                        int number2 =int.Parse(Console.ReadLine());
                        System.Console.WriteLine("Addition: "+Addition(number1,number2));
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Enter Number1: ");
                        int number1 =int.Parse(Console.ReadLine());
                        System.Console.WriteLine("Enter Number2: ");
                        int number2 =int.Parse(Console.ReadLine());
                        System.Console.WriteLine("subraractionraction: "+subraractionraction(number1,number2));
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Enter Number1: ");
                        int number1 =int.Parse(Console.ReadLine());
                        System.Console.WriteLine("Enter Number2: ");
                        int number2 =int.Parse(Console.ReadLine());
                        System.Console.WriteLine("Multiplication: "+Multiplication(number1,number2));
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Enter Number1: ");
                        int number1 =int.Parse(Console.ReadLine());
                        System.Console.WriteLine("Enter Number2: ");
                        int number2 =int.Parse(Console.ReadLine());
                        System.Console.WriteLine("divisorision: "+divisorision(number1,number2));
                        break;
                    }
                    default:
                    {
                        System.Console.WriteLine("Number Invalid");
                        break;
                    }

                }
                System.Console.WriteLine("Check the another number click yes : ");
                conndition = Console.ReadLine().ToLower();
            }while (conndition=="yes"); 

             //Addition
            int Addition(int value1, int value2)
            {
                int sum;
                sum=value1+value2;
                return sum;
            }
            //subraractionraction
            int subraractionraction(int value1, int value2)
            {
                int subraraction;
                subraraction = value1-value2;
                return subraraction;
            }
            //Multiplicaton
            
            int Multiplication(int value1, int value2)
            {
                
                int product;
                product =value1*value2;
                return product;
            }
            //divisorision
            int divisorision(int value1, int value2)
            {
                int divisor;
                divisor=value1/value2;
                return divisor;
            }           
            
        }
    }
}