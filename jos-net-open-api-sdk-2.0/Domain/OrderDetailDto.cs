using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class OrderDetailDto : JdObject{


         [XmlElement("date")]
public  		string
  date { get; set; }


         [XmlElement("orderid")]
public  		long
  orderid { get; set; }


         [XmlElement("ordertime")]
public  		DateTime
  ordertime { get; set; }


         [XmlElement("orderprice")]
public  		long
  orderprice { get; set; }


}
}
