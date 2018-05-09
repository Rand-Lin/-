using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class JosProduct : JdObject{


         [XmlElement("jingdianId")]
public  		long
  jingdianId { get; set; }


         [XmlElement("chargeItemId")]
public  		long
  chargeItemId { get; set; }


         [XmlElement("chargeItemType")]
public  		int
  chargeItemType { get; set; }


         [XmlElement("supplierProductId")]
public  		string
  supplierProductId { get; set; }


         [XmlElement("productName")]
public  		string
  productName { get; set; }


         [XmlElement("stockCountType")]
public  		int
  stockCountType { get; set; }


         [XmlElement("productStatus")]
public  		int
  productStatus { get; set; }


         [XmlElement("pictureListJson")]
public  		string
  pictureListJson { get; set; }


         [XmlElement("datePriceListJson")]
public  		string
  datePriceListJson { get; set; }


         [XmlElement("supplierId")]
public  		string
  supplierId { get; set; }


         [XmlElement("beforeReserveMinutes")]
public  		int
  beforeReserveMinutes { get; set; }


         [XmlElement("productDesc")]
public  		string
  productDesc { get; set; }


}
}
