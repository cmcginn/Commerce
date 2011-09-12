using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Web.Commerce.Data {
  public interface IShoppingCartItem {
    ProductOffer ProductOffer {
      get;
      set;
    }

    IShoppingCart ShoppingCart {
      get;
      set;
    }

    DateTime Created {
      get;
      set;
    }
  }
}
