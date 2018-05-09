using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class ResponseOrderStatus : JdObject{


         [XmlElement("receipt_no")]
public  		string
  receiptNo { get; set; }


         [XmlElement("order_status_details")]
public  		List<string>
  orderStatusDetails { get; set; }


         [XmlElement("order_package_details")]
public  		List<string>
  orderPackageDetails { get; set; }


}
}
