using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Web.Commerce {
  public class Product : ISupportsPersistance, IProduct {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Brand { get; set; }
    public string Manufacturer { get; set; }
    public string Model { get; set; }
  }
}
