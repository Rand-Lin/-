using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class SearchResult : JdObject{


         [XmlElement("count")]
public  		int
  count { get; set; }


         [XmlElement("result")]
public  		List<string>
  result { get; set; }


}
}
