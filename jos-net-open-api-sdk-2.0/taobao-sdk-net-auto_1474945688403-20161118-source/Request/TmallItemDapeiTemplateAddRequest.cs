using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.item.dapei.template.add
    /// </summary>
    public class TmallItemDapeiTemplateAddRequest : BaseTopRequest<Top.Api.Response.TmallItemDapeiTemplateAddResponse>
    {
        /// <summary>
        /// 搭配推荐描述
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 2-4个商品
        /// </summary>
        public string Items { get; set; }

        public List<DapeiItemDomain> Items_ { set { this.Items = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 搭配名称
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 模特图片
        /// </summary>
        public string Url { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "tmall.item.dapei.template.add";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("desc", this.Desc);
            parameters.Add("items", this.Items);
            parameters.Add("title", this.Title);
            parameters.Add("url", this.Url);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("desc", this.Desc);
            RequestValidator.ValidateRequired("items", this.Items);
            RequestValidator.ValidateObjectMaxListSize("items", this.Items, 20);
            RequestValidator.ValidateRequired("title", this.Title);
            RequestValidator.ValidateRequired("url", this.Url);
        }

	/// <summary>
/// DapeiItemDomain Data Structure.
/// </summary>
[Serializable]
public class DapeiItemDomain : TopObject
{
	        /// <summary>
	        /// 指定的商品图片
	        /// </summary>
	        [XmlElement("img")]
	        public string Img { get; set; }
	
	        /// <summary>
	        /// 商品ID
	        /// </summary>
	        [XmlElement("item_id")]
	        public Nullable<long> ItemId { get; set; }
}

        #endregion
    }
}
