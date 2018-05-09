using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class JosStockSalesDetail : JdObject{


         [XmlElement("product_code")]
public  		string
  productCode { get; set; }


         [XmlElement("product_name")]
public  		string
  productName { get; set; }


         [XmlElement("stock_count")]
public  		long
  stockCount { get; set; }


         [XmlElement("sales")]
public  		long
  sales { get; set; }


}
}
