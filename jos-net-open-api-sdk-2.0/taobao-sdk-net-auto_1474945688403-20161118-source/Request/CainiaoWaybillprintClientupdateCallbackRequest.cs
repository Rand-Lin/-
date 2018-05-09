using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: cainiao.waybillprint.clientupdate.callback
    /// </summary>
    public class CainiaoWaybillprintClientupdateCallbackRequest : BaseTopRequest<Top.Api.Response.CainiaoWaybillprintClientupdateCallbackResponse>
    {
        /// <summary>
        /// 客户端mac
        /// </summary>
        public string Mac { get; set; }

        /// <summary>
        /// 更新类型
        /// </summary>
        public string UpdateTypaName { get; set; }

        /// <summary>
        /// 最新的、需要更新的版本
        /// </summary>
        public string Version { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "cainiao.waybillprint.clientupdate.callback";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("mac", this.Mac);
            parameters.Add("update_typa_name", this.UpdateTypaName);
            parameters.Add("version", this.Version);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("mac", this.Mac);
            RequestValidator.ValidateRequired("update_typa_name", this.UpdateTypaName);
            RequestValidator.ValidateRequired("version", this.Version);
        }

        #endregion
    }
}
