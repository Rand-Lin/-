using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class AreaListBeanVO : JdObject{


         [XmlElement("id")]
public  		long
  id { get; set; }


         [XmlElement("name")]
public  		string
  name { get; set; }


         [XmlElement("is3cod")]
public  		string
  is3cod { get; set; }


         [XmlElement("cod")]
public  		bool
  cod { get; set; }


}
}
