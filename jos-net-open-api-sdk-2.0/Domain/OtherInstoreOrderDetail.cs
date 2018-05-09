using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class OtherInstoreOrderDetail : JdObject{


         [XmlElement("goods_no")]
public  		string
  goodsNo { get; set; }


         [XmlElement("difference_remark")]
public  		string
  differenceRemark { get; set; }


         [XmlElement("qty")]
public  		int
  qty { get; set; }


         [XmlElement("goods_status")]
public  		string
  goodsStatus { get; set; }


}
}
