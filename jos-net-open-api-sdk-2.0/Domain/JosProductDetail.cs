using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class JosProductDetail : JdObject{


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


         [XmlElement("beforeReserveMinutes")]
public  		int
  beforeReserveMinutes { get; set; }


         [XmlElement("supplierId")]
public  		int
  supplierId { get; set; }


         [XmlElement("productDesc")]
public  		string
  productDesc { get; set; }


         [XmlElement("pictureListJson")]
public  		string
  pictureListJson { get; set; }


         [XmlElement("datePriceListJson")]
public  		string
  datePriceListJson { get; set; }


         [XmlElement("success")]
public  		string
  success { get; set; }


         [XmlElement("errorCode")]
public  		string
  errorCode { get; set; }


         [XmlElement("errorMessage")]
public  		string
  errorMessage { get; set; }


         [XmlElement("refundRuleType")]
public  		int
  refundRuleType { get; set; }


         [XmlElement("changeRuleType")]
public  		int
  changeRuleType { get; set; }


         [XmlElement("refundRuleDesc")]
public  		string
  refundRuleDesc { get; set; }


         [XmlElement("changeRuleDesc")]
public  		string
  changeRuleDesc { get; set; }


         [XmlElement("bookingInfo")]
public  		string
  bookingInfo { get; set; }


}
}
