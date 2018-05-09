using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class PurchaseOrderDto : JdObject{


         [XmlElement("orderId")]
public  		long
  orderId { get; set; }


         [XmlElement("createdDate")]
public  		DateTime
  createdDate { get; set; }


         [XmlElement("completeDate")]
public  		DateTime
  completeDate { get; set; }


         [XmlElement("providerCode")]
public  		string
  providerCode { get; set; }


         [XmlElement("providerName")]
public  		string
  providerName { get; set; }


         [XmlElement("deliverCenterId")]
public  		int
  deliverCenterId { get; set; }


         [XmlElement("deliverCenterName")]
public  		string
  deliverCenterName { get; set; }


         [XmlElement("totalPrices")]
public  		string
  totalPrices { get; set; }


         [XmlElement("purchaserErpCode")]
public  		string
  purchaserErpCode { get; set; }


         [XmlElement("purchaserName")]
public  		string
  purchaserName { get; set; }


         [XmlElement("isCanConfirm")]
public  		bool
  isCanConfirm { get; set; }


         [XmlElement("status")]
public  		int
  status { get; set; }


         [XmlElement("statusName")]
public  		string
  statusName { get; set; }


         [XmlElement("accountPeriod")]
public  		int
  accountPeriod { get; set; }


         [XmlElement("ou")]
public  		string
  ou { get; set; }


         [XmlElement("ynPaid")]
public  		string
  ynPaid { get; set; }


         [XmlElement("ynContainTax")]
public  		string
  ynContainTax { get; set; }


         [XmlElement("chargeTransit")]
public  		string
  chargeTransit { get; set; }


         [XmlElement("transitType")]
public  		string
  transitType { get; set; }


         [XmlElement("arrivalDays")]
public  		int
  arrivalDays { get; set; }


         [XmlElement("checkType")]
public  		int
  checkType { get; set; }


         [XmlElement("checkTypeName")]
public  		string
  checkTypeName { get; set; }


         [XmlElement("deliveryAddress")]
public  		string
  deliveryAddress { get; set; }


         [XmlElement("receiverName")]
public  		string
  receiverName { get; set; }


         [XmlElement("warehousePhone")]
public  		string
  warehousePhone { get; set; }


         [XmlElement("address")]
public  		string
  address { get; set; }


         [XmlElement("purchaseType")]
public  		int
  purchaseType { get; set; }


         [XmlElement("purchaseTypeName")]
public  		string
  purchaseTypeName { get; set; }


         [XmlElement("orderType")]
public  		int
  orderType { get; set; }


         [XmlElement("orderTypeName")]
public  		string
  orderTypeName { get; set; }


         [XmlElement("orderAttribute")]
public  		int
  orderAttribute { get; set; }


         [XmlElement("orderAttributeName")]
public  		string
  orderAttributeName { get; set; }


         [XmlElement("originalTotalNum")]
public  		int
  originalTotalNum { get; set; }


         [XmlElement("wareVariety")]
public  		int
  wareVariety { get; set; }


         [XmlElement("customOrderId")]
public  		int
  customOrderId { get; set; }


         [XmlElement("confirmState")]
public  		int
  confirmState { get; set; }


         [XmlElement("confirmStateName")]
public  		string
  confirmStateName { get; set; }


         [XmlElement("state")]
public  		int
  state { get; set; }


         [XmlElement("stateName")]
public  		string
  stateName { get; set; }


}
}
