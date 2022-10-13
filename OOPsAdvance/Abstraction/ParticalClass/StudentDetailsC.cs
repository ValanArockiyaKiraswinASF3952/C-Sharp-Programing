namespace ParticalClass
{
    public partial class StudentDetails
    {
        public void ShowDetails()
        {
            System.Console.WriteLine($"\nYour Name is {Name}");
            System.Console.WriteLine($"Your FatherName is {FatherName}");
            System.Console.WriteLine($"Your DOB is {DOB}");
            System.Console.WriteLine($"Your Phone number is {Phone}");
            System.Console.WriteLine($"Your mail is {Mail}");
            System.Console.WriteLine($"Your Physics Mark is {Physics}");
            System.Console.WriteLine($"Your Chemistry Mark is {Chemistry}");
            System.Console.WriteLine($"Your Maths Mark is {Maths}");
            System.Console.WriteLine("Register number is: "+(RegisterNumber));
        }     
    }
}