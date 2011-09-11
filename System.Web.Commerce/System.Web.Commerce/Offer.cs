using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Web.Commerce {
  public class Offer : IOffer, ISupportsPersistance {
    public Guid Id { get; set; }
    public decimal Price { get; set; }
    public string Currency { get; set; }
    public DateTime PriceValidityStartDate { get; set; }
    public DateTime PriceValidityEndDate { get; set; }
    public ItemCondition Condition { get; set; }
    public ItemAvailability Availability { get; set; }
    
  }
}
