using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class FactoryAbutmentOrderDealInfo : JdObject{


         [XmlElement("orderno")]
public  		string
  orderno { get; set; }


         [XmlElement("returnCode")]
public  		string
  returnCode { get; set; }


}
}
