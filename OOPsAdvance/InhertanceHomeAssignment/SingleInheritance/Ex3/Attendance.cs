using System;
namespace Ex3
{
    public class Attendance
    {
        public DateTime Date { get; set; }
        public int Hours { get; set; }

        public Attendance(DateTime date,int hours)
        {
            Date=date;
            Hours=hours;
        }

        public void ShowAttendance()
        {
            System.Console.WriteLine("Enter the date: "+Date.ToString("dd/MM/yyyy"));
            System.Console.WriteLine("Enter the Hours: "+Hours);
        }

    }
}