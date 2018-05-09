using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class PageList : JdObject{


         [XmlElement("datas")]
public  		List<string>
  datas { get; set; }


         [XmlElement("paginator")]
public  		string
  paginator { get; set; }


}
}
