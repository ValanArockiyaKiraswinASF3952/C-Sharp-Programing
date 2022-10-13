using System;
using System.Collections.Generic;
namespace CovidVaccination;
class Program
{
    public static void Main(string[] args)
    {
        Files.Create();
        Files.ReadFile();
        Operation.MainMenu();
        Files.WriteToFiles();
    }
}