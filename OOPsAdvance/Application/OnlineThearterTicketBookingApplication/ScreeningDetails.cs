namespace OnlineThearterTicketBookingApplication
{
    public class ScreeningDetails
    {
        /// <summary>
        /// Class <see cref="ScreeningDetails"/> property MovieID used to provide MovieID of user
        /// </summary>
        public string MovieID { get; set; }
        /// <summary>
        /// Class <see cref="ScreeningDetails"/> property TheatreID used to provide TheatreID of user
        /// </summary>
        public string TheatreID { get; set; }
        /// <summary>
        /// Class <see cref="ScreeningDetails"/> property NoOfSeatsAvailable used to provide NoOfSeatsAvailable of user
        /// </summary>
        public int NoOfSeatsAvailable { get; set; }
        /// <summary>
        /// Class <see cref="ScreeningDetails"/> property TicketPrice used to provide TicketPrice of user
        /// </summary>
        public double TicketPrice { get; set; }
        /// <summary>
        /// Constructor of <see cref="ScreeningDetails"/> class sused to initilize value to its property
        /// </summary>
        /// <param name="movieID">Parameter movieID used to initialize value to a user movieID to movieID property</param>
        /// <param name="theatreID">Parameter theatreID used to initialize value to a user theatreID to theatreID property</param>
        /// <param name="noOfSeatsAvailable">Parameter noOfSeatsAvailable used to initialize value to a user noOfSeatsAvailable to noOfSeatsAvailable property</param>
        /// <param name="ticketPrice">Parameter ticketPrice used to initialize value to a user ticketPrice to ticketPrice property</param>
        public ScreeningDetails(string movieID,string theatreID,int noOfSeatsAvailable,double ticketPrice)
        {
            MovieID=movieID;
            TheatreID=theatreID;
            NoOfSeatsAvailable=noOfSeatsAvailable;
            TicketPrice=ticketPrice;
        }
        public ScreeningDetails(string data)
        {
            string [] values = data.Split(',');
            MovieID=values[0];
            TheatreID=values[1];
            NoOfSeatsAvailable=int.Parse(values[2]);
            TicketPrice=double.Parse(values[3]);
        }
    }
}