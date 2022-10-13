using System;
namespace OnlineThearterTicketBookingApplication
{
    public enum BookingStatus{Default,Booked,Cancelled}
    public class BookingDetails
    {
        private static int s_bookingID=7000;
        /// <summary>
        /// Class <see cref="BookingDetails"/> property BookingID used to uniquely identify BookingID of user
        /// </summary>
        public string BookingID  { get; set; }
        /// <summary>
        /// Class <see cref="BookingDetails"/> property UserId used to provide UserId of user
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// Class <see cref="BookingDetails"/> property MovieID used to provide MovieID of user
        /// </summary>
        public string MovieID { get; set; }
        /// <summary>
        /// Class <see cref="BookingDetails"/> property TheatreID used to provide TheatreID of user
        /// </summary>
        public string TheatreID  { get; set; }
        /// <summary>
        /// Class <see cref="BookingDetails"/> property SeatCount used to provide SeatCount of user
        /// </summary>
        public int SeatCount { get; set; }
        /// <summary>
        /// Class <see cref="BookingDetails"/> property TotalAmount used to provide TotalAmount of user
        /// </summary>
        public double TotalAmount { get; set; }
        /// <summary>
        /// Class <see cref="BookingDetails"/> property BookingStatus used to provide BookingStatus of user
        /// </summary>
        public BookingStatus BookingStatus { get; set; }
        /// <summary>
        /// Constructor of <see cref="BookingDetails"/> class sused to initilize value to its property
        /// </summary>
        /// <param name="userID">Parameter userID used to initialize value to a user userID to userID property</param>
        /// <param name="movieID">Parameter movieID used to initialize value to a user movieID to movieID property</param>
        /// <param name="theatreID">Parameter theatreID used to initialize value to a user theatreID to theatreID property</param>
        /// <param name="seatCount">Parameter seatCount used to initialize value to a user seatCount to seatCount property</param>
        /// <param name="totalAmount">Parameter totalAmount used to initialize value to a user totalAmount to totalAmount property</param>
        /// <param name="bookingStatus">Parameter bookingStatus used to initialize value to a user bookingStatus to bookingStatus property</param>
        public BookingDetails(string userID, string movieID,string theatreID,int seatCount,double totalAmount,BookingStatus bookingStatus)
        {
            s_bookingID++;
            BookingID="BID"+s_bookingID;
            UserId=userID;
            MovieID=movieID;
            TheatreID=theatreID;
            SeatCount=seatCount;
            TotalAmount=totalAmount;
            BookingStatus=bookingStatus;
        }

        public BookingDetails(string data)
        {
            string [] values = data.Split(',');
            s_bookingID = int.Parse(values[0].Remove(0,3));
            BookingID=values[0];
            UserId=values[1];
            MovieID=values[2];
            TheatreID=values[3];
            SeatCount=int.Parse(values[4]);
            TotalAmount=double.Parse(values[5]);
            BookingStatus=Enum.Parse<BookingStatus>(values[6]);
        }
    }
}