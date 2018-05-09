using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class TemplateNoteDto : JdObject{


         [XmlElement("template_id")]
public  		int
  templateId { get; set; }


         [XmlElement("id")]
public  		int
  id { get; set; }


}
}
