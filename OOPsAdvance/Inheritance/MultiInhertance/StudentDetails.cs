using System;
namespace MultiInhertance
{
    public enum Department{Default, EEE, CSE, ECE}
    public class StudentDetails:Employement,IMarkDetails
    {
        private static int s_ID = 1000;
        public string StudentID { get; set; }
        public Department Department { get; set; }
        public string Year { get; set; }

        public int Physics { get; set; }  //property declaration only allowed
        public int Maths { get; set; }
        public int Chemistry { get; set; }
        public int Total { get; set; }
        public double Average { get; set; }

        


        public StudentDetails(string aid, string name,string fatherName, Gender gender, int phone,Department department,string year):base(aid, name,fatherName,gender,phone)
        {
            s_ID++;
            StudentID="SID"+s_ID;
            Department=department;
            Year = year;
        }

        public void GetMark(int physics,int maths,int chemistry)
        {
            Physics=physics;
            Maths=maths;
            Chemistry=chemistry;
        }

        public void Calculate()
        {
            Total = Physics+Chemistry+Maths;
            Average=(double)Total/3.0;
        }

        public void ShowMark()
        {
            System.Console.WriteLine("Physics mark: "+Physics+"\nChemistry mark: "+Chemistry+"\nMaths mark: "+Maths);
            System.Console.WriteLine("Total Mark: "+Total+"\nAverage :"+Average);
        }
        public void ShowStudent()
        {
            System.Console.WriteLine("\nStudent Id:"+StudentID);
            ShowDetails();
            System.Console.WriteLine("DEpartment: "+Department+"\nYear: "+Year+"\n");
        }
    }
}