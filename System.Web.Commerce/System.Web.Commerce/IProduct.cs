using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Web.Commerce {
  public interface IProduct {
    string Name {
      get;
      set;
    }

    string Brand {
      get;
      set;
    }

    string Manufacturer {
      get;
      set;
    }

    string Model {
      get;
      set;
    }
  }
}
