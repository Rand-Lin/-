using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class PopVenderCenerVenderBrandQueryResponse : JdResponse{


         [XmlElement("brandList")]
public  		List<string>
  brandList { get; set; }


}
}
