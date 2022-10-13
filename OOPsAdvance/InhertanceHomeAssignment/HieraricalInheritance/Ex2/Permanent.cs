namespace Ex2
{
    public class Permanent:SalaryInfo
    {
        private static int s_employeeId=1000;
        public string EmployeeID { get; set; }
        public string EmployeeType { get; set; }
        public int DA { get; set; }
        public int HRA { get; set; }
        public int PF { get; set; }
        public int Salary { get; set; }
        public int Total { get; set; }

        public Permanent(string month, int basicSalary,string employeeType,int da,int hra,int pf,int salary,int total):base( month,  basicSalary)
        {
            EmployeeID="EID"+s_employeeId++;
            EmployeeType=employeeType;
            DA=da;
            HRA = hra;
            PF = pf;
            Salary=salary;
            Total = total;
        }

        public void TotalSalary()
        {
            Total = Salary+DA+HRA-PF;
            System.Console.WriteLine("Enter TOtal: "+Total);
        }

        public void ShowPermanent()
        {
            System.Console.WriteLine("Enter EmployeeID: "+EmployeeID);
            System.Console.WriteLine("Enter DA: "+DA);
            System.Console.WriteLine("Enter HRA:"+HRA);
            System.Console.WriteLine("Enter PF: "+PF);
            System.Console.WriteLine("Enter Salary: "+Salary);
            TotalSalary();
            ShowSalary();
        }
    }
}