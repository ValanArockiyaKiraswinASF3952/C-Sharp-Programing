using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAddmision
{
    public enum Gender{Default,Male,Female,TransGender}
    public class StudentDetails
    {
        private static int s_registerNumber=3000;
        public string RegisterNumber { get;  }
        
        
       // private static _name="valan"; //Field Declaration
       // public string Name { get{return _name;} set{_name=value;} }  
        
        public string Name { get; set; }  //Auto Property
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
        public long Phone { get; set; }
        public string Mail { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }

        /*public StudentDetails() //Default constructor
        {
            Name="Your Name";
            FatherName="Your FAther Name";
        }*/
        //Parameterized constructor
        public StudentDetails(string name, string fatherName, DateTime dob, Gender gender, string mail, long phone, int physics, int chemistry, int maths)
        {
            s_registerNumber++;
            RegisterNumber="SF"+s_registerNumber;
            Name=name;
            FatherName=fatherName;
            DOB=dob;
            Gender=gender;
            Mail=mail;
            Phone=phone;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }
        //Methods
        public bool CheckEligibility(double cutoff)
        {
            double average = (double) (Physics+Chemistry+Maths)/3.0;
            if (average>=cutoff)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ShowDetails()
        {
            System.Console.WriteLine($"\nYour Name is {Name}");
            System.Console.WriteLine($"Your FatherName is {FatherName}");
            System.Console.WriteLine($"Your DOB is {DOB}");
        System.Console.WriteLine($"Your Phone number is {Phone}");
        System.Console.WriteLine($"Your mail is {Mail}");
        System.Console.WriteLine($"Your Physics Mark is {Physics}");
        System.Console.WriteLine($"Your Chemistry Mark is {Chemistry}");
        System.Console.WriteLine($"Your Maths Mark is {Maths}");
        System.Console.WriteLine("Register number is: "+(RegisterNumber));
        }
       /* ~StudentDetails() //Destuctor creation
        {

        }  */
    }
}