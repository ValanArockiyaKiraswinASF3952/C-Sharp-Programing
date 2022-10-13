using System;
namespace Ex8;

class program
{
    
public static void Main(string[] args)
{
    string str;
    Console.Write("Enter a string : ");
    
    str = Console.ReadLine();
    int count,su, sum = 0;
    int n = str.Length;
    string sums;
    
    for(count = 0; count < n; count++)
    {
        
        if ((str[count] >= '0') && (str[count] <= '9'))
        {
            sum += (str[count] - '0');
            sums=Convert.ToString(str[count] - '0');
            System.Console.Write(sums);

            su = Convert.ToInt32((str[count] - '0'));
            if (su%2==0)
            {
                System.Console.WriteLine("Print Even");
            }
            else{
                System.Console.WriteLine("Print Odd");
            }
        }
    }
}
        
}