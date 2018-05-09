using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class RankReturnJO : JdObject{


         [XmlElement("response")]
public  		int
  response { get; set; }


         [XmlElement("rank")]
public  		string
  rank { get; set; }


         [XmlElement("description")]
public  		string
  description { get; set; }


         [XmlElement("plan_date")]
public  		string
  planDate { get; set; }


}
}
