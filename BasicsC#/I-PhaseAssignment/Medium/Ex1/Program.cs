using System;
namespace Ex1;
class Program 
{
    public static void Main(string[] args)
    {
        int total=0,HRA,DA,annualSalary;
        System.Console.WriteLine("Enter the salary: ");
        int salary = int.Parse(Console.ReadLine());
        if (salary <= 10000)
        {
            HRA = (salary/100)*20;
            DA = (salary/100)*80;
            total = (salary+HRA+DA)*12;
            annualSalary = total-(((total/100)*6)+((total/100)*1));
            System.Console.WriteLine($"Annual Grosssalary and take home salary is: {annualSalary}");
        }
        else if (salary <= 20000)
        {
            HRA = (salary/100)*25;
            DA = (salary/100)*90;
            total = (salary+HRA+DA)*12;
            annualSalary = total-(((total/100)*6)+((total/100)*1));
            System.Console.WriteLine($"Annual Grosssalary and take home salary is: {annualSalary}");
        }
        else if (salary > 20000)
        {
            HRA = (salary/100)*30;
            DA = (salary/100)*95;
            total = (salary+HRA+DA)*12;
            annualSalary = total-(((total/100)*6)+((total/100)*1));
            System.Console.WriteLine($"Annual Grosssalary and take home salary is: {annualSalary}");
        }
    }
}