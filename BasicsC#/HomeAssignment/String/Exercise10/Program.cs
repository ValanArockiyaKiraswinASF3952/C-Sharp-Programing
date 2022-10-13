using System;
namespace Exercise10;
class Program
{
    public static void Main(string[] args)
    {
       string username, password;
       int correct = 0;
         
        do
        {
            Console.Write("Input a username: ");
            username = Console.ReadLine();
 
            Console.Write("Input a password: ");
            password = Console.ReadLine();
            
             if(username != "user" || password != "pass")
             correct++;
             else
             correct=1;
     
        }
        while((username != "user" || password != "pass")  && (correct != 3));
     
        if (correct == 3)
            Console.WriteLine("Login attemp three or more times. Try later!");
        else   
            Console.WriteLine("The password entered successfully!");        
    }
}