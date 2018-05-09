using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class OrderDetail : JdObject{


         [XmlElement("goodsNo")]
public  		string
  goodsNo { get; set; }


         [XmlElement("price")]
public  		double
  price { get; set; }


         [XmlElement("quantity")]
public  		int
  quantity { get; set; }


}
}
