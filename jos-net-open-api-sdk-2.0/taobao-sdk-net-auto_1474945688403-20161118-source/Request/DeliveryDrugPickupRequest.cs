using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.delivery.drug.pickup
    /// </summary>
    public class DeliveryDrugPickupRequest : BaseTopRequest<Top.Api.Response.DeliveryDrugPickupResponse>
    {
        /// <summary>
        /// 物流订单号
        /// </summary>
        public Nullable<long> DeliveryOrderNo { get; set; }

        /// <summary>
        /// 地图坐标：维度
        /// </summary>
        public string Latitude { get; set; }

        /// <summary>
        /// 地图坐标：经度
        /// </summary>
        public string Longitude { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.delivery.drug.pickup";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("delivery_order_no", this.DeliveryOrderNo);
            parameters.Add("latitude", this.Latitude);
            parameters.Add("longitude", this.Longitude);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("delivery_order_no", this.DeliveryOrderNo);
            RequestValidator.ValidateRequired("latitude", this.Latitude);
            RequestValidator.ValidateRequired("longitude", this.Longitude);
        }

        #endregion
    }
}
