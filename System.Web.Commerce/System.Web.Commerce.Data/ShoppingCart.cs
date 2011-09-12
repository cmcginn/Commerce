using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Web.Commerce.Data {
  public class ShoppingCart : ISupportsPersistance, IShoppingCart {
    public Contact Contact { get; set; }
    public Guid Id { get; set; }
  }
}
