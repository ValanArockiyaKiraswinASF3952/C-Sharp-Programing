using System;
namespace ArrayAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {         
            
            
            System.Console.WriteLine("Enter the length of array: ");   
            int number = int.Parse(Console.ReadLine());
            string [] names = new string[number];
            int value = 0;
            
            for (int i=0; i<number;i++)
            {
                System.Console.WriteLine("Enter the Name: ");   
                names[i] = (Console.ReadLine());
                
            }
            for (int i=0; i<number;i++)
            {
                System.Console.WriteLine($"Name {i+1}. {names[i]}");
            }
            System.Console.WriteLine("search name in array: ");
                string name = Console.ReadLine();
            
            for (int i=0; i<number;i++)
            {
                
                if (name==names[i])
                {
                    
                    System.Console.WriteLine("The name is present in array.");
                    System.Console.WriteLine("Index value of name is "+(i+1));
                    value=1;
                    break;
                
                }
            }
            if (value==0)
            {
                System.Console.WriteLine("The name is not present in array");
            }
            foreach (string findNames in names)
            {
                
                if (name==findNames)
                {
                    
                    System.Console.WriteLine("The name is present in array.");
                    value=1;
                    break;
                
                }
            }
            if (value==0)
            {
                System.Console.WriteLine("The name is not present in array");
            }

        }
    }
}