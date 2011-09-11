using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Web.Commerce {
  public interface IPostalAddress {
    string Country {
      get;
      set;
    }

    string Locality {
      get;
      set;
    }

    string Region {
      get;
      set;
    }

    string PostOfficeBoxNumber {
      get;
      set;
    }

    string StreetAddress {
      get;
      set;
    }
  }
}
