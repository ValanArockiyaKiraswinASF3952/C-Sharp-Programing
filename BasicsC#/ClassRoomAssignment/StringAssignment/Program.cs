using System;
namespace StringAssignment;
class Program 
{
    public static void Main(string[] args)
    {
        string result="";
        int count = 0;
        System.Console.Write("Enter the Main Stringcharacter: ");
        string mainString = Console.ReadLine();
        
        System.Console.Write("Enter the string to searched String: ");
        string searchedString = Console.ReadLine();

        

        for (int i =0; i<mainString.Length; i++)
        {
            for (int j=i; j<mainString.Length; j++)
            {
            
                result += mainString[j]; 
                if (result==searchedString)
                count+=1;
            }
            result="";
        }       
        System.Console.WriteLine("String Searched Count is: "+count);
    }
}