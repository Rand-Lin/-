using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class OutBoundResultDto : JdObject{


         [XmlElement("status")]
public  		int
  status { get; set; }


         [XmlElement("message")]
public  		string
  message { get; set; }


         [XmlElement("errorCode")]
public  		string
  errorCode { get; set; }


}
}
