using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class GetResultInfoDTO : JdObject{


         [XmlElement("code")]
public  		string
  code { get; set; }


         [XmlElement("message")]
public  		string
  message { get; set; }


         [XmlElement("deliveryIdList")]
public  		List<string>
  deliveryIdList { get; set; }


}
}
