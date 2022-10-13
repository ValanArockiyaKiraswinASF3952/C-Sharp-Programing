using System;
namespace Ex3
{
    public class PersonalInfo
    {
        public string Name { get; set; }

        public int Phone { get; set; }
        public string Mail { get; set; }

        public DateTime DOB { get; set; }
        public string Gender { get; set; }
    

        public int PanNumber { get; set; }

        public PersonalInfo(string name, int phone, string mail, DateTime dob, string gender,int panNumber)
        {
            Name=name;
            Phone=phone;
            Mail=mail;
            DOB=dob;
            Gender=gender;
            PanNumber=panNumber;
          
        }

        public void Show()
        {
            System.Console.WriteLine("Enter the name: "+Name);
            System.Console.WriteLine("Enter the phone number :"+Phone);
            System.Console.WriteLine("Enter the mail: "+Mail);
            System.Console.WriteLine("Enter the DOB: "+DOB.ToString("dd/MM/yyyy"));
            System.Console.WriteLine("Enter the Gender :"+Gender);
            System.Console.WriteLine("Enter the PAN Number: "+PanNumber);
        }

       
       
    }
}
    