using System;
namespace ExceptionHandiling;
class Program 
{
    public static void Main(string[] args)
    {
        

        try
        {
            int number1, number2;
        int [] value = new int[1];
        System.Console.WriteLine("Enter the number1: ");
        number1= int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the number2: ");
        number2= int.Parse(Console.ReadLine());
            int output = number1/number2;
            System.Console.WriteLine("Output: "+output);

        }
        catch (DivideByZeroException e)
        {
            System.Console.WriteLine("An Exception occured:{0}",e.Message);
            System.Console.WriteLine("An Exception occured:{0}",e.StackTrace);
        }
        catch (FormatException e)
        {
            System.Console.WriteLine("An Exception occured:{0}",e.Message);
            System.Console.WriteLine("An Exception occured:{0}",e.StackTrace);
        }
        finally
        {
            System.Console.WriteLine("Final block called");
        }
        
        //int output = number1/number2;
        //System.Console.WriteLine("Output: "+output);
    }
}