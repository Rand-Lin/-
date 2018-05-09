using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class Visitor : JdObject{


         [XmlElement("visitorType")]
public  		int
  visitorType { get; set; }


         [XmlElement("name")]
public  		string
  name { get; set; }


         [XmlElement("cardType")]
public  		int
  cardType { get; set; }


         [XmlElement("cardNumber")]
public  		string
  cardNumber { get; set; }


         [XmlElement("gender")]
public  		int
  gender { get; set; }


         [XmlElement("birthday")]
public  		string
  birthday { get; set; }


         [XmlElement("phone")]
public  		string
  phone { get; set; }


}
}
