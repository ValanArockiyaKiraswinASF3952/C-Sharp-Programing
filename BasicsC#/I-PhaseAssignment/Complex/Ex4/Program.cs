using System;
using System.Collections.Generic;
namespace Ex4
{
     class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the Input : ");
            String string1 =Console.ReadLine();
            Console.WriteLine("Original String: "+string1);
            Console.Write("After removing duplicates characters from the said string: ");
            Console.WriteLine(remove_duplicate_chars(string1));
           
        }
     public static string remove_duplicate_chars(string string1)
        {
            var indexes = new Dictionary<char, int>();
            for (int i = 0; i < string1.Length; i++)
                indexes[string1[i]] = i;

            var flag = new HashSet<char>();
            var stack = new Stack<char>();
            for (int i = 0; i < string1.Length; i++)
            {
                var ele = string1[i];
                if (!flag.Contains(ele))
                {
                    while (stack.Count > 0 && stack.Peek() > ele && i < indexes[stack.Peek()])
                        flag.Remove(stack.Pop());

                    flag.Add(ele);
                    stack.Push(ele);
                }
            }

            var s = new char[stack.Count];
            int index = stack.Count - 1;
            foreach (var ele in stack)
                s[index--] = ele;
            return new string(s);
        }
  }
}