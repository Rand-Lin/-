using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class Feature : JdObject{


         [XmlElement("featureCn")]
public  		string
  featureCn { get; set; }


         [XmlElement("featureKey")]
public  		string
  featureKey { get; set; }


         [XmlElement("featureValue")]
public  		string
  featureValue { get; set; }


}
}
