using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class OrderInfoOperateResponse : JdObject{


         [XmlElement("stateCode")]
public  		int
  stateCode { get; set; }


         [XmlElement("stateMessage")]
public  		string
  stateMessage { get; set; }


}
}
