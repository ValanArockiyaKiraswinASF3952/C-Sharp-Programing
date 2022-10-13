using AdmissionLibrary;
namespace AdmissionApplication;
public class Operations
{
    public static void MainMenu()
    {
        List<StudentDetails> studentList = new List<StudentDetails>(); //File
        System.Console.WriteLine("Are You willing to join this college.");
        string willing = Console.ReadLine();

        do
        {
            System.Console.WriteLine("\nRead data");
            System.Console.WriteLine("Admitte");
            
            

            System.Console.WriteLine("StudentDetails 1\n");
            System.Console.WriteLine("Enter Name : ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter FatherName : ");
            string fatherName = Console.ReadLine();
            System.Console.WriteLine("Enter DOB : ");
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

            StudentDetails student1 = new StudentDetails(name,fatherName,dob,gender,mail,phone,physics,chemistry,maths);  //Application form printout

            studentList.Add(student1);

            System.Console.WriteLine("Register number is: "+(student1.RegisterNumber));

            System.Console.WriteLine("Are You willing to join this college.");
            willing = Console.ReadLine().ToLower();

        }while (willing=="yes");
        
        
        foreach(StudentDetails student in studentList)
        {
        System.Console.WriteLine($"\nYour Name is {student.Name}");
        System.Console.WriteLine($"Your FatherName is {student.FatherName}");
        System.Console.WriteLine($"Your DOB is {student.DOB}");
        System.Console.WriteLine($"Your Phone number is {student.Phone}");
        System.Console.WriteLine($"Your mail is {student.Mail}");
        System.Console.WriteLine($"Your Physics Mark is {student.Physics}");
        System.Console.WriteLine($"Your Chemistry Mark is {student.Chemistry}");
        System.Console.WriteLine($"Your Maths Mark is {student.Maths}");
        System.Console.WriteLine("Register number is: "+(student.RegisterNumber));
        //method:
        bool eligible = student.CheckEligibility(75.0);
        if (eligible)
        {
            System.Console.WriteLine("you are eligible for admission.");
        }
        else
        {
            System.Console.WriteLine("You are not eligible for admision.");
        }

        }
    }
}
