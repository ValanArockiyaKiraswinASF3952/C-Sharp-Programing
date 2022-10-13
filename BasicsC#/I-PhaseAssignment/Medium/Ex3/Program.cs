using System;
namespace Ex3;
class Program 
{
    public static void Main(string[] args)
    {
        int number,temp,rem;
        Console.Write("Enter a number: ");  
        number = Convert.ToInt32(Console.ReadLine());  
        temp = number;  
        int sum=0;
        while (number > 0) 
        {  
            rem = number % 10;     
            number = number / 10;     
            sum = sum * 10 + rem;  
         
        }  
        Console.WriteLine($"The Reversed number is: {sum} ");  
        if (temp == sum)    
        {  
            Console.WriteLine("The number is Palindrome.");  
        } 
        else 
        {  
            Console.WriteLine("The number is not a palindrome. ");  
        }    
    }
}