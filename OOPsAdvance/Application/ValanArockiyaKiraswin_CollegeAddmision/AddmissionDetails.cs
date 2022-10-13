using System;
namespace CollegeAddmision
{
    public enum AddmissionStatus{Default, Booked, Cancel}
    public class AddmissionDetails
    {
        private static int s_addmissionID=1000;
        public string AddmissionID { get;  }
        public string StudentID { get;  }
        public string DepartmentID { get;  }
        public DateTime AddmissionDate { get; set; }
        public AddmissionStatus AddmissionStatus { get; set; }

        public AddmissionDetails(string studentID,string departmentID, DateTime addmissionDate, AddmissionStatus addmissionStatus)
        {
            s_addmissionID++;
            AddmissionID="AID"+s_addmissionID;
            StudentID=studentID;
            DepartmentID=departmentID;
            AddmissionDate=addmissionDate;
            AddmissionStatus=addmissionStatus;
        }

        public AddmissionDetails(string dat)
        {
            string [] values = dat.Split(',');
            s_addmissionID=int.Parse(values[0].Remove(0,3));
            AddmissionID=values[0];
            DepartmentID=values[1];
            StudentID=values[2];
            AddmissionDate=DateTime.Parse(values[3]);
            AddmissionStatus=Enum.Parse<AddmissionStatus>(values[4]);
        }

    }
}