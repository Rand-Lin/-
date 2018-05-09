using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.drug.quantity.update
    /// </summary>
    public class DrugQuantityUpdateRequest : BaseTopRequest<Top.Api.Response.DrugQuantityUpdateResponse>
    {
        /// <summary>
        /// 外部商品ID
        /// </summary>
        public string OutItemId { get; set; }

        /// <summary>
        /// 外部店铺ID
        /// </summary>
        public string OutStoreId { get; set; }

        /// <summary>
        /// 库存数量
        /// </summary>
        public Nullable<long> Quantity { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.drug.quantity.update";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("out_item_id", this.OutItemId);
            parameters.Add("out_store_id", this.OutStoreId);
            parameters.Add("quantity", this.Quantity);
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
            RequestValidator.ValidateRequired("quantity", this.Quantity);
        }

        #endregion
    }
}
