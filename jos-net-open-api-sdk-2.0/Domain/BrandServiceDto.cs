using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class BrandServiceDto : JdObject{


         [XmlElement("category_id")]
public  		int
  categoryId { get; set; }


         [XmlElement("brand")]
public  		string
  brand { get; set; }


         [XmlElement("tel")]
public  		string
  tel { get; set; }


         [XmlElement("website")]
public  		string
  website { get; set; }


}
}
