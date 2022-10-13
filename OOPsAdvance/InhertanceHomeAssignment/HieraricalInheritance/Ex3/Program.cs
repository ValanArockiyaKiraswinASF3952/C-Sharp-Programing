using System;
namespace Ex3;
class Program 
{
    public static void Main(string[] args)
    {
        Tata car = new Tata(123,987,555,55,12,35,25,new DateTime(11/11/1111),123,"tata");
        car.ShowTata();

        Suzuki cars = new Suzuki(123,987,555,55,12,35,25,new DateTime(11/11/1111),123,"tata");
        cars.ShowSuzuki();

    }
}