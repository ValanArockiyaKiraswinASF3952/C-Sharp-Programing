namespace EcommerceAplplication;
class Program
{
    public static void Main(string[] args)
    {
        Files.Create();
        //Operations.AddDefaultValues();
        Files.ReadFile();
        Operations.MainMenu();
        Files.WriteToFile();
    }
}