using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class DspFeaturedQuerylistResponse : JdResponse{


         [XmlElement("querylistbyparam_result")]
public  		string
  querylistbyparamResult { get; set; }


}
}
