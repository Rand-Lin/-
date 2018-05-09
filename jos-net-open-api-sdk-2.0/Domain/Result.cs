using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class Result : JdObject{


         [XmlElement("status")]
public  		string
  status { get; set; }


         [XmlElement("result")]
public  		string
  result { get; set; }


         [XmlElement("msg")]
public  		string
  msg { get; set; }


}
}
