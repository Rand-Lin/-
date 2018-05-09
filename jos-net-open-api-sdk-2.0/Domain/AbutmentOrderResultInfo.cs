using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class AbutmentOrderResultInfo : JdObject{


         [XmlElement("isAuthorized")]
public  		string
  isAuthorized { get; set; }


         [XmlElement("factoryAbutmentOrderDealInfoList")]
public  		List<string>
  factoryAbutmentOrderDealInfoList { get; set; }


         [XmlElement("errorMessage")]
public  		string
  errorMessage { get; set; }


}
}
