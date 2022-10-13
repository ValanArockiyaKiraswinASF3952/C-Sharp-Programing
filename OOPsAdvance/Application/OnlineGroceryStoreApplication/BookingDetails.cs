using System;
namespace OnlineGroceryStoreApplication
{
    public enum BookingStatus{Default,Initiated,Booked,Cancelled}
    public class BookingDetails
    {
        private static int s_bookingID=3000;
        public string BookingID { get; set; }
        public string CustomerID { get; set; }
        public double TotalPrice { get; set; }
        public DateTime DateOfBooking { get; set; }

        public BookingStatus BookingStatus { get; set; }

        public BookingDetails(string customerID,double totalPrice,DateTime dateOfBooking,BookingStatus bookingStatus)
        {
            s_bookingID++;
            BookingID="BID"+s_bookingID;
            CustomerID=customerID;
            TotalPrice=totalPrice;
            DateOfBooking=dateOfBooking;
            BookingStatus= bookingStatus;
        }
         
        public BookingDetails(string data)
        {
            string [] values = data.Split(',');
            s_bookingID=int.Parse(values[0].Remove(0,3));
            BookingID=values[1];
            CustomerID=values[2];
            TotalPrice=double.Parse(values[3]);
            DateOfBooking=DateTime.Parse(values[4]);
            BookingStatus=Enum.Parse<BookingStatus>(values[5]);

        }

        public void ShowBookingDetails()
        {
            System.Console.WriteLine("\nBookingID     : "+BookingID);
            System.Console.WriteLine("CustomerID    : "+CustomerID);
            System.Console.WriteLine("Total Price   : "+TotalPrice);
            System.Console.WriteLine("DateOfBooking : "+DateOfBooking.ToString("dd/MM/yyyy"));
            System.Console.WriteLine("BookingStatus : "+BookingStatus);
        }
    }
}