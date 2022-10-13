using System;
namespace FoodDeliveryApplication
{
    public enum Gender{Default,Male,Female}
    public class PersonalDetails
    {
        public string Name  { get; set; }
        public string FatherName  { get; set; }
        public Gender Gender  { get; set; }
        public long Mobile { get; set; }
        public DateTime DOB { get; set; }
        public string MailID  { get; set; }
        public string Location  { get; set; }

        public PersonalDetails(string name, string fatherName, Gender gender, long mobile, DateTime dob, string mailID, string location)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Mobile=mobile;
            DOB=dob;
            MailID=mailID;
            Location=location;
        }
        public PersonalDetails(string data)
       {
        string [] values = data.Split(',');
        Name=values[1];
        FatherName=values[2];
        Gender=Enum.Parse<Gender>(values[3]);
        Mobile=long.Parse(values[4]);
        DOB=DateTime.Parse(values[5]);
        MailID=(values[6]);
        Location=values[7];
       }

        public void ShowPersonalDetails()
        {
            System.Console.WriteLine("Enter the name: "+Name);
            System.Console.WriteLine("Enter the father name: "+FatherName);
            System.Console.WriteLine("Enter the gender: "+Gender);
            System.Console.WriteLine("Enter the Mobile number: "+Mobile);
            System.Console.WriteLine("Enter the DOB: "+DOB);
            System.Console.WriteLine("Enter the Mail ID: "+MailID);
            System.Console.WriteLine("Enter the Location: "+Location);
        }
    }
}