using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Web.Commerce.Data {
  public class Category : ISupportsPersistance, ICategory {
    public Guid Id { get; set; }
    public string CategoryName { get; set; }
    public string CategoryDescription { get; set; }
    public bool IsActive { get; set; }
  }
}
