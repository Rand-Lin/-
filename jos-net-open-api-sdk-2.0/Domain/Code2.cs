using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class Code2 : JdObject{


         [XmlElement("id")]
public  		long
  id { get; set; }


         [XmlElement("name")]
public  		string
  name { get; set; }


         [XmlElement("imagePath")]
public  		string
  imagePath { get; set; }


         [XmlElement("type")]
public  		long
  type { get; set; }


         [XmlElement("createtime")]
public  		string
  createtime { get; set; }


         [XmlElement("updatetime")]
public  		string
  updatetime { get; set; }


}
}
