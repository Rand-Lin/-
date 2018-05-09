using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class AdvancedUserInterestsParam : JdObject{


         [XmlElement("actionCycle")]
public  		int
  actionCycle { get; set; }


         [XmlElement("actionType")]
public  		int
  actionType { get; set; }


         [XmlElement("expenceRange")]
public  		int
  expenceRange { get; set; }


         [XmlElement("brandExtend")]
public  		int
  brandExtend { get; set; }


         [XmlElement("shopExtend")]
public  		int
  shopExtend { get; set; }


         [XmlElement("categoryExtend")]
public  		int
  categoryExtend { get; set; }


}
}
