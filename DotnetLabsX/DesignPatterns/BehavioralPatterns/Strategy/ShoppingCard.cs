using Tazhgah.DotnetLabs.Strategy.Interfaces;

namespace Tazhgah.DesignPatterns.Strategy;

public class ShoppingCard
{

    protected IPaymentMethod? _paymentMethod;

    public void SetPaymentMethod(IPaymentMethod paymentMethod)
    {
        _paymentMethod = paymentMethod;
    }

    public void Checkout()
    {
        _paymentMethod.Pay();
    }

}
