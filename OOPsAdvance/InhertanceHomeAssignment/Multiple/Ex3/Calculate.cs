using System;
namespace Ex3
{
    public interface ICalculate
    {
           
        public void Deposite()
        {
            System.Console.WriteLine("Enter the amount you want to deposite:");
        }
        public void Withdraw()
        {
            System.Console.WriteLine("Enter the amount you want to Withdraw:");
                      
        }
         public void Balance()
        {
            //int Withdraw = int.Parse(Console.ReadLine());
           int balance=0; 
            System.Console.WriteLine("The amount Balance is:"+balance);
        }

    }
}