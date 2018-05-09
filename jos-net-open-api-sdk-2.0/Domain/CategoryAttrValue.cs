using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class CategoryAttrValue : JdObject{


         [XmlElement("attrValueId")]
public  		long
  attrValueId { get; set; }


         [XmlElement("attrValueIndexId")]
public  		int
  attrValueIndexId { get; set; }


         [XmlElement("attrValue")]
public  		string
  attrValue { get; set; }


         [XmlElement("attrValueFeatures")]
public  		string
  attrValueFeatures { get; set; }


}
}
