using System;
namespace Insertion;
class Program 
{
    public static void Main(string[] args)
    {
        int [] array = new int [] {18,19,1,5,7,3,20};
        int length = array.Length;        
        for (int i=1;i<length;i++)
        {
            int target = array[i];
            int flag =0;
            for(int j=i-1;j>=0 && flag!=1;)
            {
                if(target<array[j])
                {
                    array[j+1]=array[j];
                    j--;
                    array[j+1]=target;
                }
                else
                {
                    flag=1;
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