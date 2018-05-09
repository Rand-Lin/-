using System;
using System.Xml.Serialization;
using Top.Api.Domain;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: cainiao.cntms.logistics.order.consign
    /// </summary>
    public class CainiaoCntmsLogisticsOrderConsignRequest : BaseTopRequest<Top.Api.Response.CainiaoCntmsLogisticsOrderConsignResponse>
    {
        /// <summary>
        /// 配送发货信息
        /// </summary>
        public string Content { get; set; }

        public CnTmsLogisticsOrderConsignContent Content_ { set { this.Content = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "cainiao.cntms.logistics.order.consign";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("content", this.Content);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

        #endregion
    }
}
