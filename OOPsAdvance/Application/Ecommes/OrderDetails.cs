using System;
namespace EcommerceAplplication
{
    public enum OrderStatus{Default,Ordered,Canceled}
    public class OrderDetails
    {
        private static int s_orderID=1000;
        public string OrderID{get;}
        //private static int s_customerID=1000; 
        public string CustomerID{get;}
        public string ProductID{get;}
        public double TotalPrice{get;set;}
        public DateTime PurchaseDate{get;set;}
        public int Quanity {get;set;}
        public OrderStatus OrderStatus{get;set;}

        public OrderDetails(string customerId,string productId,double totalPrice, DateTime purchaseDate,int quantity,OrderStatus orderStatus)
        {
            s_orderID++;
            OrderID="OI"+s_orderID;
            
            TotalPrice=totalPrice;
            PurchaseDate=purchaseDate;
            Quanity=quantity;
            OrderStatus=orderStatus;
        }

         public OrderDetails(string datas)
        {
            string [] values = datas.Split(',');
            s_orderID=int.Parse(values[0].Remove(0,2));
            OrderID=values[0];
            TotalPrice=double.Parse(values[1]);
            PurchaseDate=DateTime.Parse(values[2]);
            Quanity=int.Parse(values[3]);
            OrderStatus=Enum.Parse<OrderStatus>(values[4]);
        }
    }
}