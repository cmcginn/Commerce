using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Web.Commerce.Data {
  public class ProductOffer : ISupportsPersistance {
    public Product Product { get; set; }
    public Offer Offer { get; set; }
    public Guid Id { get; set; }
  }
}
