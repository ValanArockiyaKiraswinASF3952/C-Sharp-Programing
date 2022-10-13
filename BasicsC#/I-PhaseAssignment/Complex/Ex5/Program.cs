using System;
namespace Ex5;
 
class Program
{
    public static bool IsPalindrome(string text)
    {
        if (text.Length <= 1)
            return true;
        else
        {
            if ( text[0] != text[ text.Length - 1 ] )
                return false;
            else
                return IsPalindrome( text.Substring( 1, text.Length-2 ) );
        }   
    }   
    public static void Main(string[] args)
    {
      string str1;
      bool tf;

      Console.Write(" Input a string : ");
      str1 = Console.ReadLine();
      tf=IsPalindrome(str1);
      if (tf==true)
      {
      Console.WriteLine(" The string is Palindrome.");
      }
      else
      {
       Console.WriteLine(" The string is not a Palindrome.");
      }
    }
}
