using System;
namespace Ex5;
class Program
{
    public static void Main(string[] args)
    {
        int salary = 10000;
        int DA = salary/100*10;
        int HRA = salary/100*10;
        int total = (salary+DA+HRA)*12;
        int annualSalary =total/100*5;
        System.Console.WriteLine($"The annual income is : {total-annualSalary}");

    }
}