using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class ServicesResult : JdObject{


         [XmlElement("success")]
public  		string
  success { get; set; }


         [XmlElement("services")]
public  		List<string>
  services { get; set; }


}
}
