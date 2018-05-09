using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class Image : JdObject{


         [XmlElement("id")]
public  		long
  id { get; set; }


         [XmlElement("sku_id")]
public  		long
  skuId { get; set; }


         [XmlElement("path")]
public  		string
  path { get; set; }


         [XmlElement("yn")]
public  		int
  yn { get; set; }


         [XmlElement("is_primary")]
public  		int
  isPrimary { get; set; }


         [XmlElement("orderSort")]
public  		int
  orderSort { get; set; }


         [XmlElement("position")]
public  		int
  position { get; set; }


         [XmlElement("type")]
public  		int
  type { get; set; }


}
}
