using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: alibaba.alitj.order.realnamecard.info.submit
    /// </summary>
    public class AlibabaAlitjOrderRealnamecardInfoSubmitRequest : BaseTopRequest<Top.Api.Response.AlibabaAlitjOrderRealnamecardInfoSubmitResponse>
    {
        /// <summary>
        /// sim卡iccid（一般为18位到20位）
        /// </summary>
        public string Iccid { get; set; }

        /// <summary>
        /// 淘宝订单号
        /// </summary>
        public Nullable<long> OrderNo { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "alibaba.alitj.order.realnamecard.info.submit";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("iccid", this.Iccid);
            parameters.Add("order_no", this.OrderNo);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("iccid", this.Iccid);
            RequestValidator.ValidateMaxLength("iccid", this.Iccid, 32);
            RequestValidator.ValidateRequired("order_no", this.OrderNo);
            RequestValidator.ValidateMinValue("order_no", this.OrderNo, 1000);
        }

        #endregion
    }
}
