using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class Prop : JdObject{


         [XmlElement("attrId")]
public  		string
  attrId { get; set; }


         [XmlElement("attrValueAlias")]
public  		string
  attrValueAlias { get; set; }


         [XmlElement("attrValues")]
public  		string
  attrValues { get; set; }


}
}
