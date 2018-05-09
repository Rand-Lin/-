using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class IncomeResultVO : JdObject{


         [XmlElement("swiftNumber")]
public  		string
  swiftNumber { get; set; }


         [XmlElement("amount")]
public  		string
  amount { get; set; }


         [XmlElement("createTime")]
public  		string
  createTime { get; set; }


}
}
