using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class ServicePageExport : JdObject{


         [XmlElement("totalNum")]
public  		string
  totalNum { get; set; }


         [XmlElement("pageSize")]
public  		int
  pageSize { get; set; }


         [XmlElement("pageNumer")]
public  		int
  pageNumer { get; set; }


         [XmlElement("serviceExportList")]
public  		List<string>
  serviceExportList { get; set; }


}
}
