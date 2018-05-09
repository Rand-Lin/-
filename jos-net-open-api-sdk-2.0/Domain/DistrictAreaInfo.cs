using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class DistrictAreaInfo : JdObject{


         [XmlElement("id")]
public  		string
  id { get; set; }


         [XmlElement("name")]
public  		string
  name { get; set; }


         [XmlElement("type")]
public  		string
  type { get; set; }


}
}
