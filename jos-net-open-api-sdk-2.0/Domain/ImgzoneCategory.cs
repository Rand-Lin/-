using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class ImgzoneCategory : JdObject{


         [XmlElement("cate_id")]
public  		long
  cateId { get; set; }


         [XmlElement("cate_name")]
public  		string
  cateName { get; set; }


         [XmlElement("cate_level")]
public  		int
  cateLevel { get; set; }


         [XmlElement("parent_cate_id")]
public  		long
  parentCateId { get; set; }


         [XmlElement("cate_order")]
public  		int
  cateOrder { get; set; }


         [XmlElement("created")]
public  		DateTime
  created { get; set; }


         [XmlElement("modified")]
public  		DateTime
  modified { get; set; }


}
}
