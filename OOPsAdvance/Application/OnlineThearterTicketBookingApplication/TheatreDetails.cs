namespace OnlineThearterTicketBookingApplication
{
    public class TheatreDetails
    {
        private static int s_theatreID = 300;
        /// <summary>
        /// Class <see cref="TheatreDetails"/> property TheatreID used to uniquely identify TheatreID of user
        /// </summary>
        public string TheatreID { get; set; }
        /// <summary>
        /// Class <see cref="TheatreDetails"/> property TheatreName used to provide TheatreName of user
        /// </summary>
        public string TheatreName { get; set; }
        // /<summary>
        /// Class <see cref="TheatreDetails"/> property TheatreLocation used to provide TheatreLocation of user
        /// </summary>
        public string TheatreLocation { get; set; }
        /// <summary>
        /// Constructor of <see cref="TheatreLocation"/> class sused to initilize value to its property
        /// </summary>
        /// <param name="theatreName">Parameter theatreName used to initialize value to a user theatreName to TheatreName property</param>
        /// <param name="theatreLocation">Parameter theatreLocation used to initialize value to a user theatreLocation to TheatreLocation property</param>
        public TheatreDetails(string theatreName,string theatreLocation)
        {
            s_theatreID++;
            TheatreID="TID"+s_theatreID;
            TheatreName=theatreName;
            TheatreLocation=theatreLocation;
        }
        public TheatreDetails(string data)
        {
            string [] values = data.Split(',');
            s_theatreID = int.Parse(values[0].Remove(0,3));
            TheatreID=values[0];
            TheatreName=values[1];
            TheatreLocation=values[2];
        }
    }
}