using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.smartwl.userinfo.get
    /// </summary>
    public class SmartwlUserinfoGetRequest : BaseTopRequest<Top.Api.Response.SmartwlUserinfoGetResponse>
    {
        /// <summary>
        /// 预留扩展字段，格式json串
        /// </summary>
        public string Feature { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.smartwl.userinfo.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("feature", this.Feature);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxLength("feature", this.Feature, 500);
        }

        #endregion
    }
}
