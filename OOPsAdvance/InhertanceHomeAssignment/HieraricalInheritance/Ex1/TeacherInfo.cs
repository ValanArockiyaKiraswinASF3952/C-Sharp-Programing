using System;
namespace Ex1
{
    public class TeacherInfo:PersonalInfo
    {
        private static int s_teacherId = 1000;
        public string TeacherId { get; set; }
        public string Department { get; set; }
        public string Subject { get; set; }
        public string Qualification { get; set; }
        public DateTime YearOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }

        public TeacherInfo(string name, string fatherName, int phone, string mail, DateTime dob, string gender,string department,string subject,string qualification,DateTime yearOfExperience, DateTime dateOfJoining):base( name,  fatherName,  phone,  mail,  dob,  gender)
        {
            TeacherId="TID"+s_teacherId++;
            Department=department;
            Subject = subject;
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DateOfJoining=dateOfJoining;
        }
        public void ShowTeacher()
        {
            System.Console.WriteLine("Enter Teacher Id: "+TeacherId);
            System.Console.WriteLine("Department :"+Department);
            System.Console.WriteLine("Subject :"+Subject);
            System.Console.WriteLine("Qulification: "+Qualification);
            System.Console.WriteLine("YearOfJoining: "+YearOfExperience);
            System.Console.WriteLine("DateOfJoining:"+DateOfJoining);
            Show();
        }
    }
}