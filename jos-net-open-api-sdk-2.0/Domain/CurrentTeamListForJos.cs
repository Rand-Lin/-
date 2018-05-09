using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class CurrentTeamListForJos : JdObject{


         [XmlElement("teams")]
public  		List<string>
  teams { get; set; }


         [XmlElement("result_code")]
public  		string
  resultCode { get; set; }


}
}
