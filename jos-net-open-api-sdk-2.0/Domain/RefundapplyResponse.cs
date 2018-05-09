using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class RefundapplyResponse : JdObject{


         [XmlElement("results")]
public  		List<string>
  results { get; set; }


         [XmlElement("result_state")]
public  		bool
  resultState { get; set; }


         [XmlElement("result_info")]
public  		string
  resultInfo { get; set; }


}
}
