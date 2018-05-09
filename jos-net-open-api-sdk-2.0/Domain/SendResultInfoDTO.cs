using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class SendResultInfoDTO : JdObject{


         [XmlElement("code")]
public  		string
  code { get; set; }


         [XmlElement("message")]
public  		string
  message { get; set; }


         [XmlElement("orderId")]
public  		string
  orderId { get; set; }


         [XmlElement("deliveryId")]
public  		string
  deliveryId { get; set; }


}
}
