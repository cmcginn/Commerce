using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Web.Commerce {
  public interface IOffer {
    decimal Price {
      get;
      set;
    }

    string Currency {
      get;
      set;
    }

    DateTime PriceValidityStartDate {
      get;
      set;
    }

    DateTime PriceValidityEndDate {
      get;
      set;
    }

    ItemCondition Condition {
      get;
      set;
    }

    ItemAvailability Availability {
      get;
      set;
    }
  }
}
