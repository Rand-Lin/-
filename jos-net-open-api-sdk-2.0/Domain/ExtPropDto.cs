using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class ExtPropDto : JdObject{


         [XmlElement("att_Id")]
public  		int
  attId { get; set; }


         [XmlElement("name")]
public  		string
  name { get; set; }


         [XmlElement("cid")]
public  		int
  cid { get; set; }


         [XmlElement("cata_class")]
public  		int
  cataClass { get; set; }


         [XmlElement("type")]
public  		int
  type { get; set; }


         [XmlElement("order_sort")]
public  		int
  orderSort { get; set; }


         [XmlElement("is_required")]
public  		int
  isRequired { get; set; }


         [XmlElement("is_shield")]
public  		int
  isShield { get; set; }


         [XmlElement("is_search")]
public  		int
  isSearch { get; set; }


         [XmlElement("is_keyProperty")]
public  		int
  isKeyProperty { get; set; }


         [XmlElement("is_custom")]
public  		int
  isCustom { get; set; }


         [XmlElement("is_multiSele")]
public  		int
  isMultiSele { get; set; }


         [XmlElement("col_num")]
public  		int
  colNum { get; set; }


         [XmlElement("yn")]
public  		int
  yn { get; set; }


         [XmlElement("group_id")]
public  		int
  groupId { get; set; }


         [XmlElement("ext_prop_value")]
public  		List<string>
  extPropValue { get; set; }


}
}
