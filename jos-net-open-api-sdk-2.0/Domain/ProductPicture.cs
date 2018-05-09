using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class ProductPicture : JdObject{


         [XmlElement("pictureNum")]
public  		int
  pictureNum { get; set; }


         [XmlElement("pictureName")]
public  		string
  pictureName { get; set; }


         [XmlElement("pictureUrl")]
public  		string
  pictureUrl { get; set; }


         [XmlElement("jdPictureUrl")]
public  		string
  jdPictureUrl { get; set; }


}
}
