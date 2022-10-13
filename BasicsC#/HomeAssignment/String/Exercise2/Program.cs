using System;  
namespace Exercise2;
class Program
{  
    public static void Main(string[] args)
        {
            string str; 
            int l=0;
    
            Console.Write("Input the string : ");
            str = Console.ReadLine();
            Console.Write("The characters of the string are  :  ");
            while (l <= str.Length - 1)
            {
                Console.Write($" {str[l]}");
                l++;
            }
        }
}