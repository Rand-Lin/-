using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class PropSetting : JdObject{


         [XmlElement("pid")]
public  		int
  pid { get; set; }


         [XmlElement("vid")]
public  		int
  vid { get; set; }


         [XmlElement("remark")]
public  		string
  remark { get; set; }


         [XmlElement("vname")]
public  		string
  vname { get; set; }


}
}
