using Tazhgah.DesignPatterns.Strategy;
using Tazhgah.DesignPatterns.Strategy.PaymentMethods;

ShoppingCard card = new();
card.SetPaymentMethod(new PayPalMethod());
card.Checkout();

card.SetPaymentMethod(new BankingCardMethod());
card.Checkout();

card.SetPaymentMethod(new DirectPayMethod());
card.Checkout();