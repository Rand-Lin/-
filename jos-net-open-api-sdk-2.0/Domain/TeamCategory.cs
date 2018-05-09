using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class TeamCategory : JdObject{


         [XmlElement("area_id")]
public  		string
  areaId { get; set; }


         [XmlElement("area_name")]
public  		string
  areaName { get; set; }


         [XmlElement("area_letter")]
public  		string
  areaLetter { get; set; }


         [XmlElement("sort_order")]
public  		string
  sortOrder { get; set; }


         [XmlElement("feature")]
public  		string
  feature { get; set; }


}
}
