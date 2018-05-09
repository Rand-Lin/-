using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class SkuFareTemplate : JdObject{


         [XmlElement("id")]
public  		long
  id { get; set; }


         [XmlElement("index")]
public  		int
  index { get; set; }


         [XmlElement("template_name")]
public  		string
  templateName { get; set; }


         [XmlElement("rule_type")]
public  		int
  ruleType { get; set; }


         [XmlElement("is_free")]
public  		int
  isFree { get; set; }


}
}
