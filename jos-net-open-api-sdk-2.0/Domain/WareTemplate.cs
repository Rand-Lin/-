using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class WareTemplate : JdObject{


         [XmlElement("id")]
public  		long
  id { get; set; }


         [XmlElement("bottomContent")]
public  		string
  bottomContent { get; set; }


         [XmlElement("headContent")]
public  		string
  headContent { get; set; }


         [XmlElement("name")]
public  		string
  name { get; set; }


         [XmlElement("refCount")]
public  		int
  refCount { get; set; }


}
}
