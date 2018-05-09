using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class Paginator : JdObject{


         [XmlElement("pageNum")]
public  		int
  pageNum { get; set; }


         [XmlElement("items")]
public  		int
  items { get; set; }


         [XmlElement("pageSize")]
public  		int
  pageSize { get; set; }


}
}
