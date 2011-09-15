using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Commerce;
using System.Web.Commerce.Data;
using System.Web.Commerce.Data.Tests;

namespace System.Web.Commerce.Tests {
  /// <summary>
  /// Summary description for UnitTest1
  /// </summary>
  [TestClass]
  public class CommerceProviderTests {
    public CommerceProviderTests() {
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
    public static void MyClassInitialize( TestContext testContext ) 
    {
      _Context = new Context();
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

    static Context _Context;

    public ShoppingCart CreateTestCart() {
      var target = new CommerceProvider();
      var contact = TestData.CreateNewContact( "Tony", "Danza" );      
      var cart = target.CreateCart( contact );
      var result = _Context.ShoppingCarts.Single( n => n.Id == cart.Id );
      return result;
    }
    public ShoppingCart CreateTestCartWithItem() {
      var target = new CommerceProvider();
      var productOffer = _Context.ProductOffers.First();
      var shoppingCart = CreateTestCart();
      target.AddItemToCart( productOffer, shoppingCart);
      var result = _Context.ShoppingCarts.Single( n => n.Id == shoppingCart.Id );
      return result;
    }
    [TestMethod]
    public void CreateCartTest() {
      //Arrange     
      //Act
      var actual = CreateTestCart();
      //Assert
      //Self Asserting;
    }

    [TestMethod]
    public void AddItemToCartTest() {
      //Arrange
      //Act   
      //Self Asserting      
      CreateTestCartWithItem();
    }
    [TestMethod]
    public void CreateOrderTest() {
      //Arrange
      var target = new CommerceProvider();
      var shoppingCart = CreateTestCartWithItem();
      //Act
      var actual = target.CreateOrder( shoppingCart );
      //SelfAsserting
      _Context.Orders.Single( n => n.Id == actual.Id );
    }
  }
}
