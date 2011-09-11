using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Commerce;
namespace System.Web.Commerce.Data.Tests {
  public class TestData {

    public static Product CreateNewProduct(string productName,string manufacturer,string brand) {
      var result = new Product {
        Id = Guid.NewGuid(),
        Brand = brand,
        Manufacturer = manufacturer,
        Model = new System.Random().Next( 100000, 999999 ).ToString(),
        Name = productName
      };
      return result;
    }
    public static Offer CreateNewOffer( decimal price, ItemAvailability availability, ItemCondition itemCondition ) {
      var result = new Offer {
        Id = Guid.NewGuid(),
        Availability = availability,
        Condition = itemCondition,
        Currency = "USD",
        Price = price,
        PriceValidityStartDate = System.DateTime.Now,
        PriceValidityEndDate = System.DateTime.Now.AddYears( 100 )
      };
      return result;
    }
    public static List<Product> CreateNewProducts() {
      var result = new List<Product>();
      result.Add( CreateNewProduct( "Microsoft Windows Server 2008", "Microsoft", "Microsoft" ) );
      result.Add( CreateNewProduct( "Norton Antivirus 2008", "Norton", "Norton" ) );
      result.Add( CreateNewProduct( "Logitech Laser Mouse", "Logitech", "Logitech" ) );
      return result;
    }
    public static List<Offer> CreateNewOffers() {
      var result = new List<Offer>();
      result.Add( CreateNewOffer( 499.00m, ItemAvailability.InStock, ItemCondition.NewCondition ) );
      result.Add( CreateNewOffer( 99.99m, ItemAvailability.InStock, ItemCondition.NewCondition ) );
      result.Add( CreateNewOffer( 19.99m, ItemAvailability.InStock, ItemCondition.NewCondition ) );
      return result;
    }
    public static ProductOffer CreateNewProductOffer( Product product, Offer offer ) {
      var result = new ProductOffer {
        Id = Guid.NewGuid(),
        Offer = offer,
        Product = product
      };
      return result;
    }
    public static void CreateTestData() {
      var products = CreateNewProducts();
      var offers = CreateNewOffers();
      
      //Product offers

      List<ProductOffer> productOffers = new List<ProductOffer>();
      for( int i = 0; i < products.Count; i++ ) {
        productOffers.Add( CreateNewProductOffer( products.ElementAt( i ), offers.ElementAt( i ) ) );
      }
      
      //save to db
      using( Context context = new Context() ) {
        products.ForEach( n => context.Products.Add( n ) );
        offers.ForEach( n => context.Offers.Add( n ) );
        productOffers.ForEach( n => context.ProductOffers.Add( n ) );
        context.SaveChanges();
      }
      
    }
  }
}
