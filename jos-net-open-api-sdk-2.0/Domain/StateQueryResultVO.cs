using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class StateQueryResultVO : JdObject{


         [XmlElement("sku")]
public  		string
  sku { get; set; }


         [XmlElement("a")]
public  		string
  a { get; set; }


}
}
