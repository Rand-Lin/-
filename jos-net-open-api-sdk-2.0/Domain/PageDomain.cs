using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class PageDomain : JdObject{


         [XmlElement("totalRecord")]
public  		int
  totalRecord { get; set; }


         [XmlElement("objectList")]
public  		List<string>
  objectList { get; set; }


}
}
