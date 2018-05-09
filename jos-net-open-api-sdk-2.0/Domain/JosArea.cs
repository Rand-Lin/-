using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class JosArea : JdObject{


         [XmlElement("areaName")]
public  		string
  areaName { get; set; }


         [XmlElement("areaId")]
public  		int
  areaId { get; set; }


         [XmlElement("parentAreaId")]
public  		int
  parentAreaId { get; set; }


}
}
