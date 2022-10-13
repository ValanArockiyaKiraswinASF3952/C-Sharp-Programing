using System;
namespace SingleInheritance;
class Program 
{
    public static void Main(string[] args)

    {
        Employement userDetails=new Employement("valan", "jesu", Gender.Male, 5468737);
        userDetails.ShowDetails();
        StudentDetails student = new StudentDetails("666666","valan","jesu",Gender.Male,726793,Department.CSE,"Final");
        student.ShowStudent();
    }
}