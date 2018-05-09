using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class VirtualGroupListForJos : JdObject{


         [XmlElement("virtual_groupList")]
public  		List<string>
  virtualGroupList { get; set; }


         [XmlElement("result_code")]
public  		string
  resultCode { get; set; }


}
}
