using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Web.Commerce.Data {
  public class Order : IOrder {
    public ShoppingCart ShoppingCart { get; set; }
    public Guid Id { get; set; }
  }
}
