using System;
namespace FoodDeliveryApplication
{
    public enum BookingStatus{Default,Initiated,Booked,Cancelled}
    public class BookingDetails
    {
        private static int s_bookingID=3000;
        public string BookingID { get;  }
        public string CusdtomerID { get; set; }
        public double TotalPrice { get; set; }
        public DateTime DateOfBooking { get; set; }
        public BookingStatus BookingStatus { get; set; }

        public BookingDetails(string customerID, double totalPrice, DateTime dateOfBooking,BookingStatus bookingStatus)
        {
            BookingID="BID"+s_bookingID++;
            CusdtomerID=customerID;
            TotalPrice=totalPrice;
            DateOfBooking=dateOfBooking;
            BookingStatus=bookingStatus;
        }
        public BookingDetails(string dat)
        {
            string [] values = dat.Split(',');
        s_bookingID=int.Parse(values[0].Remove(0,3));
        BookingID=values[0];
        CusdtomerID=values[1];
        TotalPrice=double.Parse(values[2]);
        DateOfBooking=DateTime.Parse(values[3]);
        BookingStatus=Enum.Parse<BookingStatus>(values[4]);
        }
    }
}