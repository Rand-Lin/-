using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class RefundOrder : JdObject{


         [XmlElement("refundId")]
public  		int
  refundId { get; set; }


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


         [XmlElement("supplierId")]
public  		int
  supplierId { get; set; }


         [XmlElement("fee")]
public  		int
  fee { get; set; }


         [XmlElement("penaltyFee")]
public  		int
  penaltyFee { get; set; }


         [XmlElement("refundStatus")]
public  		int
  refundStatus { get; set; }


         [XmlElement("submitMemo")]
public  		string
  submitMemo { get; set; }


         [XmlElement("createTime")]
public  		string
  createTime { get; set; }


}
}
