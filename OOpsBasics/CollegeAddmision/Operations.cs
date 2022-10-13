using System;
using System.Collections.Generic;

namespace CollegeAddmision
{
    public static class Operations 
    {
        static StudentDetails currentStudent = null;
        static List<StudentDetails> studentList = new List<StudentDetails>(); //File
        public static void MainMenu()
        {
            string choice = "yes";
            do
            {
            System.Console.WriteLine("Select Option 1.Registration 2.Login 3.Exit ");
            int option = int.Parse(Console.ReadLine());
            
            switch (option)
            {
                case 1:
                {
                    System.Console.WriteLine("Registration");
                    Registration();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Login");
                    Login();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Exit");
                    choice="no";
                    break;
                }
            }
            }while(choice=="yes");

        }   
        
        public static void Registration()
        {
            System.Console.WriteLine("StudentDetails \n");
            System.Console.WriteLine("Enter Name : ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter FatherName : ");
            string fatherName = Console.ReadLine();
            System.Console.WriteLine("Enter DOB (dd/MM/yyyy): ");
            DateTime dob = DateTime.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter gender: ");
            Gender gender =Enum.Parse<Gender>( Console.ReadLine(),true);
            System.Console.WriteLine("Enter Phone number : ");
            long phone = long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter mail : ");
            string mail = Console.ReadLine();
            System.Console.WriteLine("Enter Physics Mark : ");
            int physics = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enetr Chemistry Mark: ");
            int chemistry = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Maths Mark    : ");
            int maths = int.Parse(Console.ReadLine());

            StudentDetails student1 = new StudentDetails(name,fatherName,dob,gender,mail,phone,
                                            physics,chemistry,maths);  //Application form printout

            studentList.Add(student1);

            System.Console.WriteLine("Register number is: "+(student1.RegisterNumber));

        }
    
        public static void Login()
        {
            System.Console.WriteLine("Enter your Registration Number: ");
            string registerNumber = Console.ReadLine().ToUpper();
            foreach(StudentDetails student in studentList)
            {
                if (student.RegisterNumber==registerNumber)
                {
                    System.Console.WriteLine("Login Successful");
                    currentStudent=student;
                    SubMenu();
                }
            }
            }

        public static void SubMenu()
        {
            string choice="yes";
            do{
                System.Console.WriteLine("Select SubMenu Options");
                System.Console.WriteLine("1.Show Details 2.Check Eligiblity 3.Exit");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Show Details");
                        currentStudent.ShowDetails();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Check Eligiblity");
                        bool eligible = currentStudent.CheckEligibility(75.0);
                        if (eligible)
                        {
                            System.Console.WriteLine("you are eligible for admission.");
                        }
                        else
                        {
                            System.Console.WriteLine("You are not eligible for admision.");
                        }
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Exit SubMenu");
                        choice="no";
                        break;
                    }
                }
            }while(choice=="yes");

        }
    }
}