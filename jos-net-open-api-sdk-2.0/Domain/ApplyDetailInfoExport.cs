using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class ApplyDetailInfoExport : JdObject{


         [XmlElement("afsApplyDetailId")]
public  		int
  afsApplyDetailId { get; set; }


         [XmlElement("wareId")]
public  		int
  wareId { get; set; }


         [XmlElement("wareName")]
public  		string
  wareName { get; set; }


         [XmlElement("afsDetailType")]
public  		int
  afsDetailType { get; set; }


         [XmlElement("wareDescribe")]
public  		string
  wareDescribe { get; set; }


}
}
