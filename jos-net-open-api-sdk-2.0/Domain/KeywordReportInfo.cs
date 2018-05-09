using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class KeywordReportInfo : JdObject{


         [XmlElement("keywordName")]
public  		string
  keywordName { get; set; }


         [XmlElement("type")]
public  		string
  type { get; set; }


         [XmlElement("display")]
public  		string
  display { get; set; }


         [XmlElement("click")]
public  		string
  click { get; set; }


         [XmlElement("ctr")]
public  		string
  ctr { get; set; }


         [XmlElement("cost")]
public  		string
  cost { get; set; }


         [XmlElement("tdCost")]
public  		string
  tdCost { get; set; }


         [XmlElement("acCost")]
public  		string
  acCost { get; set; }


         [XmlElement("keywordPrice")]
public  		double
  keywordPrice { get; set; }


         [XmlElement("keywordPriceWireless")]
public  		double
  keywordPriceWireless { get; set; }


         [XmlElement("keywordPriceSem")]
public  		double
  keywordPriceSem { get; set; }


}
}
