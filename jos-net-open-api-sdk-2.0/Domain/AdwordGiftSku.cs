using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class AdwordGiftSku : JdObject{


         [XmlElement("skuId")]
public  		string
  skuId { get; set; }


         [XmlElement("imageUrl")]
public  		string
  imageUrl { get; set; }


         [XmlElement("name")]
public  		string
  name { get; set; }


         [XmlElement("number")]
public  		int
  number { get; set; }


         [XmlElement("giftType")]
public  		int
  giftType { get; set; }


         [XmlElement("giftState")]
public  		int
  giftState { get; set; }


}
}
