using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class EtmsWaybillSendResponse : JdResponse{


         [XmlElement("resultInfo")]
public  		string
  resultInfo { get; set; }


}
}
