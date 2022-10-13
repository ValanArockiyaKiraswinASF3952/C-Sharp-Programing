using System;
namespace Bubble;
class Program 
{
    public static void Main(string[] args)
    {
        int [] array = new int [] {18,19,1,5,7,3,20};
        int length = array.Length;
        int temp=0;
        for (int i=0;i<length-1;i++)
        {
            for (int j=0;j<length-1;j++)
            {
                if(array[j]>array[j+1])
                {
                    temp=array[j];
                    array[j]=array[j+1];
                    array[j+1]=temp;

                }
            }
        }
        System.Console.WriteLine("The sorted array is :");
        foreach (int k in array)
        {
            System.Console.Write(+k+" ");
        }
    }
}