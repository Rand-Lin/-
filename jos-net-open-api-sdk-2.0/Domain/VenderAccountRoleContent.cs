using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class VenderAccountRoleContent : JdObject{


         [XmlElement("account_name")]
public  		string
  accountName { get; set; }


         [XmlElement("role_id")]
public  		long
  roleId { get; set; }


         [XmlElement("role_name")]
public  		string
  roleName { get; set; }


}
}
