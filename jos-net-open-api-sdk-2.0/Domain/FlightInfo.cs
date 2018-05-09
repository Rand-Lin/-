using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class FlightInfo : JdObject{


         [XmlElement("airways")]
public  		string
  airways { get; set; }


         [XmlElement("airwaysCn")]
public  		string
  airwaysCn { get; set; }


         [XmlElement("arrAirdrome")]
public  		string
  arrAirdrome { get; set; }


         [XmlElement("arrCity")]
public  		string
  arrCity { get; set; }


         [XmlElement("arrCityCn")]
public  		string
  arrCityCn { get; set; }


         [XmlElement("arrDate")]
public  		string
  arrDate { get; set; }


         [XmlElement("arrTerminal")]
public  		string
  arrTerminal { get; set; }


         [XmlElement("arrTime")]
public  		string
  arrTime { get; set; }


         [XmlElement("asr")]
public  		string
  asr { get; set; }


         [XmlElement("carrier")]
public  		string
  carrier { get; set; }


         [XmlElement("carrierCn")]
public  		string
  carrierCn { get; set; }


         [XmlElement("childfee")]
public  		string
  childfee { get; set; }


         [XmlElement("bingoClassInfoList")]
public  		List<string>
  bingoClassInfoList { get; set; }


         [XmlElement("depAirdrome")]
public  		string
  depAirdrome { get; set; }


         [XmlElement("depCity")]
public  		string
  depCity { get; set; }


         [XmlElement("depCityCn")]
public  		string
  depCityCn { get; set; }


         [XmlElement("depDate")]
public  		string
  depDate { get; set; }


         [XmlElement("depTerminal")]
public  		string
  depTerminal { get; set; }


         [XmlElement("depTime")]
public  		string
  depTime { get; set; }


         [XmlElement("depTimeType")]
public  		string
  depTimeType { get; set; }


         [XmlElement("addDay")]
public  		string
  addDay { get; set; }


         [XmlElement("discountCN")]
public  		string
  discountCN { get; set; }


         [XmlElement("earningLevel")]
public  		string
  earningLevel { get; set; }


         [XmlElement("earningTitle")]
public  		string
  earningTitle { get; set; }


         [XmlElement("eticket")]
public  		string
  eticket { get; set; }


         [XmlElement("fee")]
public  		string
  fee { get; set; }


         [XmlElement("flightNo")]
public  		string
  flightNo { get; set; }


         [XmlElement("fullPrice")]
public  		string
  fullPrice { get; set; }


         [XmlElement("isCodeShare")]
public  		string
  isCodeShare { get; set; }


         [XmlElement("isStop")]
public  		string
  isStop { get; set; }


         [XmlElement("bingoLeastClassInfo")]
public  		string
  bingoLeastClassInfo { get; set; }


         [XmlElement("meal")]
public  		string
  meal { get; set; }


         [XmlElement("milage")]
public  		string
  milage { get; set; }


         [XmlElement("minDiscount")]
public  		string
  minDiscount { get; set; }


         [XmlElement("minPrice")]
public  		string
  minPrice { get; set; }


         [XmlElement("oldminPrice")]
public  		string
  oldminPrice { get; set; }


         [XmlElement("planeStyle")]
public  		string
  planeStyle { get; set; }


         [XmlElement("planeStyleCN")]
public  		string
  planeStyleCN { get; set; }


         [XmlElement("planeStyleType")]
public  		string
  planeStyleType { get; set; }


         [XmlElement("shareFlightNo")]
public  		string
  shareFlightNo { get; set; }


         [XmlElement("tax")]
public  		string
  tax { get; set; }


         [XmlElement("yseatPrice")]
public  		string
  yseatPrice { get; set; }


         [XmlElement("adultFareBasis")]
public  		string
  adultFareBasis { get; set; }


         [XmlElement("agentFee")]
public  		string
  agentFee { get; set; }


         [XmlElement("agentFeeGo")]
public  		string
  agentFeeGo { get; set; }


         [XmlElement("avItemTax")]
public  		string
  avItemTax { get; set; }


         [XmlElement("basicCabinRef")]
public  		string
  basicCabinRef { get; set; }


         [XmlElement("childOilTax")]
public  		string
  childOilTax { get; set; }


         [XmlElement("childPrice")]
public  		string
  childPrice { get; set; }


         [XmlElement("childfarebasis")]
public  		string
  childfarebasis { get; set; }


         [XmlElement("classNo")]
public  		string
  classNo { get; set; }


         [XmlElement("classNoCn")]
public  		string
  classNoCn { get; set; }


         [XmlElement("classLevel")]
public  		string
  classLevel { get; set; }


         [XmlElement("customerId")]
public  		long
  customerId { get; set; }


         [XmlElement("discount")]
public  		string
  discount { get; set; }


         [XmlElement("fareItemId")]
public  		string
  fareItemId { get; set; }


         [XmlElement("fareItemIdforTMC")]
public  		string
  fareItemIdforTMC { get; set; }


         [XmlElement("fareItemType")]
public  		string
  fareItemType { get; set; }


         [XmlElement("fareOfficeNo")]
public  		string
  fareOfficeNo { get; set; }


         [XmlElement("fareReference")]
public  		string
  fareReference { get; set; }


         [XmlElement("fareType")]
public  		string
  fareType { get; set; }


         [XmlElement("fareTypeforTMC")]
public  		string
  fareTypeforTMC { get; set; }


         [XmlElement("fcClassType")]
public  		string
  fcClassType { get; set; }


         [XmlElement("iOilTax")]
public  		string
  iOilTax { get; set; }


         [XmlElement("label")]
public  		string
  label { get; set; }


         [XmlElement("netChildPrice")]
public  		string
  netChildPrice { get; set; }


         [XmlElement("netPrice")]
public  		string
  netPrice { get; set; }


         [XmlElement("newMinPrice")]
public  		string
  newMinPrice { get; set; }


         [XmlElement("oilTax")]
public  		string
  oilTax { get; set; }


         [XmlElement("oldDiscount")]
public  		string
  oldDiscount { get; set; }


         [XmlElement("oldprice")]
public  		string
  oldprice { get; set; }


         [XmlElement("pat")]
public  		string
  pat { get; set; }


         [XmlElement("price")]
public  		string
  price { get; set; }


         [XmlElement("privilegeType")]
public  		string
  privilegeType { get; set; }


         [XmlElement("rtDiscount")]
public  		string
  rtDiscount { get; set; }


         [XmlElement("seatCodeEX")]
public  		string
  seatCodeEX { get; set; }


         [XmlElement("seatNum")]
public  		string
  seatNum { get; set; }


         [XmlElement("selfDiscountInfoId")]
public  		string
  selfDiscountInfoId { get; set; }


         [XmlElement("ySeatNum")]
public  		string
  ySeatNum { get; set; }


         [XmlElement("zvItemId")]
public  		string
  zvItemId { get; set; }


         [XmlElement("zvItemIdGo")]
public  		string
  zvItemIdGo { get; set; }


         [XmlElement("stopCity")]
public  		string
  stopCity { get; set; }


         [XmlElement("ticketBack")]
public  		string
  ticketBack { get; set; }


         [XmlElement("ticketChange")]
public  		string
  ticketChange { get; set; }


         [XmlElement("ticketTurn")]
public  		string
  ticketTurn { get; set; }


         [XmlElement("classFullPrice")]
public  		long
  classFullPrice { get; set; }


         [XmlElement("originalMinPrice")]
public  		string
  originalMinPrice { get; set; }


         [XmlElement("originalPrice")]
public  		string
  originalPrice { get; set; }


         [XmlElement("discountFlag")]
public  		string
  discountFlag { get; set; }


         [XmlElement("discountType")]
public  		string
  discountType { get; set; }


         [XmlElement("discountId")]
public  		string
  discountId { get; set; }


         [XmlElement("sourceId")]
public  		string
  sourceId { get; set; }


         [XmlElement("promotionId")]
public  		string
  promotionId { get; set; }


         [XmlElement("promotionPrice")]
public  		string
  promotionPrice { get; set; }


         [XmlElement("venderPrice")]
public  		string
  venderPrice { get; set; }


         [XmlElement("checkContent")]
public  		string
  checkContent { get; set; }


         [XmlElement("commisionPoint")]
public  		string
  commisionPoint { get; set; }


         [XmlElement("policyId")]
public  		string
  policyId { get; set; }


         [XmlElement("childVenderPrice")]
public  		string
  childVenderPrice { get; set; }


         [XmlElement("childSalePrice")]
public  		string
  childSalePrice { get; set; }


         [XmlElement("childSeatCode")]
public  		string
  childSeatCode { get; set; }


         [XmlElement("beforeDiscount")]
public  		string
  beforeDiscount { get; set; }


         [XmlElement("afterDiscount")]
public  		string
  afterDiscount { get; set; }


         [XmlElement("ticketProvisions")]
public  		string
  ticketProvisions { get; set; }


         [XmlElement("childDiscount")]
public  		string
  childDiscount { get; set; }


         [XmlElement("airchinaTripId")]
public  		string
  airchinaTripId { get; set; }


         [XmlElement("enterDiscount")]
public  		string
  enterDiscount { get; set; }


         [XmlElement("islimit2HoursFlight")]
public  		string
  islimit2HoursFlight { get; set; }


         [XmlElement("saleDiscountType")]
public  		string
  saleDiscountType { get; set; }


         [XmlElement("flightPriceSort")]
public  		string
  flightPriceSort { get; set; }


         [XmlElement("promotionType")]
public  		string
  promotionType { get; set; }


         [XmlElement("index")]
public  		string
  index { get; set; }


         [XmlElement("maxDiscountMoney")]
public  		string
  maxDiscountMoney { get; set; }


         [XmlElement("showFlag")]
public  		string
  showFlag { get; set; }


         [XmlElement("airCompanyDataFlag")]
public  		string
  airCompanyDataFlag { get; set; }


         [XmlElement("productCode")]
public  		string
  productCode { get; set; }


         [XmlElement("markingPromotion")]
public  		string
  markingPromotion { get; set; }


}
}
