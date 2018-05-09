using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class PageReceiveTask : JdObject{


         [XmlElement("totalCount")]
public  		string
  totalCount { get; set; }


         [XmlElement("result")]
public  		List<string>
  result { get; set; }


}
}
