namespace OnlineThearterTicketBookingApplication
{
    public interface IWallet
    {
         public double WalletBalance  { get; set; }

         void WalletRecharge();
    }
}