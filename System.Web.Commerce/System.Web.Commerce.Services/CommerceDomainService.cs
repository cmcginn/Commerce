using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ServiceModel.DomainServices.EntityFramework;
using System.ServiceModel.DomainServices.Hosting;
using System.ServiceModel.DomainServices.Server;
using Microsoft.ServiceModel.DomainServices.Hosting;
using Microsoft.ServiceModel.DomainServices.Tools;

namespace System.Web.Commerce.Data {
  public class CommerceDomainService : DbDomainService<Context> {
    [Query( IsDefault = true )]
    public IQueryable<Product> GetAllProducts() {
      return this.DbContext.Products.AsQueryable();
    }
  }
}
