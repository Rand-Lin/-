using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class AfsSignatureOut : JdObject{


         [XmlElement("opName")]
public  		string
  opName { get; set; }


         [XmlElement("remark")]
public  		string
  remark { get; set; }


         [XmlElement("opTime")]
public  		DateTime
  opTime { get; set; }


}
}
