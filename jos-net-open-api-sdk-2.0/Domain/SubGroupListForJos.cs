using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class SubGroupListForJos : JdObject{


         [XmlElement("sub_group_list")]
public  		List<string>
  subGroupList { get; set; }


         [XmlElement("result_code")]
public  		string
  resultCode { get; set; }


}
}
