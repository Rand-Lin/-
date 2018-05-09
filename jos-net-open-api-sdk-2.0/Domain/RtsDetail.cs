using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class RtsDetail : JdObject{


         [XmlElement("deptGoodsNo")]
public  		string
  deptGoodsNo { get; set; }


         [XmlElement("goodsName")]
public  		string
  goodsName { get; set; }


         [XmlElement("quantity")]
public  		string
  quantity { get; set; }


         [XmlElement("realQuantity")]
public  		string
  realQuantity { get; set; }


         [XmlElement("goodsStatus")]
public  		string
  goodsStatus { get; set; }


}
}
