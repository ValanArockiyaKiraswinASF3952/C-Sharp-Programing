using System;
namespace Ex1
{
    public enum Brange{Default, EEE, CSE, ECE}
    public class StudentInfo:PersonalInfo
    {
        private static int s_registerID = 1000;
        public string RegisterID { get; set; }
        public Brange Brange { get; set; }
        public string Accadamic { get; set; }

        public StudentInfo(string name, string fatherName, int phone, string mail, DateTime dob, string gender,Brange brange,string accadamic):base( name, fatherName, phone, mail, dob,gender)
        {
            RegisterID="SF"+s_registerID++;
            Brange = brange;
            Accadamic=accadamic;
        }

        public void ShowDetails()
        {
            System.Console.WriteLine("Enter the student Id: "+RegisterID);
            Show();
            System.Console.WriteLine("ENter the Brange: "+Brange);
            System.Console.WriteLine("Enter the accadamic :"+Accadamic);
        }
    }
}