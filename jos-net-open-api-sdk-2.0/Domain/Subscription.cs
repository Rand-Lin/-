using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class Subscription : JdObject{


         [XmlElement("group")]
public  		string
  group { get; set; }


         [XmlElement("topic")]
public  		string
  topic { get; set; }


}
}
