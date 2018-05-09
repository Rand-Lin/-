using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class CategoryBasicInfo : JdObject{


         [XmlElement("group_id")]
public  		string
  groupId { get; set; }


         [XmlElement("group_name")]
public  		string
  groupName { get; set; }


         [XmlElement("group_letter")]
public  		string
  groupLetter { get; set; }


         [XmlElement("sort_order")]
public  		string
  sortOrder { get; set; }


         [XmlElement("feature")]
public  		string
  feature { get; set; }


}
}
