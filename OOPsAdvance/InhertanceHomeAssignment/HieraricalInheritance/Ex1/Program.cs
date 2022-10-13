using System;
namespace Ex1;
class Program 
{
    public static void Main(string[] args)
    {
        TeacherInfo teacher = new TeacherInfo("valan","jesu",82837,"mail",new DateTime(11/11/1111),"Male","EEE","Mechanical","MSC",new DateTime(11/11/1111),new DateTime(11/11/1111));
        teacher.ShowTeacher();

        StudentInfo student = new StudentInfo("valan","jesu",82837,"mail",new DateTime(11/11/1111),"Male","EEE","Mechanical","MSC");
        student.ShowStudent();

        PrincipalInfo principal = new PrincipalInfo("valan","jesu",82837,"mail",new DateTime(11/11/1111),"Male","EEE",new DateTime(11/11/1111),new DateTime(11/11/1111));
        principal.ShowPrincipal();
    }
}