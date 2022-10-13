using System;
using System.Collections;
namespace CollegeAddmision
{
    public delegate void EventManager();
    public static class Operations 
    {
        public static event EventManager eventlink=null;
        //static DepartmentDetails currentDepartment = null;
        public static StudentDetails currentStudent = null;
        public static List<StudentDetails> studentList = new List<StudentDetails>(); //File
        public static List<DepartmentDetails> departmentList = new List<DepartmentDetails>();
        public static List<AddmissionDetails> addmissionList = new List<AddmissionDetails>();
     
        public static void Subscribe()
        {
            eventlink += new EventManager(Files.Create);
            eventlink += new EventManager(Files.ReadFile);
            eventlink += new EventManager(MainMenu);
            eventlink += new EventManager(Files.WriteToFile);
        }
        public static void StartEvent()
        {
            Subscribe();
            eventlink();
        }
        
        //static List<DefaultStudentDetails> studentList1 = new List<DefaultStudentDetails>(); //File
        
        public static void MainMenu()
        {
            string choice = "yes";
            do
            {
            System.Console.WriteLine("Select Option 1.Registration 2.Login 3.Check Department wise seat availability 4.Exit ");
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
                    System.Console.WriteLine("Check Department wise seat availability");
                    System.Console.WriteLine("                  Department ID  DepartmentName Number of seat");
                    foreach(DepartmentDetails department in departmentList)
                    {
                        System.Console.WriteLine($"Department ID:       {department.DepartmentID}            {department.DepartmentName}          {department.NoOfSeat}");
                    }
                    break;
                }
                case 4:
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

                StudentDetails student3 = new StudentDetails(name,fatherName,dob,gender,mail,phone,
                                                physics,chemistry,maths);  //Application form printout

                studentList.Add(student3);

                System.Console.WriteLine("Register number is: "+(student3.RegisterNumber));
                System.Console.WriteLine("\nStudent Added Successfully and StudentID – "+(student3.RegisterNumber));

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
                else
                {
                    System.Console.WriteLine("Invalid UserID");
                    break;
                }
            }
            }

