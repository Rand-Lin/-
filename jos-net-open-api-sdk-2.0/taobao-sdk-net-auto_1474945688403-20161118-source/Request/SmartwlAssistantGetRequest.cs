using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.smartwl.assistant.get
    /// </summary>
    public class SmartwlAssistantGetRequest : BaseTopRequest<Top.Api.Response.SmartwlAssistantGetResponse>
    {
        /// <summary>
        /// 物流公司id列表，可以从接口taobao.logistics.companies.get获取所有物流公司id，可以传入多个值，以英文逗号分隔
        /// </summary>
        public string CpidList { get; set; }

        /// <summary>
        /// 预留扩展字段，json格式
        /// </summary>
        public string Feature { get; set; }

        /// <summary>
        /// 订单来源，淘宝(TB)、天猫(TM)、京东(JD)、当当(DD)、拍拍(PP)、易讯(YX)、ebay(EBAY)、QQ网购(QQ)、亚马逊(AMAZON)、苏宁(SN)、国美(GM)、唯品会(WPH)、聚美(JM)、乐蜂(LF)、蘑菇街(MGJ)、聚尚(JS)、拍鞋(PX)、银泰(YT)、1号店(YHD)、凡客(VANCL)、邮乐(YL)、优购(YG)、其他(OTHERS)
        /// </summary>
        public string OrderSource { get; set; }

        /// <summary>
        /// 收货地详细地址
        /// </summary>
        public string ReceiveAddress { get; set; }

        /// <summary>
        /// 发货地，至少三级行政地址
        /// </summary>
        public string SendAddress { get; set; }

        /// <summary>
        /// 物流服务类型
        /// </summary>
        public Nullable<long> ServiceType { get; set; }

        /// <summary>
        /// 交易流水号，淘外订单号或者商家内部交易流水号，ISV保证其唯一性
        /// </summary>
        public string TradeOrder { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.smartwl.assistant.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cpid_list", this.CpidList);
            parameters.Add("feature", this.Feature);
            parameters.Add("order_source", this.OrderSource);
            parameters.Add("receive_address", this.ReceiveAddress);
            parameters.Add("send_address", this.SendAddress);
            parameters.Add("service_type", this.ServiceType);
            parameters.Add("trade_order", this.TradeOrder);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxLength("cpid_list", this.CpidList, 100);
            RequestValidator.ValidateMaxLength("feature", this.Feature, 1024);
            RequestValidator.ValidateRequired("order_source", this.OrderSource);
            RequestValidator.ValidateMaxLength("order_source", this.OrderSource, 64);
            RequestValidator.ValidateRequired("receive_address", this.ReceiveAddress);
            RequestValidator.ValidateMaxLength("receive_address", this.ReceiveAddress, 300);
            RequestValidator.ValidateMaxLength("send_address", this.SendAddress, 200);
            RequestValidator.ValidateRequired("service_type", this.ServiceType);
            RequestValidator.ValidateRequired("trade_order", this.TradeOrder);
            RequestValidator.ValidateMaxLength("trade_order", this.TradeOrder, 50);
        }

        #endregion
    }
}
