using System;  
namespace Exercise4;
class Program
{  
    public static void Main(string[] args)
{
    string str;
    int  word,len;
        
      Console.Write("Input the string : ");
      str = Console.ReadLine();
    
    len = 0;
    word = 1;

    while (len <= str.Length - 1)
    {
    
        if(str[len]==' ' || str[len]=='\n' || str[len]=='\t')
        {
            word++;
        }

        len++;
    }

   Console.Write($"Total number of words in the string is : {word}");
    }
}