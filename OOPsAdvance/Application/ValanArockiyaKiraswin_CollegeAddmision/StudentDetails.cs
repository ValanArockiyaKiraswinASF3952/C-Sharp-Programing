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
        /// <summary>
        /// Property Register number used to uniquely identify a <see cref = "StudentDetails"/> class's object
        /// </summary>
        /// <value></value>
        public string RegisterNumber { get;  }
        
        
       // private static _name="valan"; //Field Declaration
       // public string Name { get{return _name;} set{_name=value;} }  
       /// <summary>
       /// Property name used to provide Name for a student in object of <see cref = "StudentDetails" />
       /// </summary>
       /// <value></value>
        
        public string Name { get; set; }  //Auto Property
        /// <summary>
        /// Class <see cref="StudentDetails"/> property fatherName used to provide Father name of student
        /// </summary>
        /// <value></value>
        public string FatherName { get; set; }
        /// <summary>
        /// Property DOB dob used to Provide DOB of student
        /// </summary>
        public DateTime DOB { get; set; }
        /// <summary>
        /// Prperty Gender name used to Provide gender of the student
        /// </summary>
        public Gender Gender { get; set; }
        /// <summary>
        /// Property Phone number used to Provide Phone Number of the student
        /// </summary>
        public long Phone { get; set; }
        /// <summary>
        /// Property Mail ID used to provide mail ID of the student
        /// </summary>
        /// <value></value>
        public string Mail { get; set; }
        /// <summary>
        /// property Physics mark to provide mark of the student
        /// </summary>
        public int Physics { get; set; }
        /// <summary>
        /// property Chemistry mark to provide mark of the student
        /// </summary>
        public int Chemistry { get; set; }
        /// <summary>
        /// property Maths mark to provide mark of the student
        /// </summary>
        public int Maths { get; set; }

        /*public StudentDetails() //Default constructor
        {
            Name="Your Name";
            FatherName="Your FAther Name";
        }*/
        //Parameterized constructor

        /// <summary>
        /// Constructor of <see cref="StudentDetail"/> class sused to initilize value to its property
        /// </summary>
        /// <param name="name">Parameter name used to initialize value to a Student's NAme to Name property</param>
        /// <param name="fatherName">Parameter fatherNAme used to initilize value to a Father NAme to Name proprety</param>
        /// <param name="dob">Parameter dob used to initilize value to a DOB to DOB property</param>
        /// <param name="gender">Paramet gender used to initilize value to a Gender to Gender property</param>
        /// <param name="mail">Parameter mail used to initilize value to a Mail to Mail property</param>
        /// <param name="phone">Parameter phone used to initilize value to a Phone to Phone Property</param>
        /// <param name="physics">Parameter physics used to initialize value to a Physics mark to Physics property</param>
        /// <param name="chemistry">Parameter chemistry used to initialize value to a Chemistry mark to Chemistry property</param>
        /// <param name="maths">Parameter maths used to initialize value to a Maths mark to maths property</param>
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


       public StudentDetails(string data)
       {
        string [] values = data.Split(',');
        s_registerNumber=int.Parse(values[0].Remove(0,2));
        RegisterNumber=values[0];
        Name=values[1];
        FatherName=values[2];
        Gender=Enum.Parse<Gender>(values[3]);
        Physics=int.Parse(values[4]);
        Chemistry=int.Parse(values[5]);
        Maths=int.Parse(values[6]);
       }



        //Methods
        /// <summary>
        /// Method check eligibility get cutoff value as a parameter and check the eligiblity of student
        /// If cutoff of is less then or equal he is eligible and return true else false
        /// </summary>
        /// <param name="cutoff">Used to provide cutoff valuse of eligibility check</param>
        /// <returns></returns>
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
        
    }
     
}