using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class ImagePathDto : JdObject{


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


         [XmlElement("order_sort")]
public  		int
  orderSort { get; set; }


         [XmlElement("op_name")]
public  		string
  opName { get; set; }


         [XmlElement("ip")]
public  		string
  ip { get; set; }


}
}
