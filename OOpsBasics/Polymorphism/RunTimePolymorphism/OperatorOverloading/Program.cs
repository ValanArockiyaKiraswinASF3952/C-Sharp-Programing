using System;
namespace OperatorOverloading;
class Program 
{
    public static void Main(string[] args)
    {
        Box box1 = new Box(2,2,2);
        double volume1=box1.CalculateVolume();
        System.Console.WriteLine("Volume of box1:"+volume1);

        Box box2 = new Box(2,4,2);
        double volume2=box2.CalculateVolume();
        System.Console.WriteLine("Volume is box2:"+volume2);

        Box box4 = new Box(2,2,6);
        double volume3=box4.CalculateVolume();
        System.Console.WriteLine("Volume is box3:"+volume3);
        
        Box box3;
        box3 = box1+box2;
        double volume4=box3.CalculateVolume();
        System.Console.WriteLine("Volume is box4:"+volume4);

    }
}