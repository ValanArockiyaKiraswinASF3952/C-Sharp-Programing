using System;
namespace Ex1
{
    public class PersonalInfo
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public int Phone { get; set; }
        public string Mail { get; set; }

        public DateTime DOB { get; set; }
        public string Gender { get; set; }


        public PersonalInfo(string name, string fatherName, int phone, string mail, DateTime dob, string gender)
        {
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            Mail=mail;
            DOB=dob;
            Gender=gender;
        }

        public void Show()
        {
            System.Console.WriteLine("Enter the name: "+Name);
            System.Console.WriteLine("Enter the Father namr: "+FatherName);
            System.Console.WriteLine("Enter the phone number :"+Phone);
            System.Console.WriteLine("Enter the mail: "+Mail);
            System.Console.WriteLine("Enter the DOB: "+DOB.ToString("dd/MM/yyyy"));
            System.Console.WriteLine("Enter the Gender :"+Gender);
        }
    }
}