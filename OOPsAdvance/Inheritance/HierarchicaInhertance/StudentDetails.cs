using System;
namespace HierarchicaInhertance
{
    public enum Department{Default, EEE, CSE, ECE}
    public class StudentDetails:Employement
    {
        private static int s_ID = 1000;
        public string StudentID { get; set; }
        public Department Department { get; set; }
        public string Year { get; set; }


        public StudentDetails(string aid, string name,string fatherName, Gender gender, int phone,Department department,string year):base(aid, name,fatherName,gender,phone)
        {
            s_ID++;
            StudentID="SID"+s_ID;
            Department=department;
            Year = year;
        }

        public void ShowStudent()
        {
            System.Console.WriteLine("\nStudent Id:"+StudentID);
            ShowDetails();
            System.Console.WriteLine("DEpartment: "+Department+"\nYear: "+Year+"\n");
        }
    }
}