using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class PropDto : JdObject{


         [XmlElement("id")]
public  		int
  id { get; set; }


         [XmlElement("order_sort")]
public  		int
  orderSort { get; set; }


         [XmlElement("name")]
public  		string
  name { get; set; }


         [XmlElement("required")]
public  		string
  required { get; set; }


         [XmlElement("input_type")]
public  		int
  inputType { get; set; }


         [XmlElement("values")]
public  		List<string>
  values { get; set; }


}
}
