using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class AfsRefundDto : JdObject{


         [XmlElement("customer_order_id")]
public  		string
  customerOrderId { get; set; }


         [XmlElement("typeId")]
public  		int
  typeId { get; set; }


         [XmlElement("itemName")]
public  		string
  itemName { get; set; }


         [XmlElement("itemMoney")]
public  		string
  itemMoney { get; set; }


}
}
