using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class VenderRemarkQueryResult : JdObject{


         [XmlElement("api_jos_result")]
public  		string
  apiJosResult { get; set; }


         [XmlElement("vender_remark")]
public  		string
  venderRemark { get; set; }


}
}
