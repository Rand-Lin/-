using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class BrandDto : JdObject{


         [XmlElement("cn_name")]
public  		string
  cnName { get; set; }


         [XmlElement("en_name")]
public  		string
  enName { get; set; }


         [XmlElement("id")]
public  		int
  id { get; set; }


         [XmlElement("name")]
public  		string
  name { get; set; }


}
}
