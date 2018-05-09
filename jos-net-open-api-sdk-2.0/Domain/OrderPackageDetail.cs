using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class OrderPackageDetail : JdObject{


         [XmlElement("weight")]
public  		string
  weight { get; set; }


         [XmlElement("delivery_no")]
public  		string
  deliveryNo { get; set; }


         [XmlElement("carriers_id")]
public  		string
  carriersId { get; set; }


         [XmlElement("carriers_name")]
public  		string
  carriersName { get; set; }


}
}
