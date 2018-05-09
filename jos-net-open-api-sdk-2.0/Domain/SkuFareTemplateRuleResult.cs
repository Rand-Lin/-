using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class SkuFareTemplateRuleResult : JdObject{


         [XmlElement("resultStr")]
public  		string
  resultStr { get; set; }


         [XmlElement("types")]
public  		List<string>
  types { get; set; }


}
}
