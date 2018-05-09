using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class SkuInfo : JdObject{


         [XmlElement("sku_code")]
public  		long
  skuCode { get; set; }


         [XmlElement("num")]
public  		long
  num { get; set; }


         [XmlElement("price")]
public  		double
  price { get; set; }


         [XmlElement("money")]
public  		double
  money { get; set; }


         [XmlElement("remark")]
public  		string
  remark { get; set; }


}
}
