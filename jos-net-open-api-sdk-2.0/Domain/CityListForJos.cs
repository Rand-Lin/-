using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class CityListForJos : JdObject{


         [XmlElement("team_city_list")]
public  		List<string>
  teamCityList { get; set; }


         [XmlElement("result_code")]
public  		string
  resultCode { get; set; }


}
}
