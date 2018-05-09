using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class KeyWordRecommendQuery : JdObject{


         [XmlElement("keyWord")]
public  		string
  keyWord { get; set; }


         [XmlElement("pv")]
public  		long
  pv { get; set; }


         [XmlElement("avgBigPrice")]
public  		double
  avgBigPrice { get; set; }


         [XmlElement("starCount")]
public  		int
  starCount { get; set; }


         [XmlElement("sourceType")]
public  		int
  sourceType { get; set; }


}
}
