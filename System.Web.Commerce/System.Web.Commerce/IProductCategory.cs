using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Web.Commerce {
  public interface ICategory {
    string CategoryName {
      get;
      set;
    }

    string CategoryDescription {
      get;
      set;
    }

    bool IsActive {
      get;
      set;
    }
  }
}
