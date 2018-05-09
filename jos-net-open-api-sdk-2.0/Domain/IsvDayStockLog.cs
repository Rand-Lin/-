using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class IsvDayStockLog : JdObject{


         [XmlElement("goodsNo")]
public  		string
  goodsNo { get; set; }


         [XmlElement("goodsName")]
public  		string
  goodsName { get; set; }


         [XmlElement("deptNo")]
public  		string
  deptNo { get; set; }


         [XmlElement("warehouseNo")]
public  		string
  warehouseNo { get; set; }


         [XmlElement("purchaseInstoreNum")]
public  		string
  purchaseInstoreNum { get; set; }


         [XmlElement("orderOutstoreNum")]
public  		string
  orderOutstoreNum { get; set; }


         [XmlElement("returnInstoreNum")]
public  		string
  returnInstoreNum { get; set; }


         [XmlElement("returnOutstoreNum")]
public  		string
  returnOutstoreNum { get; set; }


         [XmlElement("stockOverNum")]
public  		string
  stockOverNum { get; set; }


         [XmlElement("stockShortNum")]
public  		string
  stockShortNum { get; set; }


}
}
