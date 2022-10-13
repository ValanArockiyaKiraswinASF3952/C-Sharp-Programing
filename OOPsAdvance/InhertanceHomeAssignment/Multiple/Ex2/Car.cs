namespace Ex2
{
    public class Car
    {
        public string FuleType { get; set; }
        public int NumberOfSeats { get; set; }
        public string Color { get; set; }
        public int TankCapacity { get; set; }
        public int NumberOfKmDriven { get; set; }

        public Car(string fuleType,int numberOfSeats,string color,int tankCapacity,int numberOfKmDriven)
        {
            FuleType=fuleType;
            NumberOfSeats=numberOfSeats;
            Color=color;
            TankCapacity=tankCapacity;
            NumberOfKmDriven=numberOfKmDriven;
        }

        public void Milage()
        {
            System.Console.WriteLine("Eneter FuleType: "+FuleType);
            System.Console.WriteLine("Enter NumberOfSeats: "+NumberOfSeats);
            System.Console.WriteLine("Enter Color: "+Color);
            System.Console.WriteLine("Enter TankCapacity: "+TankCapacity);
            System.Console.WriteLine("Enter NumberOfKmDriven: "+NumberOfKmDriven);
        }
    }
}