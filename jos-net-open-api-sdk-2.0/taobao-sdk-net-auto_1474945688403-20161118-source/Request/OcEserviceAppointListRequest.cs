using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.oc.eservice.appoint.list
    /// </summary>
    public class OcEserviceAppointListRequest : BaseTopRequest<Top.Api.Response.OcEserviceAppointListResponse>
    {
        /// <summary>
        /// 预约信息唯一编码(code, customerNick, customerPhone, houseAddressCity, mallCode 调用时五个可选参数中任选一个作为输入参数)
        /// </summary>
        public Nullable<long> Code { get; set; }

        /// <summary>
        /// 买家客户nick(code, customerNick, customerPhone, houseAddressCity, mallCode 调用时五个可选参数中任选一个作为输入参数)
        /// </summary>
        public string CustomerNick { get; set; }

        /// <summary>
        /// 买家客户电话号码(code, customerNick, customerPhone, houseAddressCity, mallCode 调用时五个可选参数中任选一个作为输入参数)
        /// </summary>
        public string CustomerPhone { get; set; }

        /// <summary>
        /// 买家客户装修房屋所在的市(code, customerNick, customerPhone, houseAddressCity, mallCode 调用时五个可选参数中任选一个作为输入参数)
        /// </summary>
        public string HouseAddressCity { get; set; }

        /// <summary>
        /// 门店编码(code, customerNick, customerPhone, houseAddressCity, mallCode 调用时五个可选参数中任选一个作为输入参数)
        /// </summary>
        public string MallCode { get; set; }

        /// <summary>
        /// 卖家主账号id
        /// </summary>
        public Nullable<long> SellerId { get; set; }

        /// <summary>
        /// 返回结果按预约时间排序，指示升序还是降息，取值asc和desc
        /// </summary>
        public string SortOrder { get; set; }

        /// <summary>
        /// 查询预约的起始时间，格式yyyyMMddHHmmss，默认为当前时间
        /// </summary>
        public string StartAppointTime { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.oc.eservice.appoint.list";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("code", this.Code);
            parameters.Add("customer_nick", this.CustomerNick);
            parameters.Add("customer_phone", this.CustomerPhone);
            parameters.Add("house_address_city", this.HouseAddressCity);
            parameters.Add("mall_code", this.MallCode);
            parameters.Add("seller_id", this.SellerId);
            parameters.Add("sort_order", this.SortOrder);
            parameters.Add("start_appoint_time", this.StartAppointTime);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("seller_id", this.SellerId);
        }

        #endregion
    }
}
