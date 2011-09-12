using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Web.Commerce.Data {
  public class PhoneNumber : ISupportsPersistance {
    public Guid Id { get; set; }

    public int CountryCode { get; set; }

    public int AreaCode { get; set; }

    public int Prefix { get; set; }

    public int Suffix { get; set; }

    public int Extension { get; set; }
  }
}
