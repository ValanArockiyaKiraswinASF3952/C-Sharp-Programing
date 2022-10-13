using System;
namespace Quick 
{
   class Program 
   {
      static public int Partition(int[] array, int left, int right) 
      {
         int pivot;
         pivot = array[left];
         while (true) 
         {
            while (array[left] < pivot) 
            {
               left++;
            }
            while (array[right] > pivot) 
            {
               right--;
            }
            if (left < right) 
            {
               int temp = array[right];
               array[right] = array[left];
               array[left] = temp;
            } else {
               return right;
            }
         }
      }
      static public void quickSort(int[] array, int left, int right) 
      {
         int pivot;
         if (left < right) 
         {
            pivot = Partition(array, left, right);
            if (pivot > 1) 
            {
               quickSort(array, left, pivot - 1);
            }  
            if (pivot + 1 < right) 
            {
               quickSort(array, pivot + 1, right);
            }
         }
      }
      static void Main(string[] args) 
      {
         int[] array = {18,19,1,5,7,3,20};
         int n = 7, i;
         Console.WriteLine("Quick Sort");
         Console.Write("Initial array is: ");
         for (i = 0; i < n; i++) 
         {
            Console.Write(array[i] + " ");
         }
         quickSort(array, 0, 6);
         Console.Write("\nSorted array is: ");
         for (i = 0; i < n; i++) 
         {
            Console.Write(array[i] + " ");
         }
      }
   }
}