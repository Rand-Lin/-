using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class JosProductTripInfo : JdObject{


         [XmlElement("productId")]
public  		string
  productId { get; set; }


         [XmlElement("supplierId")]
public  		int
  supplierId { get; set; }


         [XmlElement("tripName")]
public  		string
  tripName { get; set; }


         [XmlElement("tripDayNum")]
public  		int
  tripDayNum { get; set; }


         [XmlElement("trafficTypeList")]
public  		string
  trafficTypeList { get; set; }


         [XmlElement("trafficOtherDesc")]
public  		string
  trafficOtherDesc { get; set; }


         [XmlElement("trafficDesc")]
public  		string
  trafficDesc { get; set; }


         [XmlElement("breakfastDesc")]
public  		string
  breakfastDesc { get; set; }


         [XmlElement("noonDesc")]
public  		string
  noonDesc { get; set; }


         [XmlElement("dinnerDesc")]
public  		string
  dinnerDesc { get; set; }


         [XmlElement("hotelDesc")]
public  		string
  hotelDesc { get; set; }


         [XmlElement("tripDesc")]
public  		string
  tripDesc { get; set; }


}
}
