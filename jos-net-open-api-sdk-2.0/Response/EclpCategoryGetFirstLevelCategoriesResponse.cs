using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class EclpCategoryGetFirstLevelCategoriesResponse : JdResponse{


         [XmlElement("categories")]
public  		List<string>
  categories { get; set; }


}
}
