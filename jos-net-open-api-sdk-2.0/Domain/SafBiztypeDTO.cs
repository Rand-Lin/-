using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class SafBiztypeDTO : JdObject{


         [XmlElement("sub_biztype_id")]
public  		long
  subBiztypeId { get; set; }


         [XmlElement("sub_biztype_name")]
public  		string
  subBiztypeName { get; set; }


}
}
