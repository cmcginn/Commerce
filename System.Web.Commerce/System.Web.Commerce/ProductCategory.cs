using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Web.Commerce {
  public class ProductCategory : ISupportsPersistance {
    public Guid Id { get; set; }
    public Product Product { get; set; }
    public Category Category { get; set; }
  }
}
