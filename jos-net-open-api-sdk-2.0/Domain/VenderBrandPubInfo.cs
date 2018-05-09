using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class VenderBrandPubInfo : JdObject{


         [XmlElement("erpBrandId")]
public  		int
  erpBrandId { get; set; }


         [XmlElement("brandName")]
public  		string
  brandName { get; set; }


}
}
