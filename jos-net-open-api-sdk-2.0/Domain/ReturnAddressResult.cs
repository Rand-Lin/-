using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class ReturnAddressResult : JdObject{


         [XmlElement("is_success")]
public  		string
  isSuccess { get; set; }


         [XmlElement("error_code")]
public  		string
  errorCode { get; set; }


         [XmlElement("error_msg")]
public  		string
  errorMsg { get; set; }


         [XmlElement("total_count")]
public  		string
  totalCount { get; set; }


         [XmlElement("return_address_s")]
public  		List<string>
  returnAddressS { get; set; }


}
}
