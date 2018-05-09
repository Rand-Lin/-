using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.marketing.tmallcoupon.coupon.apply
    /// </summary>
    public class TmallMarketingTmallcouponCouponApplyRequest : BaseTopRequest<Top.Api.Response.TmallMarketingTmallcouponCouponApplyResponse>
    {
        /// <summary>
        /// 面额，单位（分）
        /// </summary>
        public Nullable<long> FaceAmount { get; set; }

        /// <summary>
        /// 混淆昵称
        /// </summary>
        public string Nick { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "tmall.marketing.tmallcoupon.coupon.apply";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("face_amount", this.FaceAmount);
            parameters.Add("nick", this.Nick);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("face_amount", this.FaceAmount);
        }

        #endregion
    }
}
