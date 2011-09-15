using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Web.Commerce.Data {
  public interface IContact {
    string FirstName {
      get;
      set;
    }

    string MiddleName {
      get;
      set;
    }

    string LastName {
      get;
      set;
    }

    DateTime Created {
      get;
      set;
    }

    bool IsActive {
      get;
      set;
    }
  }
}
