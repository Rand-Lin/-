using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class ExpressInfoDto : JdObject{


         [XmlElement("customOrderId")]
public  		string
  customOrderId { get; set; }


         [XmlElement("receiveName")]
public  		string
  receiveName { get; set; }


         [XmlElement("deliveryId")]
public  		string
  deliveryId { get; set; }


}
}
