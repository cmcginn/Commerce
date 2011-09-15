using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Web.Commerce.Data {
  public class Contact : ISupportsPersistance, IContact {
    public Guid Id { get; set; }

    public string FirstName { get; set; }

    public string MiddleName { get; set; }

    public string LastName { get; set; }

    public DateTime Created { get; set; }

    public bool IsActive { get; set; }
  }
}
