using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class SaleDiscount : JdObject{


         [XmlElement("saleDiscountId")]
public  		string
  saleDiscountId { get; set; }


         [XmlElement("saleDiscountType")]
public  		string
  saleDiscountType { get; set; }


         [XmlElement("saleDiscountPrice")]
public  		double
  saleDiscountPrice { get; set; }


         [XmlElement("saleDiscountMoney")]
public  		double
  saleDiscountMoney { get; set; }


         [XmlElement("saleDiscountName")]
public  		string
  saleDiscountName { get; set; }


         [XmlElement("saleDiscountText")]
public  		string
  saleDiscountText { get; set; }


         [XmlElement("discount")]
public  		string
  discount { get; set; }


         [XmlElement("agentSaleMoney")]
public  		double
  agentSaleMoney { get; set; }


         [XmlElement("jdCommission")]
public  		double
  jdCommission { get; set; }


         [XmlElement("isEffective")]
public  		string
  isEffective { get; set; }


         [XmlElement("created")]
public  		DateTime
  created { get; set; }


}
}
