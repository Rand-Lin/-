using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class JosResult : JdObject{


         [XmlElement("success")]
public  		string
  success { get; set; }


         [XmlElement("errorCode")]
public  		string
  errorCode { get; set; }


         [XmlElement("errorMessage")]
public  		string
  errorMessage { get; set; }


}
}
