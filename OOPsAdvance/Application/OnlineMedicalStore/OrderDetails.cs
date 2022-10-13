using System;
namespace OnlineMediaStore
{
    public enum OrderStatus{Default,Purchased,Cancelled}
    public class OrderDetails
    {
        private static int s_orderId=2000;
        public string OrderID { get; set; }
        public string UserID { get; set; }
        public string MedicineID { get; set; }
        public int MedicineCount { get; set; }
        public int TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public OrderDetails(string userID,string medicineID,int medicineCount, int totalPrice, DateTime orderDate, OrderStatus orderStatus)
        {
            OrderID="OID"+s_orderId++;
            UserID=userID;
            MedicineID=medicineID;
            MedicineCount=medicineCount;
            TotalPrice=totalPrice;
            OrderDate=orderDate;
            OrderStatus=orderStatus;
        }
         public OrderDetails(string dat)
       {
        string [] values = dat.Split(',');
        s_orderId=int.Parse(values[0].Remove(0,3));
        OrderID=values[0];
        UserID=values[1];
        MedicineID=values[2];
        MedicineCount=int.Parse(values[3]);
        TotalPrice=int.Parse(values[4]);
        OrderDate=DateTime.Parse(values[5]);
        OrderStatus=Enum.Parse<OrderStatus>(values[6]);
       }


    }
}