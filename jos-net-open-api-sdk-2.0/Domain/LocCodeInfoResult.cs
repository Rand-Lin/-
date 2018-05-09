using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class LocCodeInfoResult : JdObject{


         [XmlElement("result_code")]
public  		int
  resultCode { get; set; }


         [XmlElement("result_message")]
public  		string
  resultMessage { get; set; }


         [XmlElement("is_success")]
public  		bool
  isSuccess { get; set; }


         [XmlElement("total_code")]
public  		int
  totalCode { get; set; }


         [XmlElement("loccodeinfo_list")]
public  		List<string>
  loccodeinfoList { get; set; }


}
}
