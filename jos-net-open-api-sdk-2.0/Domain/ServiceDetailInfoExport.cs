using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class ServiceDetailInfoExport : JdObject{


         [XmlElement("wareId")]
public  		int
  wareId { get; set; }


         [XmlElement("wareName")]
public  		string
  wareName { get; set; }


         [XmlElement("wareBrand")]
public  		string
  wareBrand { get; set; }


         [XmlElement("afsDetailType")]
public  		int
  afsDetailType { get; set; }


         [XmlElement("wareDescribe")]
public  		string
  wareDescribe { get; set; }


         [XmlElement("wareCid1")]
public  		int
  wareCid1 { get; set; }


         [XmlElement("wareCid2")]
public  		int
  wareCid2 { get; set; }


         [XmlElement("wareCid3")]
public  		int
  wareCid3 { get; set; }


         [XmlElement("payPrice")]
public  		string
  payPrice { get; set; }


}
}
