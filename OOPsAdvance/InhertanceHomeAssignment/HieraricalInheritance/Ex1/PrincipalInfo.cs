using System;
namespace Ex1
{
    public class PrincipalInfo:PersonalInfo
    {
        private static int s_principalId = 1000;
        public string PrincipalID { get; set; }
        public string Qualification { get; set; }
        public DateTime YearOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }

        public PrincipalInfo(string name, string fatherName, int phone, string mail, DateTime dob, string gender,string qualification, DateTime yearOfExperience,DateTime dateOfJoining):base( name,  fatherName,  phone,  mail,  dob,  gender)
        {
            PrincipalID="PID"+s_principalId++;
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DateOfJoining=dateOfJoining;
        }

        public void ShowPrincipal()
        {
            System.Console.WriteLine("Enter Principal Id: "+PrincipalID);
            System.Console.WriteLine("Enter Qualification: "+Qualification);
            System.Console.WriteLine("Enter YearOfExperience:"+YearOfExperience);
            System.Console.WriteLine("Enter DateOfJoining: "+DateOfJoining);
            Show();
        }


    }
}
