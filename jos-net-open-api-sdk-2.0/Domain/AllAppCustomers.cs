using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class AllAppCustomers : JdObject{


         [XmlElement("totalResult")]
public  		string
  totalResult { get; set; }


         [XmlElement("appCustomers")]
public  		List<string>
  appCustomers { get; set; }


}
}
