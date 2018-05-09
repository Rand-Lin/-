using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class OrderResultDto : JdObject{


         [XmlElement("pageIndex")]
public  		int
  pageIndex { get; set; }


         [XmlElement("pageSize")]
public  		int
  pageSize { get; set; }


         [XmlElement("recordCount")]
public  		int
  recordCount { get; set; }


         [XmlElement("totalPage")]
public  		int
  totalPage { get; set; }


         [XmlElement("purchaseOrderList")]
public  		List<string>
  purchaseOrderList { get; set; }


}
}
