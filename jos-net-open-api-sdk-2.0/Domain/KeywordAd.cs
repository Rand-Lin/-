using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class KeywordAd : JdObject{


         [XmlElement("keywords")]
public  		string
  keywords { get; set; }


         [XmlElement("type")]
public  		string
  type { get; set; }


         [XmlElement("adImpressions")]
public  		long
  adImpressions { get; set; }


         [XmlElement("adClicks")]
public  		long
  adClicks { get; set; }


         [XmlElement("ctr")]
public  		string
  ctr { get; set; }


         [XmlElement("cost")]
public  		string
  cost { get; set; }


         [XmlElement("cpm")]
public  		string
  cpm { get; set; }


         [XmlElement("cpc")]
public  		string
  cpc { get; set; }


}
}
