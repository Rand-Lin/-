using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class AfsserviceFreightUpdateResponse : JdResponse{


         [XmlElement("afsFreightUpdateResult")]
public  		string
  afsFreightUpdateResult { get; set; }


}
}
