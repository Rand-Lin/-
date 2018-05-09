using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class DspDayForeCast : JdObject{


         [XmlElement("day")]
public  		int
  day { get; set; }


         [XmlElement("price")]
public  		string
  price { get; set; }


}
}
