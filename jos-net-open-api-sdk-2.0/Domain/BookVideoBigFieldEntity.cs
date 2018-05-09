using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class BookVideoBigFieldEntity : JdObject{


         [XmlElement("sku_id")]
public  		long
  skuId { get; set; }


         [XmlElement("first_class_id")]
public  		int
  firstClassId { get; set; }


         [XmlElement("book_big_field_info")]
public  		string
  bookBigFieldInfo { get; set; }


}
}
