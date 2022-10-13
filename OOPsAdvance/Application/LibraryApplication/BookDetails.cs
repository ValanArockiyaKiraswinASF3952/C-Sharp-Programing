using System;
namespace LibraryApplication
{
    public class BookDetails
    {
        private static int s_bookId=100;
        public string BookId{get;}

        public string BookName{get; set;}

        public string AuthorName{get; set;}

        public int NoOfBooks{get; set;}

        public BookDetails(string bookName,string authorName,int noOfBooks)
        {
            s_bookId++;
            BookId="BID"+s_bookId;
            BookName=bookName;
            AuthorName=authorName;
            NoOfBooks=noOfBooks;
        }
    }
}