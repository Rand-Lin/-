using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class WareDetailPicturesVO : JdObject{


         [XmlElement("wareId")]
public  		long
  wareId { get; set; }


         [XmlElement("indexId")]
public  		int
  indexId { get; set; }


         [XmlElement("imgURL")]
public  		string
  imgURL { get; set; }


         [XmlElement("status")]
public  		int
  status { get; set; }


}
}
