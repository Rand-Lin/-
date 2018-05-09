using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class DspUserTagQuery : JdObject{


         [XmlElement("name")]
public  		string
  name { get; set; }


         [XmlElement("type")]
public  		string
  type { get; set; }


         [XmlElement("pid")]
public  		long
  pid { get; set; }


         [XmlElement("wid")]
public  		long
  wid { get; set; }


         [XmlElement("status")]
public  		long
  status { get; set; }


}
}
