using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class OrderinfoStatusFlowResponse : JdObject{


         [XmlElement("state_value")]
public  		string
  stateValue { get; set; }


         [XmlElement("state_time")]
public  		string
  stateTime { get; set; }


         [XmlElement("state_operator")]
public  		string
  stateOperator { get; set; }


         [XmlElement("state_remark")]
public  		string
  stateRemark { get; set; }


}
}
