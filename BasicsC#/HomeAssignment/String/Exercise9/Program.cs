using System;
namespace Exercise9;
class Program
{
    public static void Main(string[] args)
    {
  string str1,str2;
  bool m;
    
        Console.Write("Input the string : ");
               str1 = Console.ReadLine();   

        Console.Write("Input the substring to  search : ");
               str2 = Console.ReadLine();
               m=str1.Contains(str2); 
        if (m)
        Console.Write("The substring exists in the string.");
        else
        Console.Write("The substring is not exists in the string.");
    }
}