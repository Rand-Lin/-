using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class PublicResultObjectRefundInfo : JdObject{


         [XmlElement("resultCode")]
public  		int
  resultCode { get; set; }


         [XmlElement("resultErrorMsg")]
public  		string
  resultErrorMsg { get; set; }


         [XmlElement("afsRefundInfoOut")]
public  		string
  afsRefundInfoOut { get; set; }


}
}
