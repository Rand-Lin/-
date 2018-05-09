using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class QueryFlightResponse : JdObject{


         [XmlElement("rowCount")]
public  		string
  rowCount { get; set; }


         [XmlElement("list")]
public  		List<string>
  list { get; set; }


         [XmlElement("flag")]
public  		string
  flag { get; set; }


         [XmlElement("message")]
public  		string
  message { get; set; }


}
}
