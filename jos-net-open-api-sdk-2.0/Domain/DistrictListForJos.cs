using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class DistrictListForJos : JdObject{


         [XmlElement("team_district_list")]
public  		List<string>
  teamDistrictList { get; set; }


         [XmlElement("result_code")]
public  		string
  resultCode { get; set; }


}
}
