using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class ChargeVO : JdObject{


         [XmlElement("itemCode")]
public  		string
  itemCode { get; set; }


         [XmlElement("chargeType")]
public  		int
  chargeType { get; set; }


         [XmlElement("itemVersion")]
public  		int
  itemVersion { get; set; }


         [XmlElement("chargeCycleVOList")]
public  		List<string>
  chargeCycleVOList { get; set; }


}
}
