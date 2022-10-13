using System;
 
namespace Character
{
    class Program
    {
        public static void Main()
        {
            string[] array = new string[] {"SF1001","SF1002","SF1003","SF1004","SF1005"};
            Array.Sort(array);
            int length = array.Length;
           
            Console.WriteLine("Enter Search element");
         
            string search = (Console.ReadLine());
			int a = Array.IndexOf(array,search);
            int low = 0;
            int high = length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (a==mid)
				{
					System.Console.WriteLine("Element found at "+mid);
					break;
				}
                else if (a<=mid)
				{
					high=mid-1;
				}
                else
				{
					low = mid+1;
				}
            }
            //Console.WriteLine("Search unsuccessful");
        }
    }
}