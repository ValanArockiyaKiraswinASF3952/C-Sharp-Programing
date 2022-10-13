using System;
namespace Exercise8;
 
class Program
    {
        static void Main(string[] args)
        {
            double mark1,mark2,mark3,total;
            double percentage;


            Console.Write("Mark 1 : ");
            mark1= Convert.ToInt32(Console.ReadLine());
            Console.Write("Mark 2 : ");
            mark2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mark 3 : ");
            mark3 = Convert.ToInt32(Console.ReadLine());

            total = mark1+mark2+mark3;
            percentage = total/3.0;
    

            Console.Write($"Output: \nMarks 1 : {mark1}\nMarks 2 : {mark2}\nMarks 3 : {mark3}\nPercentage : {percentage}");
    
        }
    }