namespace OnlineGroceryStoreApplication
{
    public interface IBalance
    {
        double WalletBalance { get; set; }
         

        void WalletReacharge();
    }
}