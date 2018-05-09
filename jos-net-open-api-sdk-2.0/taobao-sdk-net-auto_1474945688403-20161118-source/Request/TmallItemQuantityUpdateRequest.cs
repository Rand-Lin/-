using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.item.quantity.update
    /// </summary>
    public class TmallItemQuantityUpdateRequest : BaseTopRequest<Top.Api.Response.TmallItemQuantityUpdateResponse>
    {
        /// <summary>
        /// 商品id
        /// </summary>
        public Nullable<long> ItemId { get; set; }

        /// <summary>
        /// 商品库存数；增量编辑方式支持正数、负数
        /// </summary>
        public Nullable<long> ItemQuantity { get; set; }

        /// <summary>
        /// 商品库存更新时候的可选参数
        /// </summary>
        public string Options { get; set; }

        public UpdateItemQuantityOptionDomain Options_ { set { this.Options = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 更新SKU库存时候的SKU库存对象；如果没有SKU或者不更新SKU库存，可以不填;查找SKU目前支持ID，属性串和商家编码三种模式，建议选用一种最合适的，切勿滥用，一次调用中如果混合使用，更新结果不可预期！
        /// </summary>
        public string SkuQuantities { get; set; }

        public List<UpdateSkuQuantityDomain> SkuQuantities_ { set { this.SkuQuantities = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "tmall.item.quantity.update";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("item_id", this.ItemId);
            parameters.Add("item_quantity", this.ItemQuantity);
            parameters.Add("options", this.Options);
            parameters.Add("sku_quantities", this.SkuQuantities);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("item_id", this.ItemId);
            RequestValidator.ValidateObjectMaxListSize("sku_quantities", this.SkuQuantities, 20);
        }

	/// <summary>
/// UpdateSkuQuantityDomain Data Structure.
/// </summary>
[Serializable]
public class UpdateSkuQuantityDomain : TopObject
{
	        /// <summary>
	        /// SkuID，用于指定被修改库存的SKU
	        /// </summary>
	        [XmlElement("outer_id")]
	        public string OuterId { get; set; }
	
	        /// <summary>
	        /// Sku属性串。格式:pid:vid;pid:vid,如: 1627207:3232483;1630696:3284570,表示机身颜色:军绿色;手机套餐:一电一充，用于指定被修改库存的SKU
	        /// </summary>
	        [XmlElement("properties")]
	        public string Properties { get; set; }
	
	        /// <summary>
	        /// Sku的商家外部id，用于指定被修改库存的SKU
	        /// </summary>
	        [XmlElement("quantity")]
	        public Nullable<long> Quantity { get; set; }
	
	        /// <summary>
	        /// 属于这个sku的商品的库存；增量编辑方式支持正数、负数
	        /// </summary>
	        [XmlElement("sku_id")]
	        public Nullable<long> SkuId { get; set; }
}

	/// <summary>
/// UpdateItemQuantityOptionDomain Data Structure.
/// </summary>
[Serializable]
public class UpdateItemQuantityOptionDomain : TopObject
{
	        /// <summary>
	        /// 增量幂等外部编码
	        /// </summary>
	        [XmlElement("outer_biz_key")]
	        public string OuterBizKey { get; set; }
	
	        /// <summary>
	        /// 库存更新方式: 1是全量更新 2是增量更新；默认是1。
	        /// </summary>
	        [XmlElement("type")]
	        public Nullable<long> Type { get; set; }
}

        #endregion
    }
}
