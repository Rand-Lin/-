using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Jd.Api.Domain;
namespace Jd.Api.Domain
{





[Serializable]
public class ProductInfoDto : JdObject{


         [XmlElement("ware_id")]
public  		string
  wareId { get; set; }


         [XmlElement("name")]
public  		string
  name { get; set; }


         [XmlElement("model")]
public  		string
  model { get; set; }


         [XmlElement("original_place")]
public  		string
  originalPlace { get; set; }


         [XmlElement("upc")]
public  		string
  upc { get; set; }


         [XmlElement("packing")]
public  		int
  packing { get; set; }


         [XmlElement("sku_unit")]
public  		string
  skuUnit { get; set; }


         [XmlElement("pack_type")]
public  		int
  packType { get; set; }


         [XmlElement("pkg_info")]
public  		string
  pkgInfo { get; set; }


         [XmlElement("warranty")]
public  		string
  warranty { get; set; }


         [XmlElement("shelf_life")]
public  		int
  shelfLife { get; set; }


         [XmlElement("zh_brand")]
public  		string
  zhBrand { get; set; }


         [XmlElement("en_brand")]
public  		string
  enBrand { get; set; }


         [XmlElement("web_site")]
public  		string
  webSite { get; set; }


         [XmlElement("tel")]
public  		string
  tel { get; set; }


         [XmlElement("length")]
public  		int
  length { get; set; }


         [XmlElement("width")]
public  		int
  width { get; set; }


         [XmlElement("height")]
public  		int
  height { get; set; }


         [XmlElement("weight")]
public  		string
  weight { get; set; }


         [XmlElement("market_price")]
public  		string
  marketPrice { get; set; }


         [XmlElement("purchase_price")]
public  		string
  purchasePrice { get; set; }


         [XmlElement("member_price")]
public  		string
  memberPrice { get; set; }


         [XmlElement("brand_id")]
public  		int
  brandId { get; set; }


         [XmlElement("brand_name")]
public  		string
  brandName { get; set; }


         [XmlElement("cid1")]
public  		int
  cid1 { get; set; }


         [XmlElement("cid_name1")]
public  		string
  cidName1 { get; set; }


         [XmlElement("cid2")]
public  		int
  cid2 { get; set; }


         [XmlElement("cid_name2")]
public  		string
  cidName2 { get; set; }


         [XmlElement("saler_code")]
public  		string
  salerCode { get; set; }


         [XmlElement("saler_name")]
public  		string
  salerName { get; set; }


         [XmlElement("purchaser_code")]
public  		string
  purchaserCode { get; set; }


         [XmlElement("purchaser_name")]
public  		string
  purchaserName { get; set; }


         [XmlElement("vendor_code")]
public  		string
  vendorCode { get; set; }


         [XmlElement("vendor_name")]
public  		string
  vendorName { get; set; }


         [XmlElement("intro")]
public  		string
  intro { get; set; }


         [XmlElement("full_category_name1")]
public  		string
  fullCategoryName1 { get; set; }


         [XmlElement("full_category_name2")]
public  		string
  fullCategoryName2 { get; set; }


         [XmlElement("wreadme")]
public  		string
  wreadme { get; set; }


         [XmlElement("prop_infos")]
public  		List<string>
  propInfos { get; set; }


         [XmlElement("ext_prop_infos")]
public  		List<string>
  extPropInfos { get; set; }


         [XmlElement("intro_html")]
public  		string
  introHtml { get; set; }


         [XmlElement("intro_templates")]
public  		List<string>
  introTemplates { get; set; }


         [XmlElement("video_id")]
public  		long
  videoId { get; set; }


         [XmlElement("title")]
public  		string
  title { get; set; }


         [XmlElement("modify_time")]
public  		DateTime
  modifyTime { get; set; }


         [XmlElement("issn")]
public  		string
  issn { get; set; }


         [XmlElement("service")]
public  		string
  service { get; set; }


         [XmlElement("sales_ratio")]
public  		string
  salesRatio { get; set; }


         [XmlElement("aftersales")]
public  		string
  aftersales { get; set; }


         [XmlElement("cataloger_code")]
public  		string
  catalogerCode { get; set; }


         [XmlElement("cataloger_name")]
public  		string
  catalogerName { get; set; }


         [XmlElement("saler_dept_id")]
public  		string
  salerDeptId { get; set; }


         [XmlElement("saler_dept_name")]
public  		string
  salerDeptName { get; set; }


         [XmlElement("stores")]
public  		List<string>
  stores { get; set; }


         [XmlElement("item_num")]
public  		string
  itemNum { get; set; }


         [XmlElement("is_flash_purchase")]
public  		int
  isFlashPurchase { get; set; }


         [XmlElement("flash_productor")]
public  		string
  flashProductor { get; set; }


         [XmlElement("isJIT")]
public  		int
  isJIT { get; set; }


         [XmlElement("isOverseaPurchase")]
public  		int
  isOverseaPurchase { get; set; }


}
}
