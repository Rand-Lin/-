using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class HashMap : JdObject{


         [XmlElement("order_list")]
public  		List<string>
  orderList { get; set; }


}
}
