using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class PartitionWarehouse : JdObject{


         [XmlElement("venderId")]
public  		string
  venderId { get; set; }


         [XmlElement("seq_num")]
public  		string
  seqNum { get; set; }


         [XmlElement("name")]
public  		string
  name { get; set; }


         [XmlElement("use_flag")]
public  		string
  useFlag { get; set; }


         [XmlElement("type")]
public  		string
  type { get; set; }


}
}
