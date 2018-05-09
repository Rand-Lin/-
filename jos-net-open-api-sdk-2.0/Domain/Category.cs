using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class Category : JdObject{


         [XmlElement("categoryNo")]
public  		string
  categoryNo { get; set; }


         [XmlElement("categoryName")]
public  		string
  categoryName { get; set; }


}
}
