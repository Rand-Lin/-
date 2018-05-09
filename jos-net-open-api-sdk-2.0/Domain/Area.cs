using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class Area : JdObject{


         [XmlElement("areaId")]
public  		int
  areaId { get; set; }


         [XmlElement("areaName")]
public  		string
  areaName { get; set; }


         [XmlElement("parentId")]
public  		int
  parentId { get; set; }


         [XmlElement("status")]
public  		int
  status { get; set; }


         [XmlElement("level")]
public  		int
  level { get; set; }


}
}
