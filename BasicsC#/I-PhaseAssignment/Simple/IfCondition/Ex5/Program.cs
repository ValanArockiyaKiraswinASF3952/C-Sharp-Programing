using System;
namespace Ex5;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the character: ");
        char character = char.Parse(Console.ReadLine());
        if ((character== 'a') || (character== 'e') || (character== 'i') || (character== 'o') || (character=='u'))
        {
            System.Console.WriteLine("Vovel");
        }
        else if ((character== 'A') || (character== 'E') || (character== 'I') || (character== 'O') || (character=='U'))
        {
            System.Console.WriteLine("Vovel");
        }
        else
        {
            System.Console.WriteLine("It is not a vowel");
        }

    }
}