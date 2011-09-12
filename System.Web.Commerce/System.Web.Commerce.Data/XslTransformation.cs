using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
namespace System.Web.Commerce.Data {
  public class XslTransformation : ISupportsPersistance {
    public Guid Id { get; set; }
    public string TransformationName { get; set; }
    public string TransformationDescription { get; set; }
    [Column(TypeName="XML")]
    public string Xsl { get; set; }
    [NotMapped]
    public XDocument XslDocument {
      get { return XDocument.Parse( Xsl ); }
      set { Xsl = value.ToString(); }
    }
  }
}
