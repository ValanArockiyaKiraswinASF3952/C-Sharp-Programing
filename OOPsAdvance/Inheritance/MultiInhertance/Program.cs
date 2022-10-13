using System;
namespace MultiInhertance;
class Program
{
    public static void Main(string[] args)

    {
        Employement userDetails=new Employement("valan", "jesu", Gender.Male, 5468737);
        userDetails.ShowDetails();

        StudentDetails student = new StudentDetails("666666","valan","jesu",Gender.Male,726793,Department.CSE,"Final");
        student.ShowStudent();
        student.GetMark(90,90,90);
        student.Calculate();
        student.ShowMark();

        CustomerDetails customer = new CustomerDetails("87385","valan","jesu",Gender.Male,76429604);
        customer.Reacharge();
        customer.ShowCustomer();
    }
}