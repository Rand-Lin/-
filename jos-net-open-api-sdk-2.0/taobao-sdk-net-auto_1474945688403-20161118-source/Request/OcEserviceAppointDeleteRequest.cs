using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.oc.eservice.appoint.delete
    /// </summary>
    public class OcEserviceAppointDeleteRequest : BaseTopRequest<Top.Api.Response.OcEserviceAppointDeleteResponse>
    {
        /// <summary>
        /// 预约信息唯一编码
        /// </summary>
        public Nullable<long> Code { get; set; }

        /// <summary>
        /// 卖家的sellerId
        /// </summary>
        public Nullable<long> SellerId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.oc.eservice.appoint.delete";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("code", this.Code);
            parameters.Add("seller_id", this.SellerId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("code", this.Code);
            RequestValidator.ValidateRequired("seller_id", this.SellerId);
        }

        #endregion
    }
}
