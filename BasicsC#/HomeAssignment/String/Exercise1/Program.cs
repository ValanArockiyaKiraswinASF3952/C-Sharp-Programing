using System;  
namespace Eercise1;
class Program
{  
    public static void Main(string[] args)
    
{
    string str; 
    int length= 0;
    
      Console.Write("Input the string : ");
      str = Console.ReadLine();

         foreach(char chr in str)
        {
            length += 1;

        }

   Console.Write($"length of the string is : {length}");
    }
}