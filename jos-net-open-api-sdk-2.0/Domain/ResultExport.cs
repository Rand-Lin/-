using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class ResultExport : JdObject{


         [XmlElement("resultCode")]
public  		string
  resultCode { get; set; }


         [XmlElement("data")]
public  		string
  data { get; set; }


         [XmlElement("errMsg")]
public  		string
  errMsg { get; set; }


}
}
