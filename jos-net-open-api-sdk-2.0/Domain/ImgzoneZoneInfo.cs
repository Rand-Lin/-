using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class ImgzoneZoneInfo : JdObject{


         [XmlElement("name")]
public  		string
  name { get; set; }


         [XmlElement("used_size")]
public  		int
  usedSize { get; set; }


         [XmlElement("total_size")]
public  		int
  totalSize { get; set; }


         [XmlElement("created")]
public  		DateTime
  created { get; set; }


}
}
