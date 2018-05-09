using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.drug.shop.list
    /// </summary>
    public class DrugShopListRequest : BaseTopRequest<Top.Api.Response.DrugShopListResponse>
    {
        /// <summary>
        /// 查询关键字
        /// </summary>
        public string Keywords { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        public Nullable<long> Page { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 店铺状态，歇业：0，营业：1，所有：-1
        /// </summary>
        public Nullable<long> Status { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.drug.shop.list";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("keywords", this.Keywords);
            parameters.Add("page", this.Page);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("status", this.Status);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("page", this.Page);
            RequestValidator.ValidateMinValue("page", this.Page, 1);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 20);
            RequestValidator.ValidateMinValue("page_size", this.PageSize, 1);
        }

        #endregion
    }
}
