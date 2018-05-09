using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class PropertyValueVO : JdObject{


         [XmlElement("catId")]
public  		int
  catId { get; set; }


         [XmlElement("propertyValueId")]
public  		int
  propertyValueId { get; set; }


         [XmlElement("valueData")]
public  		string
  valueData { get; set; }


         [XmlElement("valueDataEn")]
public  		string
  valueDataEn { get; set; }


}
}
