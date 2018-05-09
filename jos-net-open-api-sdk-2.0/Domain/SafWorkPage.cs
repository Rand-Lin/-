using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class SafWorkPage : JdObject{


         [XmlElement("result")]
public  		List<string>
  result { get; set; }


         [XmlElement("total_count")]
public  		string
  totalCount { get; set; }


}
}
