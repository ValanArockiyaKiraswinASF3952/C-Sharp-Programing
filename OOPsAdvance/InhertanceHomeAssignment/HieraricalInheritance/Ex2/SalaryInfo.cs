namespace Ex2
{
    public class SalaryInfo
    {
        public string Month { get; set; }
        public int BasicSalary { get; set; }

        public SalaryInfo(string month, int basicSalary)
        {
            Month=month;
            BasicSalary=basicSalary;
        }
        public void ShowSalary()
        {
            System.Console.WriteLine("Enter Month:"+Month);
            System.Console.WriteLine("ENter BasicSalary: "+BasicSalary);
        }
    }
}