using System;
namespace Ex1
{
    public enum MaritalStatus{Default,Married, Single}
    public class PersonalInfo
    {
        public string Name { get; set; }

        public int Phone { get; set; }
        public string Mail { get; set; }

        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string HouseAddress { get; set; }
        public int Sibbling { get; set; }

        public PersonalInfo(string name, int phone, string mail, DateTime dob, string gender,MaritalStatus maritalStatus)
        {
            Name=name;
            Phone=phone;
            Mail=mail;
            DOB=dob;
            Gender=gender;
            MaritalStatus=maritalStatus;
        }

        public void Show()
        {
            System.Console.WriteLine("Enter the name: "+Name);
            System.Console.WriteLine("Enter the phone number :"+Phone);
            System.Console.WriteLine("Enter the mail: "+Mail);
            System.Console.WriteLine("Enter the DOB: "+DOB.ToString("dd/MM/yyyy"));
            System.Console.WriteLine("Enter the Gender :"+Gender);
            System.Console.WriteLine("Enter the Marital Status: "+MaritalStatus);
        }

        public void GetFamilyInfo(string fatherName,string motherName,string houseAddress,int sibbling)
        {
            FatherName=fatherName;
            MotherName = motherName;
            HouseAddress=houseAddress;
            Sibbling=sibbling;
        }
        public void ShowFamilyInfo()
        {
            System.Console.WriteLine("Enter the Father name: "+FatherName);
            System.Console.WriteLine("Enter the mother name: "+MotherName);
            System.Console.WriteLine("Enter the House Address: "+HouseAddress);
            System.Console.WriteLine("Enter the Sibbiling: "+Sibbling);
        }
    }
}