using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class QueryStockInResult : JdObject{


         [XmlElement("success")]
public  		bool
  success { get; set; }


         [XmlElement("error_code")]
public  		string
  errorCode { get; set; }


         [XmlElement("error_msg")]
public  		string
  errorMsg { get; set; }


         [XmlElement("vender_id")]
public  		long
  venderId { get; set; }


         [XmlElement("stockbillinfo_list")]
public  		List<string>
  stockbillinfoList { get; set; }


}
}
