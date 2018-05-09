using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class ServiceResult : JdObject{


         [XmlElement("success")]
public  		string
  success { get; set; }


         [XmlElement("service")]
public  		string
  service { get; set; }


}
}
