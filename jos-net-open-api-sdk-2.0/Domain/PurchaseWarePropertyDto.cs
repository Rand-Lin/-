using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class PurchaseWarePropertyDto : JdObject{


         [XmlElement("wareId")]
public  		long
  wareId { get; set; }


         [XmlElement("chest")]
public  		double
  chest { get; set; }


         [XmlElement("waistline")]
public  		double
  waistline { get; set; }


         [XmlElement("hip")]
public  		double
  hip { get; set; }


         [XmlElement("dressLength")]
public  		double
  dressLength { get; set; }


         [XmlElement("height")]
public  		double
  height { get; set; }


         [XmlElement("color")]
public  		string
  color { get; set; }


         [XmlElement("mainPictureLink")]
public  		string
  mainPictureLink { get; set; }


}
}
