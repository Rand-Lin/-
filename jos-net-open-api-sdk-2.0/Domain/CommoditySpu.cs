using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class CommoditySpu : JdObject{


         [XmlElement("material_id")]
public  		long
  materialId { get; set; }


         [XmlElement("sku_id")]
public  		long
  skuId { get; set; }


         [XmlElement("image_url")]
public  		string
  imageUrl { get; set; }


}
}
