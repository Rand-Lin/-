using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class AfsserviceAlltaskGetResponse : JdResponse{


         [XmlElement("publicResultObject")]
public  		string
  publicResultObject { get; set; }


}
}