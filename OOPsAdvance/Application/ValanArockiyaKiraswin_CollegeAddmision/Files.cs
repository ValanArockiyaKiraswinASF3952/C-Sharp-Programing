using System;
using System.IO;
using System.Collections.Generic;
namespace CollegeAddmision
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("College"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("College");
            }
            if(!File.Exists("College/StudentDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("College/StudentDetails.csv");
            }
            if(!File.Exists("College/DepartmentDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("College/DepartmentDetails.csv");
            }
            if(!File.Exists("College/AdmissionDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("College/AdmissionDetails.csv");
            }
        } 



         public static void ReadFile()
        {
            string [] students = File.ReadAllLines("College/StudentDetails.csv");
            foreach(string data in students)
            {
            StudentDetails student = new StudentDetails(data);
            Operations.studentList.Add(student);  
            }

            string [] department = File.ReadAllLines("College/DepartmentDetails.csv");
            foreach(string datas in department)
            {
            DepartmentDetails dept = new DepartmentDetails(datas);
            Operations.departmentList.Add(dept);  
            }

            string [] admission = File.ReadAllLines("College/AdmissionDetails.csv");
            foreach(string dat in admission)
            {
            AddmissionDetails addmission = new AddmissionDetails(dat);
            Operations.addmissionList.Add(addmission);  
            }
            
        }
        public static void WriteToFile()
        {
            



            string [] studentDetails = new string[Operations.studentList.Count];
            for (int i=0;i<Operations.studentList.Count;i++)
            {
                studentDetails[i]=Operations.studentList[i].RegisterNumber+","+Operations.studentList[i].Name+","+Operations.studentList[i].FatherName+","+Operations.studentList[i].Gender+","+Operations.studentList[i].Physics+","+Operations.studentList[i].Chemistry+","+Operations.studentList[i].Maths;
            }
            File.WriteAllLines("College/StudentDetails.csv",studentDetails);

            string [] departmentDetails = new string[Operations.departmentList.Count];
            for (int i=0;i<Operations.departmentList.Count;i++)
            {
                departmentDetails[i]=Operations.departmentList[i].DepartmentID+","+Operations.departmentList[i].DepartmentName+","+Operations.departmentList[i].NoOfSeat;
            }
            File.WriteAllLines("College/DepartmentDetails.csv",departmentDetails);

            string [] admissionDetails = new string[Operations.addmissionList.Count];
            for (int i=0;i<Operations.addmissionList.Count;i++)
            {
                admissionDetails[i]=Operations.addmissionList[i].AddmissionID+","+Operations.addmissionList[i].DepartmentID+","+Operations.addmissionList[i].StudentID+","+Operations.addmissionList[i].AddmissionDate+","+Operations.addmissionList[i].AddmissionStatus;
            }
            File.WriteAllLines("College/AdmissionDetails.csv",admissionDetails);
        }
    }
   
}