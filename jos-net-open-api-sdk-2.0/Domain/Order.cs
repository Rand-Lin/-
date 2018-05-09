using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class Order : JdObject{


         [XmlElement("orderId")]
public  		int
  orderId { get; set; }


         [XmlElement("productId")]
public  		string
  productId { get; set; }


         [XmlElement("jdErpOrderId")]
public  		long
  jdErpOrderId { get; set; }


         [XmlElement("pin")]
public  		string
  pin { get; set; }


         [XmlElement("contactName")]
public  		string
  contactName { get; set; }


         [XmlElement("contactPhone")]
public  		string
  contactPhone { get; set; }


         [XmlElement("buyTime")]
public  		string
  buyTime { get; set; }


         [XmlElement("confirmTime")]
public  		string
  confirmTime { get; set; }


         [XmlElement("payTime")]
public  		string
  payTime { get; set; }


         [XmlElement("personCount")]
public  		int
  personCount { get; set; }


         [XmlElement("childCount")]
public  		int
  childCount { get; set; }


         [XmlElement("roomCount")]
public  		int
  roomCount { get; set; }


         [XmlElement("depDate")]
public  		string
  depDate { get; set; }


         [XmlElement("normalPrice")]
public  		int
  normalPrice { get; set; }


         [XmlElement("childPrice")]
public  		int
  childPrice { get; set; }


         [XmlElement("roomPrice")]
public  		int
  roomPrice { get; set; }


         [XmlElement("totalFee")]
public  		int
  totalFee { get; set; }


         [XmlElement("orderStatus")]
public  		int
  orderStatus { get; set; }


         [XmlElement("payStatus")]
public  		int
  payStatus { get; set; }


         [XmlElement("totalRefundFee")]
public  		int
  totalRefundFee { get; set; }


}
}
