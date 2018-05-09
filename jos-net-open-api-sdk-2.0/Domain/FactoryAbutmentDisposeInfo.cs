using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class FactoryAbutmentDisposeInfo : JdObject{


         [XmlElement("orderno")]
public  		string
  orderno { get; set; }


         [XmlElement("disposeTime")]
public  		DateTime
  disposeTime { get; set; }


         [XmlElement("disposeResult")]
public  		int
  disposeResult { get; set; }


         [XmlElement("remark")]
public  		string
  remark { get; set; }


}
}
