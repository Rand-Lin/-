using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class TeamArealistGetResponse : JdResponse{


         [XmlElement("area_list_for_jos")]
public  		string
  areaListForJos { get; set; }


}
}
