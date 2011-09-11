using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

//using System.Web.Commerce;
namespace System.Web.Commerce.Data {
  
  public class Context :DbContext{
    public DbSet<Product> Products { get; set; }
    public DbSet<Offer> Offers { get; set; }
    public DbSet<ProductOffer> ProductOffers { get; set; }
  }
}
