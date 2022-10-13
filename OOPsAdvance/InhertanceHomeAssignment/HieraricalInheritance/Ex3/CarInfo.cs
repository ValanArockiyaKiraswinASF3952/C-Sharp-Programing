using System;
namespace Ex3
{
    public class CarInfo
    {
        public int RCBookNumber { get; set; }
        public int EngineNumber { get; set; }
        public int ChasisNumber { get; set; }
        public int Milage { get; set; }
        public int TankCapacity { get; set; }
        public int NumberOfSeats { get; set; }
        public int NumberOfKmDriven { get; set; }
        public DateTime DateOfPurchase { get; set; }

        public CarInfo(int rCBookNumber, int engineNumber, int chasisNumber, int milage, int tankCapacity, int numberOfSeats, int numberOfKmDriven, DateTime dateOfPurchase)
        {
            RCBookNumber=rCBookNumber;
            EngineNumber=engineNumber;
            ChasisNumber=chasisNumber;
            Milage=milage;
            TankCapacity=tankCapacity;
            NumberOfSeats=numberOfSeats;
            NumberOfKmDriven=numberOfKmDriven;
            DateOfPurchase=dateOfPurchase;
        }

        public void CalculateMilage()
        {
            Milage=TankCapacity*30;
        }

        public void ShowCar()
        {
            System.Console.WriteLine("Enter RCBookNumber: "+RCBookNumber);
            System.Console.WriteLine("Enter EngineNumber: "+EngineNumber);
            System.Console.WriteLine("Enter ChasisNumber: "+ChasisNumber);
            System.Console.WriteLine("Enter Milage: "+Milage);
            System.Console.WriteLine("Enter TankCapacity: "+TankCapacity);
            System.Console.WriteLine("Enter NumberOfSeats: "+NumberOfSeats);
            System.Console.WriteLine("Enter NumberOfKmDriven: "+NumberOfKmDriven);
            System.Console.WriteLine("Enter DateOfPurchase: "+DateOfPurchase);
        }

    }
}