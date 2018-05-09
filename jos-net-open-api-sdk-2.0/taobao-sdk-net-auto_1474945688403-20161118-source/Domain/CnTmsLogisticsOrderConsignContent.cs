using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// CnTmsLogisticsOrderConsignContent Data Structure.
    /// </summary>
    [Serializable]
    public class CnTmsLogisticsOrderConsignContent : TopObject
    {
        /// <summary>
        /// 配送要求
        /// </summary>
        [XmlElement("deliver_requirements")]
        public Top.Api.Domain.CnTmsLogisticsOrderDeliverRequirements DeliverRequirements { get; set; }

        /// <summary>
        /// 扩展字段 K:V;
        /// </summary>
        [XmlElement("extend_fields")]
        public string ExtendFields { get; set; }

        /// <summary>
        /// 发货的商品信息
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("cn_tms_logistics_order_item")]
        public List<Top.Api.Domain.CnTmsLogisticsOrderItem> Items { get; set; }

        /// <summary>
        /// 运单号 若是自己联系物流，则必填 否则表示菜鸟自动获取运单号
        /// </summary>
        [XmlElement("mail_no")]
        public string MailNo { get; set; }

        /// <summary>
        /// ERP订单号
        /// </summary>
        [XmlElement("order_code")]
        public string OrderCode { get; set; }

        /// <summary>
        /// 来源渠道（TB 淘宝，JD 京东，TM 天猫，1688 1688（阿里中文站），YHD 1号店，DD 当当，VANCL 凡客，PP 拍拍，YX 易讯，EBAY 易贝ebay，AMAZON 亚马逊，SN 苏宁在线，GM 国美在线，WPH 唯品会，JM 聚美优品，LF 乐蜂网，MGJ 蘑菇街，JS 聚尚网，YG 优购，YT 银泰，YL 邮乐，PX 拍鞋网，POS POS门店，OTHERS 其他）
        /// </summary>
        [XmlElement("order_source")]
        public string OrderSource { get; set; }

        /// <summary>
        /// 货主ID
        /// </summary>
        [XmlElement("owner_user_id")]
        public string OwnerUserId { get; set; }

        /// <summary>
        /// 此订单总的包裹数，如订单拆包裹时，传入此参数，配送时会将同一订单的包裹一配送
        /// </summary>
        [XmlElement("package_count")]
        public Nullable<long> PackageCount { get; set; }

        /// <summary>
        /// 包裹高度（厘米）
        /// </summary>
        [XmlElement("package_height")]
        public Nullable<long> PackageHeight { get; set; }

        /// <summary>
        /// 包裹长度（厘米）
        /// </summary>
        [XmlElement("package_length")]
        public Nullable<long> PackageLength { get; set; }

        /// <summary>
        /// 此订单的第几个包裹，如订单拆包裹时，传入此参数，配送时会将同一订单的包裹一配送
        /// </summary>
        [XmlElement("package_no")]
        public Nullable<long> PackageNo { get; set; }

        /// <summary>
        /// 包裹体积（立方厘米）
        /// </summary>
        [XmlElement("package_volume")]
        public Nullable<long> PackageVolume { get; set; }

        /// <summary>
        /// 包裹重量（克）
        /// </summary>
        [XmlElement("package_weight")]
        public Nullable<long> PackageWeight { get; set; }

        /// <summary>
        /// 包裹宽度（厘米）
        /// </summary>
        [XmlElement("package_width")]
        public Nullable<long> PackageWidth { get; set; }

        /// <summary>
        /// 商家送货方式，1商家送货，2菜鸟揽货
        /// </summary>
        [XmlElement("pick_up_type")]
        public Nullable<long> PickUpType { get; set; }

        /// <summary>
        /// 收件人地址信息
        /// </summary>
        [XmlElement("receiver_info")]
        public Top.Api.Domain.CnTmsLogisticsOrderReceiverInfo ReceiverInfo { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 发件人地址信息
        /// </summary>
        [XmlElement("sender_info")]
        public Top.Api.Domain.CnTmsLogisticsOrderSenderinfo SenderInfo { get; set; }

        /// <summary>
        /// 店铺编码
        /// </summary>
        [XmlElement("shop_code")]
        public string ShopCode { get; set; }

        /// <summary>
        /// 物流服务解决方案Code，此字段由菜鸟提供
        /// </summary>
        [XmlElement("solutions_code")]
        public string SolutionsCode { get; set; }

        /// <summary>
        /// 物流公司编码
        /// </summary>
        [XmlElement("tms_code")]
        public string TmsCode { get; set; }

        /// <summary>
        /// 要求菜鸟上门揽货服务，当pick_up_Type=2且需求指定时做揽收时，此字段需要传值
        /// </summary>
        [XmlElement("tms_got_service")]
        public Top.Api.Domain.CnTmsLogisticsOrderGotService TmsGotService { get; set; }

        /// <summary>
        /// 交易订单id
        /// </summary>
        [XmlElement("trade_id")]
        public string TradeId { get; set; }
    }
}
