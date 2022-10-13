using System;
namespace Exercise10
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the value1: ");
            double value1= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value2: ");
            double value2 = Convert.ToDouble(Console.ReadLine());
            
            System.Console.WriteLine($"{value1}>{value2} : {value1>value2}");
            System.Console.WriteLine($"{value1}<{value2} : {value1<value2}");
            System.Console.WriteLine($"{value1}>={value2} : {value1>=value2}");
            System.Console.WriteLine($"{value1}=={value2} : {value1==value2}");
            System.Console.WriteLine($"{value1}!={value2} : {value1!=value2}");
            System.Console.WriteLine($"{value1}<={value2} : {value1<=value2}");
            System.Console.WriteLine($"{value1}>= 10 && {value2}>=10 : {value1>=10 && value2>=10}");
            System.Console.WriteLine($"{value1}>= 10 || {value2}>=30 : {value1>=10 || value2>=30}");
            System.Console.WriteLine($"{value1}>20 : !{value2}>20");
            string value=value1==15? "true":"false";
            System.Console.WriteLine($"string value=value1==15?true:false: {value}");
            System.Console.WriteLine($"{value1}++ : {value1++}");
            System.Console.WriteLine($"{value1}-- : {value1--}");

        }
    }
}