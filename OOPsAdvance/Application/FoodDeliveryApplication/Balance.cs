namespace FoodDeliveryApplication
{
    public interface IBalance
    {
         public double WalletBalance { get; set; }
         void WalletReacharge();
    }
}