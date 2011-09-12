using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Web.Commerce.Data {
  public class ShoppingCartItem : IShoppingCartItem, ISupportsPersistance {
    public ProductOffer ProductOffer { get; set; }

    public IShoppingCart ShoppingCart { get; set; }

    public DateTime Created { get; set; }

    public Guid Id { get; set; }
  }
  }

