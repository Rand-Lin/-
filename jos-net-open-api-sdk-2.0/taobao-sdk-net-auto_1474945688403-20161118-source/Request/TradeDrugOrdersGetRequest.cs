using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trade.drug.orders.get
    /// </summary>
    public class TradeDrugOrdersGetRequest : BaseTopRequest<Top.Api.Response.TradeDrugOrdersGetResponse>
    {
        /// <summary>
        /// true 仅有支付宝订单,false 包括所有类型订单(货到付款,支付券等)
        /// </summary>
        public Nullable<bool> IsAllOrder { get; set; }

        /// <summary>
        /// true-查询仅按商家维度  false-查询按商家下所属店铺维度
        /// </summary>
        public Nullable<bool> IsAllShop { get; set; }

        /// <summary>
        /// 关键字
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// （必填字段）订单状态 待确认订单2 , 退款中订单4 , 已发货12 关闭20 交易成功21
        /// </summary>
        public Nullable<long> OrderStatus { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 返回记录数，超过20按20条返回数据
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 外卖分店ID
        /// </summary>
        public Nullable<long> ShopId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.trade.drug.orders.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("is_all_order", this.IsAllOrder);
            parameters.Add("is_all_shop", this.IsAllShop);
            parameters.Add("keyword", this.Keyword);
            parameters.Add("order_status", this.OrderStatus);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("shop_id", this.ShopId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("is_all_order", this.IsAllOrder);
            RequestValidator.ValidateRequired("is_all_shop", this.IsAllShop);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 20);
            RequestValidator.ValidateMinValue("page_size", this.PageSize, 1);
            RequestValidator.ValidateRequired("shop_id", this.ShopId);
        }

        #endregion
    }
}
