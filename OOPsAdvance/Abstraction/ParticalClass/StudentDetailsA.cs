using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ParticalClass
{
    public partial class StudentDetails
    {
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
       
         
        
    
        
    
    }
}