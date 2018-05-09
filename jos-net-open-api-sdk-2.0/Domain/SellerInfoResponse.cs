using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class SellerInfoResponse : JdObject{


         [XmlElement("sellerNo")]
public  		string
  sellerNo { get; set; }


         [XmlElement("shopWarehouseInfoList")]
public  		List<string>
  shopWarehouseInfoList { get; set; }


}
}
