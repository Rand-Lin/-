using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class ServiceTrackInfoExport : JdObject{


         [XmlElement("afsServiceId")]
public  		int
  afsServiceId { get; set; }


         [XmlElement("title")]
public  		string
  title { get; set; }


         [XmlElement("context")]
public  		string
  context { get; set; }


         [XmlElement("createDate")]
public  		DateTime
  createDate { get; set; }


         [XmlElement("createName")]
public  		string
  createName { get; set; }


         [XmlElement("createPin")]
public  		string
  createPin { get; set; }


}
}
