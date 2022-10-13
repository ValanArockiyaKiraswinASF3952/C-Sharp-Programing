using System;
namespace Ex2;
class Program 
{
    public static void Main(string[] args)
    {
        ShiftDezire car = new ShiftDezire("petrol",6,"Green",12,2000,1234,098);
        car.ShowDetails("chennai","Shift");
        car.Show();

        Eco cars = new Eco("Deasel",7,"Black",12,2500,1234,0987);
        cars.ShowDetails("madurai","eco");
        cars.Show();
    }
}