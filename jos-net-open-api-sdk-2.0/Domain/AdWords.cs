using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class AdWords : JdObject{


         [XmlElement("words")]
public  		string
  words { get; set; }


         [XmlElement("url")]
public  		string
  url { get; set; }


         [XmlElement("urlWords")]
public  		string
  urlWords { get; set; }


}
}
