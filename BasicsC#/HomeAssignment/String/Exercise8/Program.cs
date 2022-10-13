using System;
namespace Exercise8;
class Program
{
    public static void Main(string[] args)
    {
  string str;
  char[] arr1;
  int pos, l, ln, c = 0;
   
 
               Console.Write("Input the string : ");
               str = Console.ReadLine();    
               ln=str.Length;
               arr1 = str.ToCharArray(0, ln);

               Console.Write("Input the position to start extraction :");
               pos= Convert.ToInt32(Console.ReadLine()); 
   
               Console.Write("Input the length of substring :");
               l= Convert.ToInt32(Console.ReadLine()); 
               
 Console.Write("The substring retrieve from the string is : ");
   while (c < l) 
   {
   Console.Write(arr1[pos+c-1]);
      c++;
   }
 }
}