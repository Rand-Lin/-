using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class ResponseOrderOtherDetail : JdObject{


         [XmlElement("josl_good_no")]
public  		string
  joslGoodNo { get; set; }


         [XmlElement("isv_good_no")]
public  		string
  isvGoodNo { get; set; }


         [XmlElement("qty")]
public  		int
  qty { get; set; }


         [XmlElement("goods_status")]
public  		string
  goodsStatus { get; set; }


         [XmlElement("difference_remark")]
public  		string
  differenceRemark { get; set; }


         [XmlElement("barCode")]
public  		string
  barCode { get; set; }


}
}
