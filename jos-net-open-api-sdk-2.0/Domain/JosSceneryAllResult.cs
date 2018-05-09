using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class JosSceneryAllResult : JdObject{


         [XmlElement("jingdianName")]
public  		string
  jingdianName { get; set; }


         [XmlElement("nameEntireEn")]
public  		string
  nameEntireEn { get; set; }


         [XmlElement("nameSimpleEn")]
public  		string
  nameSimpleEn { get; set; }


         [XmlElement("jingdianSubject")]
public  		int
  jingdianSubject { get; set; }


         [XmlElement("jingdianGrade")]
public  		int
  jingdianGrade { get; set; }


         [XmlElement("jingdianOpentimeDesc")]
public  		string
  jingdianOpentimeDesc { get; set; }


         [XmlElement("jingdianTelephone")]
public  		string
  jingdianTelephone { get; set; }


         [XmlElement("countryId")]
public  		int
  countryId { get; set; }


         [XmlElement("provinceId")]
public  		int
  provinceId { get; set; }


         [XmlElement("cityId")]
public  		int
  cityId { get; set; }


         [XmlElement("areaId")]
public  		int
  areaId { get; set; }


         [XmlElement("addressDesc")]
public  		string
  addressDesc { get; set; }


         [XmlElement("jingdianDesc")]
public  		string
  jingdianDesc { get; set; }


         [XmlElement("jingdianOneCategoryId")]
public  		int
  jingdianOneCategoryId { get; set; }


         [XmlElement("jingdianTwoCategoryId")]
public  		int
  jingdianTwoCategoryId { get; set; }


         [XmlElement("jingdianThreeCategoryId")]
public  		int
  jingdianThreeCategoryId { get; set; }


         [XmlElement("jingdianFourCategoryId")]
public  		int
  jingdianFourCategoryId { get; set; }


         [XmlElement("chargeItemListJson")]
public  		string
  chargeItemListJson { get; set; }


         [XmlElement("pictureListJson")]
public  		string
  pictureListJson { get; set; }


         [XmlElement("jingdianStatus")]
public  		int
  jingdianStatus { get; set; }


         [XmlElement("success")]
public  		string
  success { get; set; }


         [XmlElement("errorCode")]
public  		string
  errorCode { get; set; }


         [XmlElement("errorMessage")]
public  		string
  errorMessage { get; set; }


}
}
