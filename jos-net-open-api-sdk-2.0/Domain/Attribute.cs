using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class Attribute : JdObject{


         [XmlElement("attId")]
public  		int
  attId { get; set; }


         [XmlElement("attName")]
public  		string
  attName { get; set; }


         [XmlElement("groupId")]
public  		int
  groupId { get; set; }


         [XmlElement("type")]
public  		int
  type { get; set; }


}
}
