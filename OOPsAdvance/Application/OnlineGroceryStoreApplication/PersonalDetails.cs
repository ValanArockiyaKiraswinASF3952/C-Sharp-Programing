using System;
namespace OnlineGroceryStoreApplication
{
    public enum Gender{Default,Male,Female,TransGender}
    public class PersonalDetails
    {
        public string Name { get; set; }
        public string FatherName { get; set; }

        public Gender Gender { get; set; }
        public long Mobile { get; set; }
        public DateTime DOB { get; set; }
        public string MailID { get; set; }

        public PersonalDetails(string name,string fatherName,Gender gender,long mobile,DateTime dob,string mailID)
        {
            Name=name;
            FatherName=fatherName;
            Gender=Gender;
            Mobile=mobile;
            DOB=dob;
            MailID=mailID;
        }

        public PersonalDetails()
        {
            
        }
    }
}