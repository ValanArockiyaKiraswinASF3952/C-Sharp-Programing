using System;
using System.Collections.Generic;

namespace LibraryApplication
{
    public enum Gender{Default,Male,Female,Transgender}
    public class UserDetails
    {
        private static int s_userId=3000;
        public string UserId{get; set;}

        public string UserName{get; set;}
        public int Age{get; set;}
        public Gender Gender{get; set;}
        public string Department{get; set;}
        public long Phone{get; set;}
        public string MailId{get; set;}

        public UserDetails(string userName,int age,Gender gender,string department,long phone,string mailId)
        {
            s_userId++;
            UserId="SF"+s_userId;
            UserName=userName;
            Age=age;
            Gender=gender;
            Department=department;
            Phone=phone;
            MailId=mailId;
        }
        

    }
}