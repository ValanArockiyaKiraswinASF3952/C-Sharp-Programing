using System;
using System.Collections.Generic;
namespace LibraryApplication;

    public class Opaeration
    {
        static List<UserDetails> UserList=new List<UserDetails>();
        static List<BookDetails> BookList=new List<BookDetails>();

        static List<BorrowDetails> BorrowList=new List<BorrowDetails>();
        static UserDetails currentUser=null;

        static BookDetails currentBook=null;
        static BorrowDetails currentBorrow=null;
        public static void MainMenu()
        {
            string choice="";
            do
            {
                System.Console.WriteLine("MainMeu");
                System.Console.WriteLine("Select the Option 1.Registration 2.LogIn 3.Exit");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Registration");
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("LogIn");
                        LogIn();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Exit");
                        choice="no";
                        break;
                    }
                }
            }while(choice!="yes");
        }
        public static void SubMenu()
        {
            string choice="";
            do
            {
            System.Console.WriteLine("SubMenu");
            System.Console.WriteLine("Select the Option 1.Borrow Book   2.Return Book    3.Show Borrowed History  4.Exit");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Borrow Book");
                    BorrowBook();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Return Book");
                    ReturnBook();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("View Borrrowed History");
                    ViewBorrowedHistory();
                    break;
                }
                case 4:
                {
                    System.Console.WriteLine("LogOut");
                    choice="no";
                    break;
                }
            }
            }while(choice!="yes");

        }
        public static void Registration()
        {
            System.Console.WriteLine("Enter your name : ");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter your Age : ");
            int age=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Gender");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter Your Department : ");
            string department=Console.ReadLine().ToUpper();
            System.Console.WriteLine("Enter your Phone number : ");
            long phone=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Your Mail Id : ");
            string mailId=Console.ReadLine();

            UserDetails user=new UserDetails(name,age,gender,department,phone,mailId);
            UserList.Add(user);
            currentUser=user;
            System.Console.WriteLine("Registration Successfully");
            System.Console.WriteLine("Your register id is " +user.UserId);
        }
        public static void LogIn()
        {
            System.Console.WriteLine("Enter your user id : ");
            string userId=Console.ReadLine().ToUpper();
            foreach (UserDetails user in UserList)
            {
                if(userId==user.UserId)
                {
                    System.Console.WriteLine("Login succefully");
                    currentUser=user;
                    SubMenu();
                }
            }
        }
        public static void BorrowBook()
        {
            System.Console.WriteLine("BookId    BookName    AuthorName      No.ofBooks");
            foreach(BookDetails book in BookList)
            {
                System.Console.WriteLine($"{book.BookId}\t\t{book.BookName}\t\t{book.AuthorName}\t\t{book.NoOfBooks}");
            }
            System.Console.WriteLine("Enter BookId to Borrow : ");
            string bookId=Console.ReadLine();
            foreach (BookDetails book in BookList)
            {
                if(bookId==book.BookId )
                    if(book.NoOfBooks<=0)
                        {
                            System.Console.WriteLine("Books are not available for the selected count ");
                            foreach (BorrowDetails borrow in BorrowList)
                            {
                                if(bookId==borrow.BookId)
                                {
                                    DateTime date=borrow.BorrowDate.AddDays(15);
                                    System.Console.WriteLine("The book will be available on "+date.ToShortDateString());
                                }
                            }
                        }
                        else
                        {
                            int value=checkCountTime();
                            if(value <= 3)
                            {
                                System.Console.WriteLine("You can take the book");
                                book.NoOfBooks=book.NoOfBooks-1;

                                BorrowDetails borrow = new BorrowDetails(currentUser.UserId,currentBook.BookId,DateTime.Now,BookStatus.Borrowed);
                                BorrowList.Add(borrow);
                            }
                            else
                            {
                                System.Console.WriteLine("You have more than enough book..If you want to take it then return the books");
                            }
                        }
                    
                        
                   
            }
        }

    public static int checkCountTime()
    {
        throw new NotImplementedException();
    }

    public static void ReturnBook()
        {
            int checkValue=0;
            foreach (BorrowDetails borrow1 in BorrowList)
            {
                if(currentUser.UserId==borrow1.UserId)
                {
                    System.Console.WriteLine($"{borrow1.BorrowId}\t\t{borrow1.UserId}\t\t{borrow1.BookId}\t\t{borrow1.BorrowDate}\t\t{borrow1.Bookstatus}");
                }
            }
            System.Console.WriteLine("Enter Book Id which book is you want to Return ");
            string bookId=Console.ReadLine();
            foreach (BorrowDetails borrow in BorrowList)
            {
                if(currentUser.UserId==borrow.UserId && borrow.Bookstatus==BookStatus.Borrowed)
                {
                    DateTime returnDate=borrow.BorrowDate.AddDays(15);
                    int result=DateTime.Compare(returnDate,DateTime.Now);
                    if(result>0)
                        System.Console.WriteLine($"Your BookId{borrow.BookId} and Return Date is {returnDate.ToShortDateString()}");
                    else
                        checkValue=CheckCountDates();
                }
                
            }
        }
        public static int CheckCountDates()
        {
            
            int increase=1;
            while(true)
            {
                string check=returnDate.Add(increase).ToShortDateString();
                string check1=DateTime.Now.ToLongDateString().ToString();
                if(check==check1)
                {
                    return increase;
                }increase++;
            }
        }
        public static void ViewBorrowedHistory()
        {
            System.Console.WriteLine(" BorrowId     UserId      BookId      BorrowDate      BorrowStatus");
            foreach (BorrowDetails borrow in BorrowList)
            {
                if(currentUser.UserId==borrow.UserId)
                {             
                    System.Console.WriteLine($"{borrow.BorrowId}\t\t{borrow.UserId}\t\t{borrow.BookId}\t\t{borrow.BorrowDate}\t\t{borrow.Bookstatus}");
                }
            }
        }
       
        
        public static void UserData()
        {
            UserDetails user1=new UserDetails("RaviChandran",20,Gender.Male,"EEE",9938388333,"ravi@gmail.com");
            UserDetails user2=new UserDetails("PriyaDharshini",21,Gender.Female,"CSE",9944444455,"priya@gmail.com");
            UserList.Add(user1);
            UserList.Add(user2);
        }
        public static void BookData()
        {
            BookDetails book1=new BookDetails("C#","Author1",3);
            BookDetails book2=new BookDetails("HTML","Author2",5);
            BookDetails book3=new BookDetails("CSS","Author1",3);
            BookDetails book4=new BookDetails("JS","Author1",3);
            BookDetails book5=new BookDetails("TS","Author2",2);
            BookList.Add(book1);
            BookList.Add(book2);
            BookList.Add(book3);
            BookList.Add(book4);
            BookList.Add(book5);

        }
        public static void BorrowData()
        {
            BorrowDetails borrow1=new BorrowDetails("SF3001","BID101",DateTime.Now,BookStatus.Borrowed);
            BorrowDetails borrow2=new BorrowDetails("SF3001","BID103",DateTime.Now,BookStatus.Returned);
            BorrowDetails borrow3=new BorrowDetails("SF3001","BID104",DateTime.Now,BookStatus.Borrowed);
            BorrowDetails borrow4=new BorrowDetails("SF3002","BID102",DateTime.Now,BookStatus.Returned);
            BorrowDetails borrow5=new BorrowDetails("SF3002","BID105",DateTime.Now,BookStatus.Borrowed);
            BorrowList.Add(borrow1);
            BorrowList.Add(borrow2);
            BorrowList.Add(borrow3);
            BorrowList.Add(borrow4);
            BorrowList.Add(borrow5);
        }
    }
