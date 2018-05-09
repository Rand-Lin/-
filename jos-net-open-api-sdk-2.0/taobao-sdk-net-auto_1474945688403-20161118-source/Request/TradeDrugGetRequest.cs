using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trade.drug.get
    /// </summary>
    public class TradeDrugGetRequest : BaseTopRequest<Top.Api.Response.TradeDrugGetResponse>
    {
        /// <summary>
        /// true-商家下所有店铺的待确认订单, false—指定店铺的订单
        /// </summary>
        public Nullable<bool> IsAll { get; set; }

        /// <summary>
        /// 返回记录数，超过20按20条返回数据
        /// </summary>
        public Nullable<long> MaxSize { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        public Nullable<long> StoreId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.trade.drug.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("is_all", this.IsAll);
            parameters.Add("max_size", this.MaxSize);
            parameters.Add("store_id", this.StoreId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("max_size", this.MaxSize);
            RequestValidator.ValidateMaxValue("max_size", this.MaxSize, 20);
            RequestValidator.ValidateMinValue("max_size", this.MaxSize, 1);
            RequestValidator.ValidateRequired("store_id", this.StoreId);
        }

        #endregion
    }
}
