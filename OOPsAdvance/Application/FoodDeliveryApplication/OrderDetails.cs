using System;
namespace FoodDeliveryApplication
{
    public class OrderDetails
    {
        private static int s_orderID=100;
        public string OrderID { get;  }
        public string BookingID { get; set; }
        //public string ProductID { get; set; }
        public string FoodID { get; set; }
        public int PurchaseCount { get; set; }
        public double PriceOfOrder { get; set; }

        public OrderDetails(string bookingID,string foodID,int purchaseCount,double priceOfOrder)
        {
            s_orderID++;
            OrderID="OID"+s_orderID;
            BookingID=bookingID;
            //ProductID=productID;
            FoodID=foodID;
            PurchaseCount=purchaseCount;
            PriceOfOrder=priceOfOrder;
        }
        public OrderDetails(string datas)
        {
        string [] values = datas.Split(',');
        s_orderID=int.Parse(values[0].Remove(0,3));
        OrderID=values[0];
        BookingID=values[1];
        FoodID=values[2];
        PurchaseCount=int.Parse(values[3]);
        PriceOfOrder=double.Parse(values[4]);
        }
    }
}