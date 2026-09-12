using Tazhgah.DotnetLabs.Strategy.Interfaces;

namespace Tazhgah.DesignPatterns.Strategy.PaymentMethods
{
    public class BankingCardMethod : IPaymentMethod
    {
        public void Pay()
        {
            Console.WriteLine("Banking Card Method");
        }
    }
}
