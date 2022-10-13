using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ListFileManupulation;
class Program 
{
    public static void Main(string[] args)
    {
        List<StudentDetails> student = new List<StudentDetails>();
        student.Add(new StudentDetails(){Name="valan",FatherName="Jesu",Gender=Gender.Male,DOB=new DateTime(11/11/1111)});
        student.Add(new StudentDetails(){Name="sutharsan",FatherName="suresh",Gender=Gender.Male,DOB=new DateTime(11/11/1199)});
        student.Add(new StudentDetails(){Name="suresh",FatherName="kumar",Gender=Gender.Male,DOB=new DateTime(11/11/1999)});
        Insert(student);
        Display();
        Update();
    }
    static void Insert(List<StudentDetails> student)
    {
        StreamWriter write = null;
        if(!File.Exists("Data.csv"))
        {
            System.Console.WriteLine("File doesn't exist. Create a new csv file");
            File.Create("Data.csv");
        }
        else
        {
            System.Console.WriteLine("File found");
        }
        write=new StreamWriter(File.OpenWrite("Data.csv"));
        foreach(var v in student)
        {
            write.WriteLine(v.Name+","+v.FatherName+","+v.Gender+","+v.DOB.ToString("dd/MM/yyyy"));
        }
        write.Close();
    }
    static void Display()
    {
        StreamReader reader = null;
        List<StudentDetails> listA = new  List<StudentDetails>();
        if(File.Exists("Data.csv"))
        {
            reader=new StreamReader(File.OpenRead("Data.csv"));
            while(!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                if(values[0]!="")
                {
                    listA.Add(new StudentDetails(){Name=values[0],FatherName=values[1],Gender=Enum.Parse<Gender>(values[2]),DOB=DateTime.ParseExact(values[3],"dd/MM/yyyy",null)});
                }
            }
        }
        else
        {
            System.Console.WriteLine("File doesn't exist");
        }
        reader.Close();
        foreach(var c in listA)
        {
            System.Console.WriteLine("Your name: \t"+c.Name+"\t Father Name; "+c.FatherName+"\t Gender is: "+c.Gender+"\t DOB is: "+c.DOB);
        }
    }
    static void Update()
    {
        System.Console.WriteLine("To update Select option \n1.Your name \n2.Father name");
        int option = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the name to be update");
        string name = Console.ReadLine();
        string [] lines = File.ReadAllLines("Data.csv");
        for(int i=0;i<lines.Length;i++)
        {
            if(lines[i]!="")
            {
                var values = lines[i].Split(',');
                if (values[option]==name)
                {
                    System.Console.WriteLine("Enter the new update:");
                    string name1 = Console.ReadLine();
                    if(option==1)
                    {
                        lines[i]=name1+','+values[1]+','+values[2]+','+values[3];
                    }
                    else if (option==2)
                    {
                        lines[i]=values[0]+','+name1+','+values[2]+','+values[3];
                    }
                }
            }
        }
        File.WriteAllLines("Data.csv",lines);
    }
}