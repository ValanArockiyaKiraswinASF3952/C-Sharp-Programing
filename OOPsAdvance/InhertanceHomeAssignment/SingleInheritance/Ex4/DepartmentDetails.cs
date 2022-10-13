namespace Ex4
{
    public class DepartmentDetails
    {
        public string DepartmentName { get; set; }
        public string Degree { get; set; }

        public DepartmentDetails(string departmentName,string degree)
        {
            DepartmentName=departmentName;
            Degree=degree;
        }
        public void Show()
        {
            System.Console.WriteLine("Enter the department name: "+DepartmentName);
            System.Console.WriteLine("Enter the degree name: "+Degree);

        }
    }
}