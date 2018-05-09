using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: alibaba.tianji.distributor.order.submit
    /// </summary>
    public class AlibabaTianjiDistributorOrderSubmitRequest : BaseTopRequest<Top.Api.Response.AlibabaTianjiDistributorOrderSubmitResponse>
    {
        /// <summary>
        /// 商品编码，如手机串号
        /// </summary>
        public string ItemSerialNo { get; set; }

        /// <summary>
        /// 淘宝交易订单号
        /// </summary>
        public string OrderNo { get; set; }

        /// <summary>
        /// 供应商产品编码，如SIM卡号
        /// </summary>
        public string ProductSerialNo { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "alibaba.tianji.distributor.order.submit";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("item_serial_no", this.ItemSerialNo);
            parameters.Add("order_no", this.OrderNo);
            parameters.Add("product_serial_no", this.ProductSerialNo);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("order_no", this.OrderNo);
        }

        #endregion
    }
}
