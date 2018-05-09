using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class WorkOrderResponse : JdObject{


         [XmlElement("result_code")]
public  		string
  resultCode { get; set; }


         [XmlElement("result_msg")]
public  		string
  resultMsg { get; set; }


}
}
