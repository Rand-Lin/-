using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class WareQueryResult : JdObject{


         [XmlElement("totalCount")]
public  		int
  totalCount { get; set; }


         [XmlElement("currentPage")]
public  		int
  currentPage { get; set; }


         [XmlElement("wareList")]
public  		List<string>
  wareList { get; set; }


         [XmlElement("messegeCode")]
public  		string
  messegeCode { get; set; }


         [XmlElement("message")]
public  		string
  message { get; set; }


         [XmlElement("success")]
public  		string
  success { get; set; }


}
}
