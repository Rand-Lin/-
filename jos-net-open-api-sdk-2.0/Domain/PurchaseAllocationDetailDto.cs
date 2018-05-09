using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class PurchaseAllocationDetailDto : JdObject{


         [XmlElement("wareId")]
public  		long
  wareId { get; set; }


         [XmlElement("deliverCenterId")]
public  		int
  deliverCenterId { get; set; }


         [XmlElement("deliverCenterName")]
public  		string
  deliverCenterName { get; set; }


         [XmlElement("wareName")]
public  		string
  wareName { get; set; }


         [XmlElement("purchasePrice")]
public  		string
  purchasePrice { get; set; }


         [XmlElement("totoalPrice")]
public  		string
  totoalPrice { get; set; }


         [XmlElement("makePrice")]
public  		string
  makePrice { get; set; }


         [XmlElement("currentMakePrice")]
public  		string
  currentMakePrice { get; set; }


         [XmlElement("discount")]
public  		string
  discount { get; set; }


         [XmlElement("originalNum")]
public  		int
  originalNum { get; set; }


         [XmlElement("confirmNum")]
public  		int
  confirmNum { get; set; }


         [XmlElement("actualNum")]
public  		int
  actualNum { get; set; }


         [XmlElement("nonDeliveryReason")]
public  		string
  nonDeliveryReason { get; set; }


         [XmlElement("remark")]
public  		string
  remark { get; set; }


         [XmlElement("isbn")]
public  		string
  isbn { get; set; }


         [XmlElement("brandName")]
public  		string
  brandName { get; set; }


         [XmlElement("brandId")]
public  		string
  brandId { get; set; }


         [XmlElement("purchaseWareProperty")]
public  		string
  purchaseWareProperty { get; set; }


}
}
