using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class BookFlightResponse : JdObject{


         [XmlElement("orderCode")]
public  		string
  orderCode { get; set; }


         [XmlElement("tradeNo")]
public  		string
  tradeNo { get; set; }


         [XmlElement("pnrList")]
public  		List<string>
  pnrList { get; set; }


         [XmlElement("flag")]
public  		string
  flag { get; set; }


         [XmlElement("message")]
public  		string
  message { get; set; }


}
}
