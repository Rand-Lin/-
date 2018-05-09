using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class ComponentExport : JdObject{


         [XmlElement("codeS")]
public  		string
  codeS { get; set; }


         [XmlElement("nameS")]
public  		string
  nameS { get; set; }


}
}
