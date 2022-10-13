using System;
namespace Exercise13;

class program
{
    
public static void Main(string[] args)
{
    string str;
    Console.Write("Enter a string : ");
    
    str = Console.ReadLine();
    int count, sum = 0;
    int n = str.Length;
    
    for(count = 0; count < n; count++)
    {
        
        if ((str[count] >= '0') && (str[count] <= '9'))
        {
            sum += (str[count] - '0');
        }
    }
    Console.WriteLine("Sum = " + sum);
}
}