using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class TraceApiDto : JdObject{


         [XmlElement("ope_title")]
public  		string
  opeTitle { get; set; }


         [XmlElement("ope_remark")]
public  		string
  opeRemark { get; set; }


         [XmlElement("ope_name")]
public  		string
  opeName { get; set; }


         [XmlElement("ope_time")]
public  		string
  opeTime { get; set; }


}
}
