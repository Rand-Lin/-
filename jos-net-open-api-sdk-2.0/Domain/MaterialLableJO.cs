using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class MaterialLableJO : JdObject{


         [XmlElement("id")]
public  		string
  id { get; set; }


         [XmlElement("label_name")]
public  		string
  labelName { get; set; }


         [XmlElement("buyout_price")]
public  		string
  buyoutPrice { get; set; }


         [XmlElement("cpc_price")]
public  		string
  cpcPrice { get; set; }


}
}
