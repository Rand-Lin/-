using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.smartwl.package.create
    /// </summary>
    public class SmartwlPackageCreateRequest : BaseTopRequest<Top.Api.Response.SmartwlPackageCreateResponse>
    {
        /// <summary>
        /// 物流服务商Id
        /// </summary>
        public Nullable<long> CpId { get; set; }

        /// <summary>
        /// 预留扩展字段，格式json
        /// </summary>
        public string Feature { get; set; }

        /// <summary>
        /// 包裹高度，单位cm
        /// </summary>
        public Nullable<long> Height { get; set; }

        /// <summary>
        /// 包裹长度，单位cm
        /// </summary>
        public Nullable<long> Length { get; set; }

        /// <summary>
        /// 运单号，cp_id+ mail_no唯一
        /// </summary>
        public string MailNo { get; set; }

        /// <summary>
        /// 订单来源，淘宝(TB)、天猫(TM)、京东(JD)、当当(DD)、拍拍(PP)、易讯(YX)、ebay(EBAY)、QQ网购(QQ)、亚马逊(AMAZON)、苏宁(SN)、国美(GM)、唯品会(WPH)、聚美(JM)、乐蜂(LF)、蘑菇街(MGJ)、聚尚(JS)、拍鞋(PX)、银泰(YT)、1号店(YHD)、凡客(VANCL)、邮乐(YL)、优购(YG)、其他(OTHERS)
        /// </summary>
        public string OrderSrc { get; set; }

        /// <summary>
        /// 交易流水号，淘外订单号或者商家内部交易流水号，ISV保证其唯一性
        /// </summary>
        public string TradeOrder { get; set; }

        /// <summary>
        /// 包裹体积，单位cm3
        /// </summary>
        public Nullable<long> Volumn { get; set; }

        /// <summary>
        /// 包裹重量，单位克
        /// </summary>
        public Nullable<long> Weight { get; set; }

        /// <summary>
        /// 包裹宽度，单位cm
        /// </summary>
        public Nullable<long> Width { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.smartwl.package.create";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cp_id", this.CpId);
            parameters.Add("feature", this.Feature);
            parameters.Add("height", this.Height);
            parameters.Add("length", this.Length);
            parameters.Add("mail_no", this.MailNo);
            parameters.Add("order_src", this.OrderSrc);
            parameters.Add("trade_order", this.TradeOrder);
            parameters.Add("volumn", this.Volumn);
            parameters.Add("weight", this.Weight);
            parameters.Add("width", this.Width);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("cp_id", this.CpId);
            RequestValidator.ValidateMaxLength("feature", this.Feature, 1024);
            RequestValidator.ValidateRequired("mail_no", this.MailNo);
            RequestValidator.ValidateMaxLength("mail_no", this.MailNo, 20);
            RequestValidator.ValidateRequired("order_src", this.OrderSrc);
            RequestValidator.ValidateMaxLength("order_src", this.OrderSrc, 64);
            RequestValidator.ValidateRequired("trade_order", this.TradeOrder);
            RequestValidator.ValidateMaxLength("trade_order", this.TradeOrder, 30);
            RequestValidator.ValidateRequired("weight", this.Weight);
        }

        #endregion
    }
}
