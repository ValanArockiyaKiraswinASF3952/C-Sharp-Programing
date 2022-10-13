using System.IO;
namespace OnlineThearterTicketBookingApplication
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("MovieTicketBooking"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("MovieTicketBooking");
            }
            if(!File.Exists("MovieTicketBooking/UserDetails.csv"))
            {
                System.Console.WriteLine("Create File");
                File.Create("MovieTicketBooking/UserDetails.csv");
            }
            if(!File.Exists("MovieTicketBooking/BookingDetails.csv"))
            {
                System.Console.WriteLine("Create File");
                File.Create("MovieTicketBooking/BookingDetails.csv");
            }
            if(!File.Exists("MovieTicketBooking/TheatreDetails.csv"))
            {
                System.Console.WriteLine("Create File");
                File.Create("MovieTicketBooking/TheatreDetails.csv");
            }
            if(!File.Exists("MovieTicketBooking/MovieDetails.csv"))
            {
                System.Console.WriteLine("Create File");
                File.Create("MovieTicketBooking/MovieDetails.csv");
            }
            if(!File.Exists("MovieTicketBooking/ScreeningDetails.csv"))
            {
                System.Console.WriteLine("Create File");
                File.Create("MovieTicketBooking/ScreeningDetails.csv");
            }
        }
    
        public static void ReadFile()
        {
            string [] users = File.ReadAllLines("MovieTicketBooking/UserDetails.csv");
            foreach(string data in users)
            {
                UserDetails user = new UserDetails(data);
                Operations.userList.Add(user);
            }
            string [] booking = File.ReadAllLines("MovieTicketBooking/BookingDetails.csv");
            foreach(string data in booking)
            {
                BookingDetails book = new BookingDetails(data);
                Operations.bookingList.Add(book);
            }
            string [] theatre = File.ReadAllLines("MovieTicketBooking/TheatreDetails.csv");
            foreach(string data in theatre)
            {
                TheatreDetails theatree = new TheatreDetails(data);
                Operations.theatreList.Add(theatree);
            }
            string [] movie = File.ReadAllLines("MovieTicketBooking/MovieDetails.csv");
            foreach(string data in movie)
            {
                MovieDetails movies = new MovieDetails(data);
                Operations.movieList.Add(movies);
            }
            string [] screening = File.ReadAllLines("MovieTicketBooking/ScreeningDetails.csv");
            foreach(string data in screening)
            {
                ScreeningDetails screen = new ScreeningDetails(data);
                Operations.screeningList.Add(screen);
            }
        }
        public static void WriteFile()
        {
            string [] userDetails = new string[Operations.userList.Count];
            for(int i=0;i<Operations.userList.Count;i++)
            {
                userDetails[i]=Operations.userList[i].UserID+","+Operations.userList[i].Name+","+Operations.userList[i].Age+","+Operations.userList[i].PhoneNumber+","+Operations.userList[i].WalletBalance;
            }
            File.WriteAllLines("MovieTicketBooking/UserDetails.csv",userDetails);

            string [] bookingDetails = new string[Operations.bookingList.Count];
            for(int i=0;i<Operations.bookingList.Count;i++)
            {
                bookingDetails[i]=Operations.bookingList[i].BookingID+","+Operations.bookingList[i].UserId+","+Operations.bookingList[i].MovieID+","+Operations.bookingList[i].TheatreID+","+Operations.bookingList[i].SeatCount+","+Operations.bookingList[i].TotalAmount+","+Operations.bookingList[i].BookingStatus;
            }
            File.WriteAllLines("MovieTicketBooking/BookingDetails.csv",bookingDetails);

            string [] theatreDetails = new string[Operations.theatreList.Count];
            for(int i=0;i<Operations.userList.Count;i++)
            {
                theatreDetails[i]=Operations.theatreList[i].TheatreID+","+Operations.theatreList[i].TheatreName+","+Operations.theatreList[i].TheatreLocation;
            }
            File.WriteAllLines("MovieTicketBooking/TheatreDetails.csv",theatreDetails);

            string [] movieDetails = new string[Operations.movieList.Count];
            for(int i=0;i<Operations.movieList.Count;i++)
            {
                movieDetails[i]=Operations.movieList[i].MovieID+","+Operations.movieList[i].MovieName+","+Operations.movieList[i].Language;
            }
            File.WriteAllLines("MovieTicketBooking/MovieDetails.csv",movieDetails);
            
            string [] screeningDetails = new string[Operations.screeningList.Count];
            for(int i=0;i<Operations.screeningList.Count;i++)
            {
                screeningDetails[i]=Operations.screeningList[i].MovieID+","+Operations.screeningList[i].TheatreID+","+Operations.screeningList[i].NoOfSeatsAvailable+","+Operations.screeningList[i].TicketPrice;
            }
            File.WriteAllLines("MovieTicketBooking/ScreeningDetails.csv",screeningDetails);
        }
    }
}