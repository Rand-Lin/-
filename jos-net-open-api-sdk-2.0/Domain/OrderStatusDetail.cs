using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class OrderStatusDetail : JdObject{


         [XmlElement("status")]
public  		string
  status { get; set; }


         [XmlElement("status_name")]
public  		string
  statusName { get; set; }


         [XmlElement("complete_time")]
public  		string
  completeTime { get; set; }


}
}
