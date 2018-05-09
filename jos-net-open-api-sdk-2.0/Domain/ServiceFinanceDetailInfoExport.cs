using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class ServiceFinanceDetailInfoExport : JdObject{


         [XmlElement("refundWay")]
public  		string
  refundWay { get; set; }


         [XmlElement("refundWayName")]
public  		string
  refundWayName { get; set; }


         [XmlElement("status")]
public  		string
  status { get; set; }


         [XmlElement("statusName")]
public  		string
  statusName { get; set; }


         [XmlElement("refundPrice")]
public  		string
  refundPrice { get; set; }


         [XmlElement("wareName")]
public  		string
  wareName { get; set; }


         [XmlElement("wareId")]
public  		int
  wareId { get; set; }


}
}
