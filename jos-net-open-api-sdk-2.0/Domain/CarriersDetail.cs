using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class CarriersDetail : JdObject{


         [XmlElement("carriers_id")]
public  		string
  carriersId { get; set; }


         [XmlElement("carriers_name")]
public  		string
  carriersName { get; set; }


         [XmlElement("carriers_phone")]
public  		string
  carriersPhone { get; set; }


}
}
