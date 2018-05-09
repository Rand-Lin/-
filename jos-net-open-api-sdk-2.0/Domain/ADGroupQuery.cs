using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class ADGroupQuery : JdObject{


         [XmlElement("feeStr")]
public  		string
  feeStr { get; set; }


         [XmlElement("outerFeeStr")]
public  		string
  outerFeeStr { get; set; }


         [XmlElement("inSearchFee")]
public  		long
  inSearchFee { get; set; }


         [XmlElement("name")]
public  		string
  name { get; set; }


         [XmlElement("area")]
public  		string
  area { get; set; }


         [XmlElement("areaId")]
public  		string
  areaId { get; set; }


         [XmlElement("groupDirection")]
public  		string
  groupDirection { get; set; }


         [XmlElement("position")]
public  		string
  position { get; set; }


         [XmlElement("billingType")]
public  		int
  billingType { get; set; }


         [XmlElement("status")]
public  		int
  status { get; set; }


         [XmlElement("pin")]
public  		string
  pin { get; set; }


}
}
