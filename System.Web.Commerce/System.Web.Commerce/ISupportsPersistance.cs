﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Web.Commerce {
  public interface ISupportsPersistance {
    Guid Id {
      get;
      set;
    }
  }
}
