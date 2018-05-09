using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class ReplyResult : JdObject{


         [XmlElement("success")]
public  		bool
  success { get; set; }


         [XmlElement("errorCode")]
public  		string
  errorCode { get; set; }


         [XmlElement("errorMsg")]
public  		string
  errorMsg { get; set; }


}
}
