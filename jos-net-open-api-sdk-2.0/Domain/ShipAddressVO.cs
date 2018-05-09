using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class ShipAddressVO : JdObject{


         [XmlElement("id")]
public  		long
  id { get; set; }


         [XmlElement("contact")]
public  		string
  contact { get; set; }


         [XmlElement("phone")]
public  		string
  phone { get; set; }


         [XmlElement("zip_code")]
public  		string
  zipCode { get; set; }


         [XmlElement("full_address")]
public  		string
  fullAddress { get; set; }


         [XmlElement("full_area_id")]
public  		string
  fullAreaId { get; set; }


         [XmlElement("default_address_flag")]
public  		string
  defaultAddressFlag { get; set; }


         [XmlElement("create_time")]
public  		DateTime
  createTime { get; set; }


         [XmlElement("modify_time")]
public  		DateTime
  modifyTime { get; set; }


}
}
