using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class TemplateDto : JdObject{


         [XmlElement("id")]
public  		int
  id { get; set; }


         [XmlElement("name")]
public  		string
  name { get; set; }


         [XmlElement("sku_template_id")]
public  		int
  skuTemplateId { get; set; }


         [XmlElement("content")]
public  		string
  content { get; set; }


         [XmlElement("type")]
public  		int
  type { get; set; }


         [XmlElement("images")]
public  		string
  images { get; set; }


         [XmlElement("status")]
public  		int
  status { get; set; }


         [XmlElement("values")]
public  		List<string>
  values { get; set; }


         [XmlElement("uuid")]
public  		string
  uuid { get; set; }


}
}
