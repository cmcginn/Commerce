using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Web.Commerce.Data {
  public class Contact : ISupportsPersistance, IContact {
    public Guid Id { get; set; }

    public int FirstName { get; set; }

    public int MiddleName { get; set; }

    public int LastName { get; set; }

    public int Created { get; set; }

    public int IsActive { get; set; }
  }
}
