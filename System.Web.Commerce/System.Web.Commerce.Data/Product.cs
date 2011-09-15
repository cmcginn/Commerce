using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace System.Web.Commerce.Data {
  public class Product : ISupportsPersistance, IProduct {
    [Key]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Brand { get; set; }
    public string Manufacturer { get; set; }
    public string Model { get; set; }
  }
}
