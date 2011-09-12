using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Web.Commerce {
  public interface IContact {
    int FirstName {
      get;
      set;
    }

    int MiddleName {
      get;
      set;
    }

    int LastName {
      get;
      set;
    }

    int Created {
      get;
      set;
    }

    int IsActive {
      get;
      set;
    }
  }
}
