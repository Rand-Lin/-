using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class ServiceApplyInfoExport : JdObject{


         [XmlElement("expectPickwareType")]
public  		int
  expectPickwareType { get; set; }


         [XmlElement("customerExpect")]
public  		int
  customerExpect { get; set; }


}
}
