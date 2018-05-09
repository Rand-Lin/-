using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class Page : JdObject{


         [XmlElement("wareTemplats")]
public  		List<string>
  wareTemplats { get; set; }


         [XmlElement("pageNo")]
public  		int
  pageNo { get; set; }


         [XmlElement("pageSize")]
public  		int
  pageSize { get; set; }


         [XmlElement("totalItem")]
public  		long
  totalItem { get; set; }


}
}
