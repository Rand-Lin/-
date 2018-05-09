using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class ProductPrice : JdObject{


         [XmlElement("priceId")]
public  		long
  priceId { get; set; }


         [XmlElement("priceDate")]
public  		string
  priceDate { get; set; }


         [XmlElement("personPrice")]
public  		int
  personPrice { get; set; }


         [XmlElement("personStock")]
public  		int
  personStock { get; set; }


         [XmlElement("childPrice")]
public  		int
  childPrice { get; set; }


         [XmlElement("childStock")]
public  		int
  childStock { get; set; }


         [XmlElement("roomPrice")]
public  		int
  roomPrice { get; set; }


         [XmlElement("beforeReserveDays")]
public  		int
  beforeReserveDays { get; set; }


}
}
