using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class ExtPropertyResponse : JdObject{


         [XmlElement("giftList")]
public  		List<string>
  giftList { get; set; }


         [XmlElement("details")]
public  		string
  details { get; set; }


}
}
