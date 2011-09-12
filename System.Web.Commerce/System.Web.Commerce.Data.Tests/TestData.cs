using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Commerce;
namespace System.Web.Commerce.Data.Tests {
  public class TestData {
    public static Category CreateNewCategory(string categoryName) {
      var result = new Category {
        Id = Guid.NewGuid(),
        CategoryDescription = categoryName,
        IsActive = true
      };
      return result;
    }
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
    public static XslTransformation CreateNewXslTransformation() {
      var content = System.Xml.Linq.XDocument.Load( AppDomain.CurrentDomain.BaseDirectory + "\\cim.xslt" );
      var result = new XslTransformation {
        Id = Guid.NewGuid(),
        TransformationDescription = "CIM Gateway Commerce",
        TransformationName = "CIM Transformation",
        Xsl = content.ToString()
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
    public static List<Category> CreateNewCategories() {
      var result = new List<Category>();
      result.Add( CreateNewCategory( "Operating Systems" ) );
      result.Add( CreateNewCategory( "Antivirus Software" ) );
      result.Add( CreateNewCategory( "Computer Ascessories" ) );
      return result;
    }
    public static ProductCategory CreateNewProductCategory(Product product, Category category)
    {
      var result = new ProductCategory {
        Id = Guid.NewGuid(),
        Category = category,
        Product = product
      };
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
      var categories = CreateNewCategories();
      //Relationships

      List<ProductOffer> productOffers = new List<ProductOffer>();
      List<ProductCategory> productCategories = new List<ProductCategory>();
      for( int i = 0; i < products.Count; i++ ) {
        productOffers.Add( CreateNewProductOffer( products.ElementAt( i ), offers.ElementAt( i ) ) );
        productCategories.Add( CreateNewProductCategory(products.ElementAt(i),categories.ElementAt(i)) );
      }
      //save to db
      using( Context context = new Context() ) {
        context.XslTransformations.Add( CreateNewXslTransformation() );
        products.ForEach( n => context.Products.Add( n ) );
        offers.ForEach( n => context.Offers.Add( n ) );
        productOffers.ForEach( n => context.ProductOffers.Add( n ) );
        categories.ForEach( n => context.Categories.Add( n ) );
        productCategories.ForEach( n => context.ProductCategories.Add( n ) );
        context.SaveChanges();
      }
      
    }
  }
}
