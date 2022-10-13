using System;
namespace Selection;
class Program 
{
    public static void Main(string[] args)
    {
        int [] array = new int [] {18,19,1,5,7,3,20};
        int length = array.Length;     
        int minValue,i,j,temp=0;  
        for (i=0;i<length-1;i++)
        {
            minValue = i;
            for(j=i+1;j<length;j++)
            {
                if(array[j]<array[minValue])
                {
                     minValue = j; 
                }      
            }      
            temp = array[i];
            array[i] = array[minValue];
            array[minValue]=temp;
        }
        
        System.Console.WriteLine("The sorted array is :");
        foreach (int k in array)
        {
            System.Console.Write(k+" ");
        }
    }
}