using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Web.Commerce.Data {
  public class ShoppingCart : IShoppingCart {
    public Guid Id { get; set; }
    public Contact Contact { get; set; }
  }
}
