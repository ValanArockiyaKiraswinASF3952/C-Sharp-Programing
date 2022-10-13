namespace CollegeAddmision
{
    
    public class DepartmentDetails
    {
        private static int s_departmentID=100;
       
        public string DepartmentID { get;  }
        public string DepartmentName { get; set; }
        public int NoOfSeat { get; set; }

        public DepartmentDetails(string departmentName, int noOfSeat)
        {
            s_departmentID++;
            DepartmentID="DID"+s_departmentID;
            DepartmentName=departmentName;
            NoOfSeat=noOfSeat;
        }

        public DepartmentDetails(string datas)
        {
            string [] values = datas.Split(',');
            s_departmentID=int.Parse(values[0].Remove(0,3));
            DepartmentID=values[0];
            DepartmentName=values[1];
            NoOfSeat=int.Parse(values[2]);
        }
        
        /*public void ShowDepartmentDetails()
        {
            for (int i=0;i<4;i++)
            {
            System.Console.WriteLine("DepartmentID : "+(DepartmentID));
                System.Console.WriteLine("Department Name : "+(DepartmentName));
                System.Console.WriteLine("Number od seat : "+(NoOfSeat));
            }
        }*/
    }
}