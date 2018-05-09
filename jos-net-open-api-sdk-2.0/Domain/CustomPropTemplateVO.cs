using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class CustomPropTemplateVO : JdObject{


         [XmlElement("id")]
public  		long
  id { get; set; }


         [XmlElement("title")]
public  		string
  title { get; set; }


         [XmlElement("status")]
public  		int
  status { get; set; }


}
}
