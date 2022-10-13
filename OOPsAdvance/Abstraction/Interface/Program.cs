using System;
namespace Interface;
class Program 
{
    public static void Main(string[] args)
    {
        Draw rectangle = new Draw(12,6);
        rectangle.CalculateArea();
        
    }
}