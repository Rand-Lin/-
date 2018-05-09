using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class FlightClassInfo : JdObject{


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


         [XmlElement("childSeatCode")]
public  		string
  childSeatCode { get; set; }


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


         [XmlElement("venderPrice")]
public  		string
  venderPrice { get; set; }


         [XmlElement("sourceId")]
public  		string
  sourceId { get; set; }


         [XmlElement("promotionId")]
public  		string
  promotionId { get; set; }


         [XmlElement("checkContent")]
public  		string
  checkContent { get; set; }


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


         [XmlElement("fullPrice")]
public  		string
  fullPrice { get; set; }


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


         [XmlElement("policyId")]
public  		string
  policyId { get; set; }


         [XmlElement("commisionPoint")]
public  		string
  commisionPoint { get; set; }


         [XmlElement("childVenderPrice")]
public  		string
  childVenderPrice { get; set; }


         [XmlElement("childSalePrice")]
public  		string
  childSalePrice { get; set; }


         [XmlElement("promotionPrice")]
public  		string
  promotionPrice { get; set; }


         [XmlElement("isfirstShow")]
public  		string
  isfirstShow { get; set; }


         [XmlElement("saleDiscountMap")]
public  		string
  saleDiscountMap { get; set; }


         [XmlElement("promotionInfo")]
public  		string
  promotionInfo { get; set; }


         [XmlElement("orderByPrice")]
public  		string
  orderByPrice { get; set; }


         [XmlElement("airCompanyFlag")]
public  		string
  airCompanyFlag { get; set; }


         [XmlElement("leastClassInfoFlag")]
public  		string
  leastClassInfoFlag { get; set; }


         [XmlElement("productCode")]
public  		string
  productCode { get; set; }


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


         [XmlElement("tripId")]
public  		string
  tripId { get; set; }


         [XmlElement("index")]
public  		string
  index { get; set; }


}
}
