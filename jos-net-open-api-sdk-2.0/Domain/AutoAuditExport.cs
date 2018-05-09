using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class AutoAuditExport : JdObject{


         [XmlElement("serviceId")]
public  		int
  serviceId { get; set; }


         [XmlElement("vcCode")]
public  		string
  vcCode { get; set; }


}
}
