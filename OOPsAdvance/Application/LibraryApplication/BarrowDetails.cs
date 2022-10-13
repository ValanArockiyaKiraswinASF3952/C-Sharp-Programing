using System;
using System.Collections.Generic;

namespace LibraryApplication
{
    public enum BookStatus{Default,Borrowed,Returned}
    public class BorrowDetails
    {
        private static int s_borrowId=300;
        public string BorrowId{get;}

        private static int s_userId=3000;
        public string UserId{get;}

        private static int s_bookId=100;
        public string BookId{get;}

        public DateTime BorrowDate{get; set;}

        public BookStatus Bookstatus{get; set;}

        public BorrowDetails(string userId,string bookId,DateTime borrowdate,BookStatus bookStatus)
        {
            s_borrowId++;
            BorrowId="LB"+s_borrowId;
            UserId=userId;
            BookId=bookId;
            BorrowDate=borrowdate;
            Bookstatus=bookStatus;
        }

    }
}