using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class Product : JdObject{


         [XmlElement("productId")]
public  		string
  productId { get; set; }


         [XmlElement("supplierId")]
public  		int
  supplierId { get; set; }


         [XmlElement("productName")]
public  		string
  productName { get; set; }


         [XmlElement("confirmType")]
public  		int
  confirmType { get; set; }


         [XmlElement("productStatus")]
public  		int
  productStatus { get; set; }


         [XmlElement("departure")]
public  		string
  departure { get; set; }


         [XmlElement("arrive")]
public  		string
  arrive { get; set; }


         [XmlElement("days")]
public  		int
  days { get; set; }


         [XmlElement("recommendDescList")]
public  		List<string>
  recommendDescList { get; set; }


         [XmlElement("marketPrice")]
public  		int
  marketPrice { get; set; }


         [XmlElement("childDesc")]
public  		string
  childDesc { get; set; }


         [XmlElement("latestFormDays")]
public  		int
  latestFormDays { get; set; }


         [XmlElement("stockCountType")]
public  		int
  stockCountType { get; set; }


         [XmlElement("costContain")]
public  		string
  costContain { get; set; }


         [XmlElement("costNoContain")]
public  		string
  costNoContain { get; set; }


         [XmlElement("reserveRead")]
public  		string
  reserveRead { get; set; }


         [XmlElement("productDesc")]
public  		string
  productDesc { get; set; }


         [XmlElement("productTripDesc")]
public  		string
  productTripDesc { get; set; }


         [XmlElement("selfReturnRule")]
public  		string
  selfReturnRule { get; set; }


         [XmlElement("pictureUrlList")]
public  		List<string>
  pictureUrlList { get; set; }


         [XmlElement("priceList")]
public  		List<string>
  priceList { get; set; }


}
}
