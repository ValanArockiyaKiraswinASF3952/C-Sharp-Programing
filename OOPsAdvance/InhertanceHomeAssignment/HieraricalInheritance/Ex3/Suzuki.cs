using System;
namespace Ex3
{
    public class Suzuki:CarInfo
    {
        public int CarModelNumber { get; set; }
        public string CarModelName { get; set; }

        public Suzuki(int rCBookNumber, int engineNumber, int chasisNumber, int milage, int tankCapacity, int numberOfSeats, int numberOfKmDriven, DateTime dateOfPurchase,int carModelNumber,string carModelName):base( rCBookNumber,  engineNumber,  chasisNumber,  milage,  tankCapacity,  numberOfSeats,  numberOfKmDriven,  dateOfPurchase)
        {
            CarModelName=carModelName;
            CarModelNumber=carModelNumber;
        }

        public void ShowSuzuki()
        {
            ShowCar();
            System.Console.WriteLine("Enter CarModelName: "+CarModelName);
            System.Console.WriteLine("Enter CarModelNumber: "+CarModelNumber);
        }
    }
}