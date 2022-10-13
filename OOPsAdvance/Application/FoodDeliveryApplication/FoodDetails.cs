namespace FoodDeliveryApplication
{
    public class FoodDetails
    {
        private static int s_foodID=100;
        public string FoodID { get; set; }
        public string FoodName { get; set; }
        public int PricePerQuantity { get; set; }

        public FoodDetails(string foodName, int pricePerQuantity)
        {
            FoodID="FID"+s_foodID++;
            FoodName=foodName;
            PricePerQuantity=pricePerQuantity;
        }
        public FoodDetails(string data)
        {
        string [] values = data.Split(',');
        s_foodID=int.Parse(values[0].Remove(0,3));
        FoodID=values[0];
        FoodName=values[1];
        PricePerQuantity=int.Parse(values[2]);
        }
        public void ShowFoodDetails()
        {
            System.Console.WriteLine("food ID: "+FoodID);
            System.Console.WriteLine("Food NAme :"+FoodName);
            System.Console.WriteLine("Price per Quantity:"+PricePerQuantity);
        }
    }
}