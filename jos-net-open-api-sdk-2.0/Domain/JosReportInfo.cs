using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class JosReportInfo : JdObject{


         [XmlElement("id")]
public  		long
  id { get; set; }


         [XmlElement("dimension")]
public  		string
  dimension { get; set; }


         [XmlElement("date")]
public  		DateTime
  date { get; set; }


         [XmlElement("figureData")]
public  		string
  figureData { get; set; }


}
}
