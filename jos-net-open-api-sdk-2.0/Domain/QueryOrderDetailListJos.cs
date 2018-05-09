using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class QueryOrderDetailListJos : JdObject{


         [XmlElement("details")]
public  		List<string>
  details { get; set; }


}
}
