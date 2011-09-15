using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Entity;
using System.Web;
using CodeFirstStoredProcs;
using System.Data.Common;
using System.ComponentModel.DataAnnotations;
//using System.Web.Commerce;
namespace System.Web.Commerce.Data {
 
  public class Context : DbContext {
    public Context() {
      // Prevent database initialization at design-time
      // when RIA Services is generating code
      //if( HttpContext.Current == null ) {
      //  Database.SetInitializer<Context>( null );
      //}
      System.Data.Entity.Database.SetInitializer( new System.Data.Entity.DropCreateDatabaseAlways<Context>() );
      
    }  
    public DbSet<Product> Products { get; set; }
    public DbSet<Offer> Offers { get; set; }
    public DbSet<ProductOffer> ProductOffers { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }
    public DbSet<XslTransformation> XslTransformations { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<PhoneNumber> PhoneNumbers { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<ContactPoint> ContactPoints { get; set; }
    public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
    public DbSet<ShoppingCart> ShoppingCarts { get; set; }
    public DbSet<Order> Orders { get; set; }
    
  }
 
}
