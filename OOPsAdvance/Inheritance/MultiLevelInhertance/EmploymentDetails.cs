using System;
namespace MultiLevelInhertance
{
    public class EmploymentDetails:StudentDetails,IMarkDetails
    {
        private static int s_employeId=1000;
        public  string EmployeeID { get; set; }
        public DateTime RegistrationDate { get; set; }

        public EmploymentDetails(string studentID, string aid, string name,string fatherName, Gender gender, int phone,Department department,string year):base(aid, name,fatherName,gender,phone,department,year)
        {
            s_employeId++;
            EmployeeID="EID"+s_employeId;
            RegistrationDate=DateTime.Now;
        }
        public void ShowEmployee()
        {
            System.Console.WriteLine("\nEmployee ID:"+EmployeeID);
            ShowDetails();
            System.Console.WriteLine("Registration Date: "+RegistrationDate.ToString("dd/MM/yyyy"));
            System.Console.WriteLine("Renival Date: "+RegistrationDate.AddDays(365).ToString("dd/MM/yyyy"));
            System.Console.WriteLine("\n");
        }
    }
}