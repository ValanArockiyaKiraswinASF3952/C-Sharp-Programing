using System;
namespace Ex1;
class Program 
{
    public static void Main(string[] args)
    {
        StudentInfo student = new StudentInfo("valan","jesu",3634838,"valan@gmail",new DateTime(11/11/1111),"Male",Brange.CSE,"Final");
        student.ShowDetails();
    }
}