using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class SkuFareTemplateResult : JdObject{


         [XmlElement("resultStr")]
public  		string
  resultStr { get; set; }


         [XmlElement("template_list")]
public  		List<string>
  templateList { get; set; }


}
}
