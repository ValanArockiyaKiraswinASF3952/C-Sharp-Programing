using System;
namespace PesonalDetails;
class Program 
{
    public static void Main(string[] args)
    {
        Employement userDetails=new Employement("valan", "jesu", Gender.Male, 5468737);
        userDetails.ShowDetails();
    }
}