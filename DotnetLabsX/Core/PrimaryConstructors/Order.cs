using System;
using System.Collections.Generic;
using System.Text;

namespace Tazhgah.Core.PrimaryConstructors
{
    public class Order(int OrderId, string CustomerName, string CustomerFamily)
    {
        public int OrderId { get; } = OrderId;
        public string CustomerName { get; } = CustomerName;
        public string CustomerFamily { get; } = CustomerFamily;
    }
}
