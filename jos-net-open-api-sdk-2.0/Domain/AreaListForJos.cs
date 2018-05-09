using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class AreaListForJos : JdObject{


         [XmlElement("team_area_list")]
public  		List<string>
  teamAreaList { get; set; }


         [XmlElement("result_code")]
public  		string
  resultCode { get; set; }


}
}
