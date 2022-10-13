using System;
namespace LinearSearch;
class Program 
{
    public static void Main(string[] args)
    {
        char[] array = new char[]{'a','b','c','d','e'};
        int length = array.Length;
        char target= 'd';
        for (int i=0;i<length;i++)
        {
            if(array[i]==target)
            {
                System.Console.WriteLine("Element present in the array.\nThe index potion is "+i);
                break;
            }
        }
        
    }
}