using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class StockBillDetail : JdObject{


         [XmlElement("sku_id")]
public  		long
  skuId { get; set; }


         [XmlElement("ware_id")]
public  		long
  wareId { get; set; }


         [XmlElement("price")]
public  		double
  price { get; set; }


         [XmlElement("apply_num")]
public  		long
  applyNum { get; set; }


         [XmlElement("apply_money")]
public  		double
  applyMoney { get; set; }


         [XmlElement("real_num")]
public  		long
  realNum { get; set; }


         [XmlElement("real_money")]
public  		double
  realMoney { get; set; }


         [XmlElement("remark")]
public  		string
  remark { get; set; }


         [XmlElement("title")]
public  		string
  title { get; set; }


         [XmlElement("attributes")]
public  		string
  attributes { get; set; }


}
}
