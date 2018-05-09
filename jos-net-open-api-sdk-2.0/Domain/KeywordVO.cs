using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class KeywordVO : JdObject{


         [XmlElement("plan_id")]
public  		long
  planId { get; set; }


         [XmlElement("wgroup_id")]
public  		long
  wgroupId { get; set; }


         [XmlElement("name")]
public  		string
  name { get; set; }


         [XmlElement("price")]
public  		string
  price { get; set; }


}
}
