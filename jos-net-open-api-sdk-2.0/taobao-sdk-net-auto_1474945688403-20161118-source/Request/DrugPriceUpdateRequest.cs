using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.drug.price.update
    /// </summary>
    public class DrugPriceUpdateRequest : BaseTopRequest<Top.Api.Response.DrugPriceUpdateResponse>
    {
        /// <summary>
        /// 对应的外部商品编码
        /// </summary>
        public string OutItemId { get; set; }

        /// <summary>
        /// 对应的外部店铺ID
        /// </summary>
        public string OutStoreId { get; set; }

        /// <summary>
        /// 商品价格
        /// </summary>
        public string Price { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.drug.price.update";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("out_item_id", this.OutItemId);
            parameters.Add("out_store_id", this.OutStoreId);
            parameters.Add("price", this.Price);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("out_item_id", this.OutItemId);
            RequestValidator.ValidateRequired("out_store_id", this.OutStoreId);
            RequestValidator.ValidateRequired("price", this.Price);
        }

        #endregion
    }
}
