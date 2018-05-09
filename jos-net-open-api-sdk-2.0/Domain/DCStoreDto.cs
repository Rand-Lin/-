using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class DCStoreDto : JdObject{


         [XmlElement("dcid")]
public  		int
  dcid { get; set; }


         [XmlElement("sid")]
public  		int
  sid { get; set; }


}
}
