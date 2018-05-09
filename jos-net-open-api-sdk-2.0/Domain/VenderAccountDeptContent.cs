using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class VenderAccountDeptContent : JdObject{


         [XmlElement("account_name")]
public  		string
  accountName { get; set; }


         [XmlElement("dept_id")]
public  		long
  deptId { get; set; }


         [XmlElement("dept_name")]
public  		string
  deptName { get; set; }


         [XmlElement("level")]
public  		int
  level { get; set; }


         [XmlElement("parent_dept_id")]
public  		long
  parentDeptId { get; set; }


}
}
