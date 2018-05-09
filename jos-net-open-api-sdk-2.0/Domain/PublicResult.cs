using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class PublicResult : JdObject{


         [XmlElement("success")]
public  		string
  success { get; set; }


         [XmlElement("code")]
public  		string
  code { get; set; }


         [XmlElement("msg")]
public  		string
  msg { get; set; }


         [XmlElement("charge_cycles")]
public  		List<string>
  chargeCycles { get; set; }


}
}
