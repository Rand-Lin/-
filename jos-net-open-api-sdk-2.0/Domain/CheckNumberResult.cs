using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class CheckNumberResult : JdObject{


         [XmlElement("result_code")]
public  		int
  resultCode { get; set; }


         [XmlElement("result_message")]
public  		string
  resultMessage { get; set; }


         [XmlElement("is_success")]
public  		bool
  isSuccess { get; set; }


         [XmlElement("check_numbers")]
public  		List<string>
  checkNumbers { get; set; }


}
}
