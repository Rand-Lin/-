using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TradeDrugGetResponse.
    /// </summary>
    public class TradeDrugGetResponse : TopResponse
    {
        /// <summary>
        /// 查询到的订单列表对象
        /// </summary>
        [XmlElement("result")]
        public ResultDomain Result { get; set; }

	/// <summary>
/// UserAddressDomain Data Structure.
/// </summary>
[Serializable]
public class UserAddressDomain : TopObject
{
	        /// <summary>
	        /// 送货地址
	        /// </summary>
	        [XmlElement("address")]
	        public string Address { get; set; }
	
	        /// <summary>
	        /// 手机号
	        /// </summary>
	        [XmlElement("mobile")]
	        public string Mobile { get; set; }
	
	        /// <summary>
	        /// 买家姓名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 联系电话
	        /// </summary>
	        [XmlElement("phone")]
	        public string Phone { get; set; }
}

	/// <summary>
/// OrderGoodsDomain Data Structure.
/// </summary>
[Serializable]
public class OrderGoodsDomain : TopObject
{
	        /// <summary>
	        /// 商品购买数量
	        /// </summary>
	        [XmlElement("count")]
	        public long Count { get; set; }
	
	        /// <summary>
	        /// 商品外部ID
	        /// </summary>
	        [XmlElement("goods_code")]
	        public string GoodsCode { get; set; }
	
	        /// <summary>
	        /// 商品名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 商品ID
	        /// </summary>
	        [XmlElement("order_id")]
	        public long OrderId { get; set; }
	
	        /// <summary>
	        /// 商品实际购买价
	        /// </summary>
	        [XmlElement("real_price")]
	        public string RealPrice { get; set; }
}

	/// <summary>
/// ResultDomain Data Structure.
/// </summary>
[Serializable]
public class ResultDomain : TopObject
{
	        /// <summary>
	        /// 送货地址
	        /// </summary>
	        [XmlElement("address")]
	        public string Address { get; set; }
	
	        /// <summary>
	        /// 支付宝流水号
	        /// </summary>
	        [XmlElement("alipay_stream_id")]
	        public string AlipayStreamId { get; set; }
	
	        /// <summary>
	        /// 创建时间
	        /// </summary>
	        [XmlElement("create_time")]
	        public string CreateTime { get; set; }
	
	        /// <summary>
	        /// 配送费
	        /// </summary>
	        [XmlElement("delivery_pay")]
	        public string DeliveryPay { get; set; }
	
	        /// <summary>
	        /// 送达时间要求_结束
	        /// </summary>
	        [XmlElement("end_delivery_time")]
	        public string EndDeliveryTime { get; set; }
	
	        /// <summary>
	        /// 用户下单方式(PC/APP)
	        /// </summary>
	        [XmlElement("from")]
	        public long From { get; set; }
	
	        /// <summary>
	        /// 下单商品列表
	        /// </summary>
	        [XmlArray("goods_list")]
	        [XmlArrayItem("order_goods")]
	        public List<OrderGoodsDomain> GoodsList { get; set; }
	
	        /// <summary>
	        /// 订单号
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 用户下单时的备注信息
	        /// </summary>
	        [XmlElement("note")]
	        public string Note { get; set; }
	
	        /// <summary>
	        /// 买家支付宝账号
	        /// </summary>
	        [XmlElement("pay_account")]
	        public string PayAccount { get; set; }
	
	        /// <summary>
	        /// 送达时间要求_起始
	        /// </summary>
	        [XmlElement("start_delivery_time")]
	        public string StartDeliveryTime { get; set; }
	
	        /// <summary>
	        /// 店铺联系电话
	        /// </summary>
	        [XmlElement("store_contact_phone")]
	        public string StoreContactPhone { get; set; }
	
	        /// <summary>
	        /// 分店ID
	        /// </summary>
	        [XmlElement("store_id")]
	        public long StoreId { get; set; }
	
	        /// <summary>
	        /// 店铺名称
	        /// </summary>
	        [XmlElement("store_name")]
	        public string StoreName { get; set; }
	
	        /// <summary>
	        /// 总支付金额
	        /// </summary>
	        [XmlElement("total_pay")]
	        public string TotalPay { get; set; }
	
	        /// <summary>
	        /// 用户地址对象
	        /// </summary>
	        [XmlElement("user_address")]
	        public UserAddressDomain UserAddress { get; set; }
	
	        /// <summary>
	        /// 买家ID
	        /// </summary>
	        [XmlElement("user_id")]
	        public string UserId { get; set; }
}

    }
}
