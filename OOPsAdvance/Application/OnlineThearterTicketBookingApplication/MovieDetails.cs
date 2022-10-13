namespace OnlineThearterTicketBookingApplication
{
    public class MovieDetails
    {
        private static int s_movieID=500;
        /// <summary>
        /// Class <see cref="MovieDetails"/> property MovieID used to uniquely identify MovieID of user
        /// </summary>
        public string MovieID { get; set; }
        /// <summary>
        /// Class <see cref="MovieDetails"/> property MovieName used to provide MovieName of user
        /// </summary>
        public string MovieName { get; set; }
        /// <summary>
        /// Class <see cref="MovieDetails"/> property Language used to provide Language of user
        /// </summary>
        public string Language { get; set; }
        /// <summary>
        /// Constructor of <see cref="MovieDetails"/> class sused to initilize value to its property
        /// </summary>
        /// <param name="movieName">Parameter movieName used to initialize value to a user movieName to movieName property</param>
        /// <param name="language">Parameter language used to initialize value to a user language to language property</param>
        public MovieDetails(string movieName,string language)
        {
            s_movieID++;
            MovieID="MID"+s_movieID;
            MovieName=movieName;
            Language=language;
        }
        public MovieDetails(string data)
        {
            string [] values = data.Split(',');
            s_movieID = int.Parse(values[0].Remove(0,3));
            MovieID=values[0];
            MovieName=values[1];
            Language=values[2];
        }

    }
}