using System;
namespace FoodDeliveryApplication;
class Program 
{
    public static void Main(string[] args)
    {
        Files.Create();
        //Operations.DefaultValues();
        Files.ReadFile();
        Operations.MainMenu();
        Files.WriteToFile();
        // Operations.DefaultValues();
        // Operations.Registration();
    }
}