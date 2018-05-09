using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class ShopFreightTemplate : JdObject{


         [XmlElement("id")]
public  		string
  id { get; set; }


         [XmlElement("templateName")]
public  		string
  templateName { get; set; }


}
}
