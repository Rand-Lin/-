using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class SkuStock : JdObject{


         [XmlElement("detailStock")]
public  		string
  detailStock { get; set; }


         [XmlElement("skuId")]
public  		long
  skuId { get; set; }


         [XmlElement("stockNum")]
public  		long
  stockNum { get; set; }


         [XmlElement("storeId")]
public  		long
  storeId { get; set; }


}
}
