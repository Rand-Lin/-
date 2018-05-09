using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class QueryRow : JdObject{


         [XmlElement("values")]
public  		List<string>
  values { get; set; }


}
}
