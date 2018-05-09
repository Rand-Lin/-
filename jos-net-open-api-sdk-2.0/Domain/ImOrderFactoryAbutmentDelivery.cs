using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class ImOrderFactoryAbutmentDelivery : JdObject{


         [XmlElement("orderNo")]
public  		string
  orderNo { get; set; }


         [XmlElement("deliveryTime")]
public  		DateTime
  deliveryTime { get; set; }


}
}
