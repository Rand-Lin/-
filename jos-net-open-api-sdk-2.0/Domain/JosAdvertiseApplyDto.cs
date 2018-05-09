using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class JosAdvertiseApplyDto : JdObject{


         [XmlElement("applyId")]
public  		string
  applyId { get; set; }


         [XmlElement("state")]
public  		int
  state { get; set; }


         [XmlElement("applyTime")]
public  		DateTime
  applyTime { get; set; }


         [XmlElement("productInfo")]
public  		string
  productInfo { get; set; }


}
}
