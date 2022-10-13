using System;  
namespace Exercise6;
class Program
{  
    public static void Main(string[] args)
{
    string str;
    int alphabet, digit, specialCharacter, i,length;
    alphabet = digit = specialCharacter = i = 0;

      Console.Write("Input the string : ");
      str = Console.ReadLine(); 
      length=str.Length; 

    while(i<length)
    {
        if((str[i]>='a' && str[i]<='z') || (str[i]>='A' && str[i]<='Z'))
        {
            alphabet++;
        }
        else if(str[i]>='0' && str[i]<='9')
        {
            digit++;
        }
        else
        {
            specialCharacter++;
        }

        i++;
    }

   Console.WriteLine($"Number of alphabethabets in the string is : {alphabet}");
   Console.WriteLine($"Number of Digits in the string is : {digit}");
   Console.WriteLine($"Number of Special characters in the string is : {specialCharacter}");
    }
}