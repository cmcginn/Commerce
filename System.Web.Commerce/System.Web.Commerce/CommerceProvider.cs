using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Commerce.Data;
using System.Data;
using System.Data.Entity;
using CodeFirstStoredProcs;
using System.ComponentModel.DataAnnotations;
namespace System.Web.Commerce {
  public class CommerceProvider {

    public IShoppingCart CreateCart( IContact contact ) {
      var result = new ShoppingCart() {
        Id = Guid.NewGuid(),
        Contact = contact as Contact
      };
      using( var context = new Context() ) {
        context.ShoppingCarts.Add( result );
        context.SaveChanges();
      }
      return result;
    }
    
    public IShoppingCartItem AddItemToCart(ProductOffer productOffer, IShoppingCart cart ) {
      var result = new ShoppingCartItem {
        Id = Guid.NewGuid(),
        Created = System.DateTime.Now                
      };
      using( var context = new Context() ) {
        result.ShoppingCart = context.ShoppingCarts.Single( n => n.Id == cart.Id );
        result.ProductOffer = context.ProductOffers.Single( n => n.Id == productOffer.Id );
        context.ShoppingCartItems.Add( result );
        context.SaveChanges();
      }
      return result;
    }

    public IOrder CreateOrder( IShoppingCart cart ) {
      var result = new Order {
        Id = Guid.NewGuid()
      };
      using( var context = new Context() ) {
        result.ShoppingCart = context.ShoppingCarts.Single( n => n.Id == cart.Id );
        context.Orders.Add( result );
        context.SaveChanges();
      }
      return result;
    }
  }
}
