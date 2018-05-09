using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class QueryPoModel : JdObject{


         [XmlElement("poOrderNo")]
public  		string
  poOrderNo { get; set; }


         [XmlElement("isvPoOrderNo")]
public  		string
  isvPoOrderNo { get; set; }


         [XmlElement("deptNo")]
public  		string
  deptNo { get; set; }


         [XmlElement("whNo")]
public  		string
  whNo { get; set; }


         [XmlElement("supplierNo")]
public  		string
  supplierNo { get; set; }


         [XmlElement("createUser")]
public  		string
  createUser { get; set; }


         [XmlElement("poOrderStatus")]
public  		string
  poOrderStatus { get; set; }


         [XmlElement("createTime")]
public  		string
  createTime { get; set; }


         [XmlElement("storageStatus")]
public  		string
  storageStatus { get; set; }


         [XmlElement("poItemModelList")]
public  		List<string>
  poItemModelList { get; set; }


         [XmlElement("resultCode")]
public  		string
  resultCode { get; set; }


         [XmlElement("msg")]
public  		string
  msg { get; set; }


}
}
