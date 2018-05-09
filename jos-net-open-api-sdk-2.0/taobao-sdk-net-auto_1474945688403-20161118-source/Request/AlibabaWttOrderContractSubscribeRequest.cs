using System;
using System.Xml.Serialization;
using Top.Api.Domain;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: alibaba.wtt.order.contract.subscribe
    /// </summary>
    public class AlibabaWttOrderContractSubscribeRequest : BaseTopRequest<Top.Api.Response.AlibabaWttOrderContractSubscribeResponse>
    {
        /// <summary>
        /// 分销商合约生产
        /// </summary>
        public string DistributionOrderModel { get; set; }

        public DistributionOrderModel DistributionOrderModel_ { set { this.DistributionOrderModel = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "alibaba.wtt.order.contract.subscribe";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("distribution_order_model", this.DistributionOrderModel);
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
