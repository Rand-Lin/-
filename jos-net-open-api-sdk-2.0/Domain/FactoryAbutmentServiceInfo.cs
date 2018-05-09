using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class FactoryAbutmentServiceInfo : JdObject{


         [XmlElement("orderno")]
public  		string
  orderno { get; set; }


         [XmlElement("serviceTypeId")]
public  		int
  serviceTypeId { get; set; }


         [XmlElement("serviceTypeName")]
public  		string
  serviceTypeName { get; set; }


}
}
