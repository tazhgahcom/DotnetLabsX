using System;
using System.Collections.Generic;
using System.Text;
using Tazhgah.DotnetLabs.Strategy.Interfaces;

namespace Tazhgah.DesignPatterns.Strategy.PaymentMethods
{
    public class DirectPayMethod : IPaymentMethod
    {
        public void Pay()
        {
            Console.WriteLine("DirectPay Method");
        }
    }
}
