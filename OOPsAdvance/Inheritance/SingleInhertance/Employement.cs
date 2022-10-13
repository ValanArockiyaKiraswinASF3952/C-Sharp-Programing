using System;
namespace SingleInheritance
{
    public enum Gender{Default, Male, Female, Other}
    public class Employement
    {
        private static int s_aId=1000;
        public  string AadhaarID { get;  }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public int Phone { get; set; }
        public Employement(string name,string fatherName, Gender gender, int phone)
        {
            s_aId++;
            AadhaarID="SF"+s_aId;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Phone=phone;
        }

         public Employement(string aid, string name,string fatherName, Gender gender, int phone)
        {
            AadhaarID=aid;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Phone=phone;
        }
        public void ShowDetails()
        {
            System.Console.WriteLine("Enter your name: "+Name);
            System.Console.WriteLine("Enter your Father name: "+FatherName);
            System.Console.WriteLine("Enter your gender: "+Gender);
            System.Console.WriteLine("Enter your phone number: "+Phone);
            System.Console.WriteLine("Enter your Aadhaar Number: "+AadhaarID);
        }
    }
}