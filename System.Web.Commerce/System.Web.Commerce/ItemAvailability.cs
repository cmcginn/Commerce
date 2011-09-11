using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Web.Commerce {
  public enum ItemAvailability {
    None,
    Discontinued,
    InStock,
    InStoreOnly,
    OnlineOnly,
    OutOfStock,
    PreOrder,
  }
}
