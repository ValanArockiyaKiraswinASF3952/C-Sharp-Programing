namespace EcommerceAplplication
{
    public class ProductDetails
    {
         private static int s_produtID=100;
       
        public string ProductID{get;}
        public string ProductName{get;set;}
        public double Price{get;set;}
    
        public int Stock {get;set;}
        public int ShipingDuration {get;set;}

        public ProductDetails(string productName,int stock,double price,int shipingDuration)
        {
            s_produtID++;
            ProductID="PID"+s_produtID;
            ProductName=productName;
            Price=price;
            Stock=stock;
            ShipingDuration=shipingDuration;

        }

        public ProductDetails(string dat)
        {
            string [] values = dat.Split(',');
            s_produtID=int.Parse(values[0].Remove(0,3));
            ProductID=values[0];
            ProductName=values[1];
            Price=int.Parse(values[2]);
            Stock=int.Parse(values[3]);
            ShipingDuration=int.Parse(values[4]);
        }
    }
}



