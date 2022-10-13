using System;
namespace OnlineThearterTicketBookingApplication
{
    public class UserDetails:PersonalDetails,IWallet
    {
        private static int s_userID = 1000;
        /// <summary>
        /// Class <see cref="UserDetails"/> property UserId used to uniquely UserId of user
        /// </summary>
        public string UserID { get; set; }
        /// <summary>
        /// Class <see cref="PersonalDetails"/> property WalletBalance used to provide WalletBalance of user
        /// </summary>
        public double WalletBalance { get; set; }
        /// <summary>
        ///  Constructor of <see cref="UserDetail"/> class sused to initilize value to its property
        /// </summary>
        /// <param name="name">Parameter name used to initialize value to a user Name to Name property</param>
        /// <param name="age">Parameter age used to initialize value to a user Age to Age property</param>
        /// <param name="phoneNumber">Parameter phoneNumber used to initialize value to a user phoneNumber to phoneNumber property</param>
        /// <param name="walletBalance">Parameter walletBalance used to initialize value to a user walletBalance to walletBalance property</param>
        /// <returns></returns>
        public UserDetails(string name,int age,long phoneNumber,double walletBalance):base( name, age, phoneNumber)
        {
            s_userID++;
            UserID="UID"+s_userID;
            WalletBalance=walletBalance;
        }

        public UserDetails(string data)
        {
            string [] values = data.Split(',');
            s_userID = int.Parse(values[0].Remove(0,3));
            UserID=values[0];
            Name=values[1];
            Age=int.Parse(values[2]);
            PhoneNumber=long.Parse(values[3]);
            WalletBalance=double.Parse(values[4]);
        }

        public void WalletRecharge()
        {
            System.Console.WriteLine("Enter the amount you want to Reacharge: ");
            double amount = double.Parse(Console.ReadLine());
            WalletBalance += amount;
        }
    }
}