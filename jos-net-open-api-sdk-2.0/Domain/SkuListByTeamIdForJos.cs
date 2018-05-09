using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class SkuListByTeamIdForJos : JdObject{


         [XmlElement("sku_list")]
public  		List<string>
  skuList { get; set; }


         [XmlElement("result_code")]
public  		string
  resultCode { get; set; }


}
}
