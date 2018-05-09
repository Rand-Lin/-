using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// CnTmsLogisticsOrderItem Data Structure.
    /// </summary>
    [Serializable]
    public class CnTmsLogisticsOrderItem : TopObject
    {
        /// <summary>
        /// 扩展字段 K:V;
        /// </summary>
        [XmlElement("extend_fields")]
        public string ExtendFields { get; set; }

        /// <summary>
        /// 发货商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品单价，单位分
        /// </summary>
        [XmlElement("item_price")]
        public Nullable<long> ItemPrice { get; set; }

        /// <summary>
        /// 发货商品商品数量
        /// </summary>
        [XmlElement("item_qty")]
        public Nullable<long> ItemQty { get; set; }

        /// <summary>
        /// ERP订单明细编码
        /// </summary>
        [XmlElement("order_item_id")]
        public string OrderItemId { get; set; }

        /// <summary>
        /// 发货商品商品数量
        /// </summary>
        [XmlElement("quantity")]
        public Nullable<long> Quantity { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 子交易号
        /// </summary>
        [XmlElement("sub_trade_id")]
        public string SubTradeId { get; set; }
    }
}
