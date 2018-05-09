using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class VenderInfoResult : JdObject{


         [XmlElement("levelOne")]
public  		List<string>
  levelOne { get; set; }


         [XmlElement("levelTwo")]
public  		List<string>
  levelTwo { get; set; }


         [XmlElement("levelThree")]
public  		List<string>
  levelThree { get; set; }


         [XmlElement("messegeCode")]
public  		string
  messegeCode { get; set; }


         [XmlElement("message")]
public  		string
  message { get; set; }


         [XmlElement("success")]
public  		string
  success { get; set; }


}
}
