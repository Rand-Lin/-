using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class UserCategory3InfoDto : JdObject{


         [XmlElement("providerCode")]
public  		string
  providerCode { get; set; }


         [XmlElement("userCategory3Dtos")]
public  		List<string>
  userCategory3Dtos { get; set; }


}
}