        public static void SubMenu()
        {
            string choice="yes";
            do{
                System.Console.WriteLine("Select SubMenu Options");
                System.Console.WriteLine("1.Show Details 2.Check Eligiblity 3.Take Admission 4.Cancel Addmission 5.Show Addmission Details 6.Exit");
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
                        System.Console.WriteLine("Take Addmission");
                        TakeAddmission();
                       
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Cancel Addmission");
                        CancelAdmission();
                        break;
                    }
                    case 5:
                    {
                        System.Console.WriteLine("Show Addmission Details");
                        ShowAdmissionDetails();
                        break;
                    }
                    case 6:
                    {
                        System.Console.WriteLine("Exit SubMenu");
                        choice="no";
                        break;
                    }
                }
            }while(choice=="yes");


        }
        public static void TakeAddmission()
        {
            System.Console.WriteLine("                  Department ID  DepartmentName Number of seat");
            foreach(DepartmentDetails department in departmentList)
            {
                System.Console.WriteLine($"Department ID:       {department.DepartmentID}            {department.DepartmentName}          {department.NoOfSeat}");
            }
            
            System.Console.WriteLine("enetr Department id: ");
            string deptId=Console.ReadLine();
            

            foreach(DepartmentDetails department in departmentList)
            {
                if (deptId==department.DepartmentID)
                {
                if(department.NoOfSeat >=1)
                {
                    bool eligibility=currentStudent.CheckEligibility(75.0);
                    if(eligibility==true)
                    {
                        
                            System.Console.WriteLine("your eligible for admiddion");
                            bool canAdmit=true;
                            foreach(AddmissionDetails addmission in addmissionList)
                            {
                                if(addmission.StudentID==currentStudent.RegisterNumber)
                                {
                                if(addmission.AddmissionStatus==AddmissionStatus.Booked)
                                {
                                    System.Console.WriteLine("Student already admited");
                                    canAdmit=false;
                                }
                                }
                            }
                            
                            if(canAdmit==true)
                            {
                                //reduce the seat count by one
                                department.NoOfSeat-=1;
                                //create object for ad,ission details
                                AddmissionDetails newAdmission = new AddmissionDetails(currentStudent.RegisterNumber,department.DepartmentID,DateTime.Now,AddmissionStatus.Booked);
                                if(newAdmission.AddmissionStatus==AddmissionStatus.Default)
                                {
                                    System.Console.WriteLine("Booked");
                                }
                                addmissionList.Add(newAdmission);
                                System.Console.WriteLine("Admission successful. your admission id is"+newAdmission.AddmissionID);
                            }
                            else
                            {
                                System.Console.WriteLine("Student already admited.");
                            }
                            
                        
                                                
                    }
                    else
                        {
                            System.Console.WriteLine("Student is not eligible.");
                        }
                }
                else
                {
                    System.Console.WriteLine("Seat not availability.");
                }
            }
            }
        }
        
        public static void CancelAdmission()
        {
            //Show student Admission details
            foreach(AddmissionDetails addmission in addmissionList)
            {
                System.Console.WriteLine("\n");
                System.Console.WriteLine(addmission.AddmissionID+"/t"+addmission.StudentID+"/t"+addmission.DepartmentID+"/t"+addmission.AddmissionDate+"/t"+addmission.AddmissionStatus);
                {
                    if(addmission.StudentID==currentStudent.RegisterNumber)
                {
                    addmission.AddmissionStatus=AddmissionStatus.Cancel;
                    foreach(DepartmentDetails department in departmentList)
                    {
                        if(department.DepartmentID==addmission.DepartmentID)
                        {
                            System.Console.WriteLine("Admission cancel successfully");
                            department.NoOfSeat+=1;
                            //System.Console.WriteLine("The student admission details is: ");
                            //System.Console.WriteLine(addmission.AddmissionID+"/t"+addmission.StudentID+"/t"+addmission.DepartmentID+"/t"+addmission.AddmissionDate+"/t"+addmission.AddmissionStatus);
                        }
                    }
                }
                }
            }       
        }
        
        /*public static void AddDefaultData()
        {
            //Student Details
            StudentDetails student1 = new StudentDetails("Ravichandran E", "Ettapparajan",new DateTime(1999,11,11), Gender.Male,"ravi@gmail",99988654, 95, 95, 95);
            studentList.Add(student1);
            StudentDetails student2 = new StudentDetails("Baskaran S", "Sethurajan",new DateTime(1999,11,11), Gender.Male,"baskar@gmail",9998865432, 95, 95, 95);
            studentList.Add(student2);   

            //Admission Details
            AddmissionDetails addmission1 = new AddmissionDetails("SF3001","DID101", new DateTime(11/05/2022),AddmissionStatus.Booked);
            addmissionList.Add(addmission1);
            AddmissionDetails addmission2 = new AddmissionDetails("SF3002","DID102", new DateTime(12/05/2022),AddmissionStatus.Booked);
            addmissionList.Add(addmission2);

            //Department Details
            DepartmentDetails department1 = new DepartmentDetails("EEE ",29);
            departmentList.Add(department1);
            DepartmentDetails department2 = new DepartmentDetails("CSE ",29);
            departmentList.Add(department2);
            DepartmentDetails department3 = new DepartmentDetails("MECH",30);
            departmentList.Add(department3);
            DepartmentDetails department4 = new DepartmentDetails("ECE ",30);
            departmentList.Add(department4);  
        }*/
        
        public static void ShowAdmissionDetails()
        {
            foreach(AddmissionDetails addmission in addmissionList)
            {
                if(addmission.StudentID==currentStudent.RegisterNumber)
                {
                    System.Console.WriteLine("The student admission details is: ");
                    System.Console.WriteLine(addmission.AddmissionID+"/t"+addmission.StudentID+"/t"+addmission.DepartmentID+"/t"+addmission.AddmissionDate+"/t"+addmission.AddmissionStatus);
                }
            }
        }
     
     }
}
