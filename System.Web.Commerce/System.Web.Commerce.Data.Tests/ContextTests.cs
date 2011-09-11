using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Commerce;
using System.Web.Commerce.Data;
namespace System.Web.Commerce.Data.Tests {
  /// <summary>
  /// Summary description for UnitTest1
  /// </summary>
  [TestClass]
  public class ContextTests {
    public ContextTests() {
      //
      // TODO: Add constructor logic here
      //
    }

    private TestContext testContextInstance;

    /// <summary>
    ///Gets or sets the test context which provides
    ///information about and functionality for the current test run.
    ///</summary>
    public TestContext TestContext {
      get {
        return testContextInstance;
      }
      set {
        testContextInstance = value;
      }
    }

    #region Additional test attributes
    //
    // You can use the following additional attributes as you write your tests:
    //
    // Use ClassInitialize to run code before running the first test in the class
    [ClassInitialize()]
    public static void MyClassInitialize( TestContext testContext ) {
      System.Data.Entity.Database.SetInitializer( new System.Data.Entity.DropCreateDatabaseAlways<Context>() );
      TestData.CreateTestData();
    }
    //
    // Use ClassCleanup to run code after all tests in a class have run
    // [ClassCleanup()]
    // public static void MyClassCleanup() { }
    //
    // Use TestInitialize to run code before running each test 
    // [TestInitialize()]
    // public void MyTestInitialize() { }
    //
    // Use TestCleanup to run code after each test has run
    // [TestCleanup()]
    // public void MyTestCleanup() { }
    //
    #endregion

    [TestMethod]
    public void Product_InsertTest() {
      //Arrange
      var product = new Product();
      product.Id = Guid.NewGuid();
      product.Name = "Crabs";
      using( Context context = new Context() ) {
        context.Products.Add( product );
        context.SaveChanges();
      }
      //Act
      //Assert
    }
  }
}
