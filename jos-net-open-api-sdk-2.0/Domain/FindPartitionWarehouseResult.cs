using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class FindPartitionWarehouseResult : JdObject{


         [XmlElement("success")]
public  		string
  success { get; set; }


         [XmlElement("message")]
public  		string
  message { get; set; }


         [XmlElement("result")]
public  		List<string>
  result { get; set; }


}
}
