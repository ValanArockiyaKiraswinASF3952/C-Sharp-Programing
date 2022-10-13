using System;  
namespace Exercise3;
class Program
{  
    public static void Main(string[] args)
        {
            string str; 
            int l=0;
    
      Console.Write("Input the string : ");
      str = Console.ReadLine();
      
      l = str.Length - 1;
      Console.WriteLine("The characters of the string in reverse are : ");
            while (l >= 0)
            {
                Console.Write($" {str[l]}");
                l--;
            }
        }
}