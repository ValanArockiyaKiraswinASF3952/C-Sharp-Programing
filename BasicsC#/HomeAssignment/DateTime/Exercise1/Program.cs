using System;
namespace Exercise1;
class Program
{
    public static void Main(string[] args)
    {
        DateTime[] date1={DateTime.Now,new DateTime(2016, 8, 16, 9, 28, 0),new DateTime(2011, 5, 28, 10, 35, 0),
        new DateTime(1979, 12, 25, 14, 30, 0)
        };
        for (int i=0;i<date1.Length;i++)
        {
        System.Console.WriteLine("\nDay : "+date1[i].ToString("MM/dd/yyyy")+"    Time :"+date1[i].ToString("hh:mm:ss:ffff"));
        System.Console.WriteLine(("Day  : "+date1[i].ToString("MM/dd/yyyy")+"    Time : "+date1[i].ToShortTimeString()));
        
        }
    }

}
