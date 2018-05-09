using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class ReturnOrderDetailForJosDto : JdObject{


         [XmlElement("skuId")]
public  		string
  skuId { get; set; }


         [XmlElement("commodityName")]
public  		string
  commodityName { get; set; }


         [XmlElement("commodityNum")]
public  		string
  commodityNum { get; set; }


}
}
