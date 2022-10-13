using System;
namespace OnlineThearterTicketBookingApplication
{
    public delegate void EventManager();    
    public static class Operations
    {
        public static event EventManager eventlink=null;
        public static List<UserDetails> userList = new List<UserDetails>();
        public static List<BookingDetails> bookingList = new List<BookingDetails>();
        public static List<TheatreDetails> theatreList = new List<TheatreDetails>();
        public static List<MovieDetails> movieList = new List<MovieDetails>();
        public static List<ScreeningDetails> screeningList = new List<ScreeningDetails>();
        public static UserDetails currentUser = null;
        //static BookingDetails currentBooking = null;
        public static void Subscribe()
        {
            eventlink += new EventManager(Files.Create);
            eventlink += new EventManager(Files.ReadFile);
            eventlink += new EventManager(MainMenu);
            eventlink += new EventManager(Files.WriteFile);
        }
        public static void StartEvent()
        {
            Subscribe();
            eventlink();
        }

        public static void MainMenu()
        {
            //create a MainMenu
            string choice = "yes";
            do
            {
                System.Console.WriteLine("You Enter into the MainMenu");
                System.Console.WriteLine("Select the options \n1. User Registration \n2. User Login \n3.Exit");
                int option = int.Parse(Console.ReadLine());
                
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Enter the User Registration");
                        UserRegistration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Enter the User Login");
                        UserLogin();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Exit MainMenu");
                        choice="no";
                        break;
                    }
                }
            }while(choice=="yes");
        }
    
        public static void UserRegistration()
        {
            // create user registration
            System.Console.WriteLine("Enter the User Details.");
            System.Console.WriteLine("Enter the User Nmae: ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter the User Age: ");
            int age = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the User Phone Number: ");
            long phoneNumber = long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the User Wallet Balance: ");
            double walletBalance = double.Parse(Console.ReadLine());
            
            UserDetails user1 = new UserDetails(name,age,phoneNumber,walletBalance);
            userList.Add(user1);

            System.Console.WriteLine("The user ID is: "+user1.UserID);
        }
    
        public static void UserLogin()
        {
            //Create Login
            System.Console.WriteLine("Enter the User Login ID: ");
            string tempLoginID=Console.ReadLine().ToUpper();
            int temp=0;
            //Check the login Id is valid or not
            foreach(UserDetails user in userList)
            {
                if(tempLoginID==user.UserID)
                {
                    temp=1;
                    currentUser=user;
                    System.Console.WriteLine("Login Successfull\n");
                    SubMenu();
                }
            }
            if(temp==0)
            {
                System.Console.WriteLine("Invalid UserID\n");
            }
        }
    
        public static void SubMenu()
        {
            //Create
            string choice1 = "yes";
            do
            {
                System.Console.WriteLine("Select options \na.Ticket Booking \nb.Ticket Cancellation \nc.Booking History \nd.Wallet Recharge \ne.Exit");
                char option = char.Parse(Console.ReadLine());
                switch(option)
                {
                    case 'a':
                    {
                        System.Console.WriteLine("Ticket Booking\n");
                        TickedBooking();
                        break;
                    }
                    case 'b':
                    {
                        System.Console.WriteLine("Ticket Cancellation\n");
                        CancelTicket();
                        break;
                    }
                    case 'c':
                    {
                        System.Console.WriteLine("Booking History\n");
                        BookingHistory();
                        break;
                    }
                    case 'd':
                    {
                        System.Console.WriteLine("Wallet Reacharge\n");
                        WalletRecharge();
                        break;
                    }
                    case 'e':
                    {
                        System.Console.WriteLine("Exit SunMenu");
                        choice1="no";
                        break;
                    }
                }
            }while(choice1=="yes");
        }
    
        public static void TickedBooking()
        {
            double totalAmount=0;
            //Show the list of Theatre’s details.
            foreach(TheatreDetails theatre in theatreList)
            {
                System.Console.WriteLine("\nTheatre ID      :"+theatre.TheatreID);
                System.Console.WriteLine("Theatre Name    :"+theatre.TheatreName);
                System.Console.WriteLine("Theatre Location:"+theatre.TheatreLocation);
            }
            //Ask the user to select a Theatre using Theatre ID
            System.Console.WriteLine("\nEnter the Theatre Id which one You want: ");
            string tempTheatreId = Console.ReadLine().ToUpper();
            foreach (ScreeningDetails screening in screeningList)
            {
                if(tempTheatreId==screening.TheatreID)
                {
                    //Show the user, the list of movies screened on that theatre.
                    foreach(MovieDetails movie in movieList)
                    {
                        if(screening.MovieID==movie.MovieID)
                        {
                            System.Console.WriteLine("\nMovie Id   :"+movie.MovieID);
                            System.Console.WriteLine("Movie Name :"+movie.MovieName);
                            System.Console.WriteLine("Language   :"+movie.Language);
                        }
                    }                    
                }
            }
            //Ask the user to select a movie 
            System.Console.WriteLine("\nSelect a movie from list of screened movies using MovieID");
            string tmepMovieId = Console.ReadLine().ToUpper();
            //Ask for the count of seats user wish to Book
            System.Console.WriteLine("\nSelect the count of seats you wish to Book");
            int tempSeatCount = int.Parse(Console.ReadLine());
            foreach (ScreeningDetails screening in screeningList)
            {
                if(tmepMovieId==screening.MovieID  && tempTheatreId==screening.TheatreID)
                {
                    //Check the Seat Count Availability
                    if(tempSeatCount<=screening.NoOfSeatsAvailable && tempSeatCount>0)
                    {
                        //Calculate the total price
                        double amount=(double) ((tempSeatCount*screening.TicketPrice));
                        totalAmount=(double) (totalAmount+((totalAmount)*0.18));
                        System.Console.WriteLine(totalAmount);
                        foreach(BookingDetails book in bookingList)
                        {
                        if(currentUser.WalletBalance>=totalAmount)
                        {
                            //Deduct the total amount from the wallet balance of the current logged in user.
                            //Deduct the count from the seat availability of the movie.
                            //Change the Booking Status to Booked
                            currentUser.WalletBalance -= totalAmount;
                            screening.NoOfSeatsAvailable -= tempSeatCount;
                            book.BookingStatus=BookingStatus.Booked;
                            BookingDetails booking = new BookingDetails(currentUser.UserID,screening.MovieID,screening.TheatreID,tempSeatCount,totalAmount,BookingStatus.Booked);
                            bookingList.Add(booking);
                            System.Console.WriteLine("Order Conformed");
                            System.Console.WriteLine("Booking Successfull");
                            break;
                        }
                        else
                        {
                            //Show Insufficient BAlance
                            System.Console.WriteLine("Insufficient Wallet Balance. \nPlease recharge your wallet");
                        }
                        }
                    }
                    else
                    {
                        //Show Number of Seat is not avilable
                        System.Console.WriteLine("The required count is not available");
                        System.Console.WriteLine("Current Count is: "+screening.NoOfSeatsAvailable);
                    }
                }
            }
            
        }
    
        public static void CancelTicket()
        {
            //Show the booking history
            BookingHistory();
            //Ask the user to enter the user id
            System.Console.WriteLine("\nEnter the canceled book Id:");
            string tempBookingId=Console.ReadLine().ToUpper();
            //Check the user id 
            foreach(BookingDetails booking in bookingList)
            {
                if(currentUser.UserID==booking.UserId)
                {
                    //Deduct the total amount from the wallet balance of the current logged in user.
                    //Deduct the count from the seat availability of the movie.
                    //Change the Booking Status to Booked
                    foreach(ScreeningDetails screening in screeningList)
                    {
                        if(tempBookingId==booking.BookingID)
                        {
                            screening.NoOfSeatsAvailable += booking.SeatCount;
                            currentUser.WalletBalance += (booking.TotalAmount-20);
                            booking.BookingStatus=BookingStatus.Cancelled;
                            System.Console.WriteLine("Cancelled Successfully");
                            break;
                        }
                    }
                }

            }
        }
    
        public static void BookingHistory()
        {
            //Show the booking history of current logged in user
            foreach (BookingDetails booking in bookingList)
            {
                if(currentUser.UserID==booking.UserId)
                {
                    System.Console.WriteLine("\nBooking ID    : "+booking.BookingID);
                    System.Console.WriteLine("User ID       : "+booking.UserId);
                    System.Console.WriteLine("Movie ID      : "+booking.MovieID);
                    System.Console.WriteLine("Theatre ID    : "+booking.TheatreID);
                    System.Console.WriteLine("Seat Count    : "+booking.SeatCount);
                    System.Console.WriteLine("Total Amount  : "+booking.TotalAmount);
                    System.Console.WriteLine("Booking Status: "+booking.BookingStatus);
                }
            }
        }

        public static void WalletRecharge()
        {
            //Wallet Reacharge
            currentUser.WalletRecharge();
        }
    }
}