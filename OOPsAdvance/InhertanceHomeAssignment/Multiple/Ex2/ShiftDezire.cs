using System;
namespace Ex2
{
    public class ShiftDezire:Car,IBrand
    {
        private static int s_carI=1000;
        public string CarID { get; set; }
        public int EngineNumber { get; set; }
        public int ChasisNumber { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }

        


        public ShiftDezire(string fuleType,int numberOfSeats,string color,int tankCapacity,int numberOfKmDriven,int engineNumber,int chasisNumber):base( fuleType, numberOfSeats, color, tankCapacity, numberOfKmDriven)
        {
            CarID="CID"+s_carI++;
            EngineNumber=engineNumber;
            ChasisNumber=chasisNumber;
        }
        public  void ShowDetails(string brandName,string modelName)
        {
            BrandName=brandName;
            ModelName=modelName;
            
        }
        public void Show()
        {
            System.Console.WriteLine("Enter brant name "+ BrandName);
            System.Console.WriteLine("Enter the Model name "+ModelName);
            Milage();
        }

    }
}