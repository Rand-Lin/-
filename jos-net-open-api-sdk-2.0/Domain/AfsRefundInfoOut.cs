using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class AfsRefundInfoOut : JdObject{


         [XmlElement("afsFinanceDetailOuts")]
public  		List<string>
  afsFinanceDetailOuts { get; set; }


         [XmlElement("afsSignatureOut")]
public  		List<string>
  afsSignatureOut { get; set; }


         [XmlElement("afsFinanceOut")]
public  		string
  afsFinanceOut { get; set; }


         [XmlElement("afsRefundOut")]
public  		string
  afsRefundOut { get; set; }


}
}
