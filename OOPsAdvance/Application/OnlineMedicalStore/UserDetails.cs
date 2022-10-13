namespace OnlineMediaStore
{
    public class UserDetails
    {
        private static int s_userID=1000;
        public string UserID  { get; set; }
        public string UserName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public long PhoneNumber { get; set; }
        public int Balance { get; set; }

        public UserDetails(string userName, int age, string city, long phoneNumber, int balance)
        {
            UserID="UID"+s_userID++;
            UserName=userName;
            Age=age;
            City=city;
            PhoneNumber=phoneNumber;
            Balance=balance;
        }

        public UserDetails(string data)
       {
        string [] values = data.Split(',');
        s_userID=int.Parse(values[0].Remove(0,3));
        UserID=values[0];
        UserName=values[1];
        Age=int.Parse(values[2]);
        City=values[3];
        PhoneNumber=long.Parse(values[4]);
        Balance=int.Parse(values[5]);
       }
    }
}