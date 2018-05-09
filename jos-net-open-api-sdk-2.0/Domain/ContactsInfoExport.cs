using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class ContactsInfoExport : JdObject{


         [XmlElement("addressInfoExport")]
public  		string
  addressInfoExport { get; set; }


         [XmlElement("contactsName")]
public  		string
  contactsName { get; set; }


         [XmlElement("contactsTel")]
public  		string
  contactsTel { get; set; }


         [XmlElement("contactsPhone")]
public  		string
  contactsPhone { get; set; }


         [XmlElement("contactsZipCode")]
public  		string
  contactsZipCode { get; set; }


}
}
