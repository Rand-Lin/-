using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class AdwordCoupon : JdObject{


         [XmlElement("type")]
public  		int
  type { get; set; }


         [XmlElement("key")]
public  		string
  key { get; set; }


         [XmlElement("couponQouta")]
public  		int
  couponQouta { get; set; }


}
}
