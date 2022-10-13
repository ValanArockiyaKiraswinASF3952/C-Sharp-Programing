using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Merge;
class Program 
{
    public static void Main(string[] args)
    {
        int [] array = new int [] {18,19,1,5,7,3,20};
        int length = array.Length;     
        //int leftValue,rightValue,temp=0; 
        int temp=0; 
        for (int i=0;i<length;i++)
        {
            
        }
        /*int mid = length/2;
        int left = mid;
        int right = mid+1;
        List<int> leftValue = new List<int>();
        List<int> rightValue = new List<int>();
        for(int i=0;i<mid;i++)
        {
            //leftValue.Add(array[i]);
            if(array[i]>array[i+1])
                {
                    temp=array[i];
                    array[i]=array[i+1];
                    array[i+1]=temp;

                }

        }
        for(int i=mid;i<length;i++)
        {
            //rightValue.Add(array[i]);
            if(array[i]>array[i+1])
                {
                    temp=array[i];
                    array[i]=array[i+1];
                    array[i+1]=temp;

                }
        }
        /*List<int> result = new List<int>();
        while(leftValue.Count>0 || rightValue.Count>0)
        {
            if(leftValue.Count>0 && rightValue.Count>0)
            {
                if(leftValue.First()<=rightValue.First())
                {
                    result.Add(leftValue.First());
                    leftValue.Remove(leftValue.First());
                }
                else
                {
                    result.Add(rightValue.First());
                    rightValue.Remove(rightValue.First());
                }
            }
            else if (leftValue.Count>0)
            {
                result.Add(leftValue.First());
                leftValue.Remove(leftValue.First());
            }
            else if (rightValue.Count>0)
            {
                result.Add(rightValue.First());
                rightValue.Remove(rightValue.First());
            }
        }*/
        
        
        System.Console.WriteLine("The sorted array is :");
        foreach (int k in array)
        {
            System.Console.Write(k+" ");
        }
        
    }
}