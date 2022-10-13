using System;
namespace LinearSearch;
class Program 
{
    public static void Main(string[] args)
    {
        int[] array = new int[]{1,2,3,4,56,7,8,9};
        int length = array.Length;
        int target= 8;
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