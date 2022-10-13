namespace Ex4
{
    public class BookInfo:DepartmentDetails
    {
        private static int s_bookId=1000;
        public string BookID { get; set; }
        public string BookName { get; set; }
        public string AuthourName { get; set; }
        public int Price { get; set; }

        public BookInfo(string departmentName,string degree,string bookName, string authourName, int price):base( departmentName, degree)
        {
            BookID="BID"+s_bookId++;
            BookName=bookName;
            AuthourName=authourName;
            Price=price;
        }
        public void ShowBookInfo()
        {
            System.Console.WriteLine("Enter the BookId:"+BookID);
            System.Console.WriteLine("Enter the Book Name: "+BookName);
            System.Console.WriteLine("Enter the Authour name; "+AuthourName);
            System.Console.WriteLine("Enter the PRICE"+Price);
            Show();
        }

    }
}