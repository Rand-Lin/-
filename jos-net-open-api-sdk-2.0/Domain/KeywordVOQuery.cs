using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class KeywordVOQuery : JdObject{


         [XmlElement("keywordName")]
public  		string
  keywordName { get; set; }


         [XmlElement("searchCount")]
public  		string
  searchCount { get; set; }


}
}
