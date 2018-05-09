using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class RefundApplyVo : JdObject{


         [XmlElement("id")]
public  		long
  id { get; set; }


         [XmlElement("buyerId")]
public  		string
  buyerId { get; set; }


         [XmlElement("buyerName")]
public  		string
  buyerName { get; set; }


         [XmlElement("checkTime")]
public  		string
  checkTime { get; set; }


         [XmlElement("applyTime")]
public  		string
  applyTime { get; set; }


         [XmlElement("applyRefundSum")]
public  		double
  applyRefundSum { get; set; }


         [XmlElement("status")]
public  		long
  status { get; set; }


         [XmlElement("checkUserName")]
public  		string
  checkUserName { get; set; }


         [XmlElement("orderId")]
public  		string
  orderId { get; set; }


         [XmlElement("checkRemark")]
public  		string
  checkRemark { get; set; }


}
}
