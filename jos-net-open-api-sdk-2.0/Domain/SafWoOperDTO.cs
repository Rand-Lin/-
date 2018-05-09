using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class SafWoOperDTO : JdObject{


         [XmlElement("oper_user")]
public  		string
  operUser { get; set; }


         [XmlElement("oper_date")]
public  		DateTime
  operDate { get; set; }


         [XmlElement("oper_type")]
public  		string
  operType { get; set; }


         [XmlElement("oper_content")]
public  		string
  operContent { get; set; }


}
}
