using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class AdAuditDto : JdObject{


         [XmlElement("erp_code")]
public  		string
  erpCode { get; set; }


         [XmlElement("opinion")]
public  		string
  opinion { get; set; }


         [XmlElement("operate_time")]
public  		string
  operateTime { get; set; }


         [XmlElement("state")]
public  		int
  state { get; set; }


         [XmlElement("erp_name")]
public  		string
  erpName { get; set; }


}
}
