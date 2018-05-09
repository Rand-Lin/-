using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class JosResultDto : JdObject{


         [XmlElement("result")]
public  		List<string>
  result { get; set; }


         [XmlElement("count")]
public  		string
  count { get; set; }


         [XmlElement("is_success")]
public  		string
  isSuccess { get; set; }


         [XmlElement("return_code")]
public  		string
  returnCode { get; set; }


         [XmlElement("return_message")]
public  		string
  returnMessage { get; set; }


}
}
