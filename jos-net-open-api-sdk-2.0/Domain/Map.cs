using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class Map : JdObject{


         [XmlElement("sum_display")]
public  		string
  sumDisplay { get; set; }


         [XmlElement("sum_click")]
public  		string
  sumClick { get; set; }


         [XmlElement("sum_cost")]
public  		string
  sumCost { get; set; }


         [XmlElement("sum_ctr")]
public  		string
  sumCtr { get; set; }


         [XmlElement("sum_cpm")]
public  		string
  sumCpm { get; set; }


         [XmlElement("sum_cpc")]
public  		string
  sumCpc { get; set; }


         [XmlElement("sum_amount")]
public  		string
  sumAmount { get; set; }


         [XmlElement("sum_count")]
public  		string
  sumCount { get; set; }


         [XmlElement("sum_roi")]
public  		string
  sumRoi { get; set; }


         [XmlElement("sum_conversion")]
public  		string
  sumConversion { get; set; }


}
}
