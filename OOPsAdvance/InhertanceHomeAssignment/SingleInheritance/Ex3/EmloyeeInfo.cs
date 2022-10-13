using System;
namespace Ex3
{
    public class EmloyeeInfo:SalaryInfo
    {
        private static int s_emplyId=1000;
        public string EmployID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public int Phone { get; set; }
        public string Mail { get; set; }

        public DateTime DOB { get; set; }
        public string Gender { get; set; }

        public EmloyeeInfo(DateTime date,int hours,String salaryMonth, string month,string name, string fatherName, int phone, string mail, DateTime dob, string gender):base(date,hours, salaryMonth,  month)
        {
            EmployID="EID"+s_emplyId++;
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            Mail=mail;
            DOB=dob;
            Gender=gender;
            
        }

        public void ShowDetails()
        {
            System.Console.WriteLine("Enter th Employee Id: "+EmployID);
            System.Console.WriteLine("Enter the name: "+Name);
            System.Console.WriteLine("Enter the father name: "+FatherName);
            System.Console.WriteLine("Enter the Phone number : "+Phone);
            System.Console.WriteLine("Enter the Mail Id : "+Mail);
            System.Console.WriteLine("Enter the DOB : "+DOB);

            System.Console.WriteLine("Enter the gender : "+Gender);
            ShowSalary();
        
            

        }
    }
}