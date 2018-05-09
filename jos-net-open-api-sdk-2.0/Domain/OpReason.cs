using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class OpReason : JdObject{


         [XmlElement("note")]
public  		string
  note { get; set; }


}
}
