using System;
namespace LinearSearch;
class Program 
{
    public static void Main(string[] args)
    {
        string[] array = new string[]{"Duke","KTM","Pulzer","Gixer"};
        int length = array.Length;
        string target= "Gixer";
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