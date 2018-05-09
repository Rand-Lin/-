using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class ItemPicApplyDto : JdObject{


         [XmlElement("apply_id")]
public  		string
  applyId { get; set; }


         [XmlElement("yn")]
public  		string
  yn { get; set; }


         [XmlElement("state")]
public  		int
  state { get; set; }


         [XmlElement("create_by")]
public  		string
  createBy { get; set; }


         [XmlElement("modify_by")]
public  		string
  modifyBy { get; set; }


         [XmlElement("create_time")]
public  		string
  createTime { get; set; }


         [XmlElement("modify_time")]
public  		string
  modifyTime { get; set; }


         [XmlElement("apply_time")]
public  		string
  applyTime { get; set; }


         [XmlElement("ware_id")]
public  		string
  wareId { get; set; }


         [XmlElement("name")]
public  		string
  name { get; set; }


         [XmlElement("brand_id")]
public  		int
  brandId { get; set; }


         [XmlElement("category_id")]
public  		int
  categoryId { get; set; }


         [XmlElement("vendor_code")]
public  		string
  vendorCode { get; set; }


         [XmlElement("image_path_list")]
public  		List<string>
  imagePathList { get; set; }


         [XmlElement("pid")]
public  		string
  pid { get; set; }


         [XmlElement("brand_name")]
public  		string
  brandName { get; set; }


         [XmlElement("sale_state")]
public  		int
  saleState { get; set; }


         [XmlElement("category_name")]
public  		string
  categoryName { get; set; }


         [XmlElement("sale_state_name")]
public  		string
  saleStateName { get; set; }


         [XmlElement("state_name")]
public  		string
  stateName { get; set; }


         [XmlElement("task_id")]
public  		string
  taskId { get; set; }


}
}
