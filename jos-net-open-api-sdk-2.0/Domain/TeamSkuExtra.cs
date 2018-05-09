using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class TeamSkuExtra : JdObject{


         [XmlElement("sku_id")]
public  		string
  skuId { get; set; }


         [XmlElement("sku_name")]
public  		string
  skuName { get; set; }


         [XmlElement("sku_price")]
public  		string
  skuPrice { get; set; }


         [XmlElement("sku_per_number")]
public  		string
  skuPerNumber { get; set; }


         [XmlElement("feature")]
public  		string
  feature { get; set; }


}
}
