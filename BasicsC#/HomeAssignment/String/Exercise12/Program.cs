using System;
using System.Linq;
namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            string str_num = "3 4 8 9 0 2 1";
            Console.WriteLine($"Original string of numbers: {str_num}");
            Console.WriteLine($"Maximum and minimum number of the said string: {test(str_num)}");
        }
        public static string test(string str_num)
        {
            var result = str_num.Split(' ').Select(int.Parse).ToArray();
            return result.Max() + ", " + result.Min();
        }
    }
}