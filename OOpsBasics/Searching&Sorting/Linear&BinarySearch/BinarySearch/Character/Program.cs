using System;
 
namespace Character
{
    class Program
    {
        public static void Main()
        {
            char[] array = new char[] {'a','b','c','d'};
            Array.Sort(array);
            int length = array.Length;
           /* Console.WriteLine("Number of elements in the array ?");
            string s = Console.ReadLine();
            int x = Int32.Parse(s);
            Console.WriteLine(" Enter array elements ");
            for (int i = 0; i < x; i++)
            {
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }*/
            Console.WriteLine("Enter Search element");
            //string s3 = Console.ReadLine();
            char search = Char.Parse(Console.ReadLine());
            int low = 0;
            int high = length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (search < array[mid])
                    high = mid - 1;
                else if (search > array[mid])
                    low = mid + 1;
                else if (search == array[mid])
                {
                    Console.WriteLine("Search successful");
                    Console.WriteLine("Element {0} found at location {1}\n", search, mid);
                    return;
                }
            }
            Console.WriteLine("Search unsuccessful");
        }
    }
}