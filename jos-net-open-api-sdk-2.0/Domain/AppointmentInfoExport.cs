using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class AppointmentInfoExport : JdObject{


         [XmlElement("appointDateBegin")]
public  		DateTime
  appointDateBegin { get; set; }


         [XmlElement("appointDateEnd")]
public  		DateTime
  appointDateEnd { get; set; }


         [XmlElement("appointDateStr")]
public  		string
  appointDateStr { get; set; }


         [XmlElement("appointDateType")]
public  		string
  appointDateType { get; set; }


         [XmlElement("reserveDate")]
public  		DateTime
  reserveDate { get; set; }


         [XmlElement("sendPay")]
public  		string
  sendPay { get; set; }


}
}
