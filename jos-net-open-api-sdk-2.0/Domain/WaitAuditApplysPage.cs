using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class WaitAuditApplysPage : JdObject{


         [XmlElement("applyInfoList")]
public  		List<string>
  applyInfoList { get; set; }


         [XmlElement("totalNum")]
public  		string
  totalNum { get; set; }


}
}
