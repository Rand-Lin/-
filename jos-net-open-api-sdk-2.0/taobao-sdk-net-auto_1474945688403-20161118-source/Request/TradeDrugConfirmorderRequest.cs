using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trade.drug.confirmorder
    /// </summary>
    public class TradeDrugConfirmorderRequest : BaseTopRequest<Top.Api.Response.TradeDrugConfirmorderResponse>
    {
        /// <summary>
        /// public static int NORMAL_TYPE=0; 普通发货 默认 public static int DD_DAI_SONG=2; 代送宝 public static int DD_SONG_TYPE_V2=3; 点点送发货
        /// </summary>
        public Nullable<long> ConfirmType { get; set; }

        /// <summary>
        /// 代送宝 代送商ID
        /// </summary>
        public Nullable<long> DeliveryId { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        public Nullable<long> OrderId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.trade.drug.confirmorder";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("confirm_type", this.ConfirmType);
            parameters.Add("delivery_id", this.DeliveryId);
            parameters.Add("order_id", this.OrderId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("order_id", this.OrderId);
        }

        #endregion
    }
}
