using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class OrderDefaultResult : JdObject{


         [XmlElement("eclpSoNo")]
public  		string
  eclpSoNo { get; set; }


         [XmlElement("isvUUID")]
public  		string
  isvUUID { get; set; }


         [XmlElement("wayBill")]
public  		string
  wayBill { get; set; }


         [XmlElement("shipperNo")]
public  		string
  shipperNo { get; set; }


         [XmlElement("shipperName")]
public  		string
  shipperName { get; set; }


         [XmlElement("packCount")]
public  		string
  packCount { get; set; }


         [XmlElement("orderPackageList")]
public  		List<string>
  orderPackageList { get; set; }


}
}
