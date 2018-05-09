using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.delivery.drug.deliveryconfirm
    /// </summary>
    public class DeliveryDrugDeliveryconfirmRequest : BaseTopRequest<Top.Api.Response.DeliveryDrugDeliveryconfirmResponse>
    {
        /// <summary>
        /// 配送单号
        /// </summary>
        public Nullable<long> DeliveryOrderNo { get; set; }

        /// <summary>
        /// 配送员id
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        public string Latitude { get; set; }

        /// <summary>
        /// 定位错误
        /// </summary>
        public string LocationErrorReason { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        public string Longitude { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.delivery.drug.deliveryconfirm";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("delivery_order_no", this.DeliveryOrderNo);
            parameters.Add("device_id", this.DeviceId);
            parameters.Add("latitude", this.Latitude);
            parameters.Add("location_error_reason", this.LocationErrorReason);
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
