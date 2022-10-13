using System;
namespace Ex1
{
    public class StudentInfo:PersonalInfo
    {
        private static int s_student = 1000;
        public string StudentID { get; set; }
        public string Degree { get; set; }
        public string Department { get; set; }
        public string Semester { get; set; }

        public StudentInfo(string name, string fatherName, int phone, string mail, DateTime dob, string gender,string degree, string department,string semester):base( name,  fatherName,  phone,  mail,  dob,  gender)
        {
            StudentID ="SID"+s_student++;
            Degree=degree;
            Department=department;
            Semester=semester;
        }
        public void ShowStudent()
        {
            Show();
            System.Console.WriteLine("Enter the student :"+StudentID);
            System.Console.WriteLine("Enter the degree: "+Degree);
            System.Console.WriteLine("Enter Department: "+Department);
            System.Console.WriteLine("Enter the Smemester: "+Semester);
        }
    }
}
