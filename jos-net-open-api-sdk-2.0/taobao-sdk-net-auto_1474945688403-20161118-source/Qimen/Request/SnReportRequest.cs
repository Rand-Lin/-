using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;
using Top.Api.Util;
using Top.Api;

namespace Qimen.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qimen.sn.report
    /// </summary>
    public class SnReportRequest : QimenRequest<Qimen.Api.Response.SnReportResponse>
    {
        /// <summary>
        /// 当前页(从1开始)
        /// </summary>
        public Nullable<long> CurrentPage { get; set; }

        public DeliveryOrderDomain DeliveryOrder { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        public string ExtendProps { get; set; }

        public List<ItemDomain> Items { get; set; }

        /// <summary>
        /// 每页记录的条数
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        public Nullable<long> TotalPage { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.qimen.sn.report";
        }


	/// <summary>
/// DeliveryOrderDomain Data Structure.
/// </summary>
[Serializable]
public class DeliveryOrderDomain
{
	        /// <summary>
	        /// 出库单号
	        /// </summary>
	        [XmlElement("deliveryOrderCode")]
	        public string DeliveryOrderCode { get; set; }
	
	        /// <summary>
	        /// 仓储系统出库单号
	        /// </summary>
	        [XmlElement("deliveryOrderId")]
	        public string DeliveryOrderId { get; set; }
	
	        /// <summary>
	        /// 出库单类型(JYCK=一般交易出库;HHCK=换货出库;BFCK=补发出库;PTCK=普通出库单;DBCK=调拨出库;QTCK=其他出 库;B2BCK=B2B出库)
	        /// </summary>
	        [XmlElement("orderType")]
	        public string OrderType { get; set; }
	
	        /// <summary>
	        /// 外部业务编码(消息ID;用于去重;ISV对于同一请求;分配一个唯一性的编码。用来保证因为网络等原因导致重复传输;请求不会 被重复处理;条件必填;条件为一单需要多次确认时)
	        /// </summary>
	        [XmlElement("outBizCode")]
	        public string OutBizCode { get; set; }
	
	        /// <summary>
	        /// 货主编码
	        /// </summary>
	        [XmlElement("ownerCode")]
	        public string OwnerCode { get; set; }
	
	        /// <summary>
	        /// 仓库编码
	        /// </summary>
	        [XmlElement("warehouseCode")]
	        public string WarehouseCode { get; set; }
}

	/// <summary>
/// ItemDomain Data Structure.
/// </summary>
[Serializable]
public class ItemDomain
{
	        /// <summary>
	        /// 商品编码
	        /// </summary>
	        [XmlElement("itemCode")]
	        public string ItemCode { get; set; }
	
	        /// <summary>
	        /// 商品仓储系统编码
	        /// </summary>
	        [XmlElement("itemId")]
	        public string ItemId { get; set; }
	
	        /// <summary>
	        /// 商品序列号
	        /// </summary>
	        [XmlElement("sn")]
	        public string Sn { get; set; }
}

        #endregion
    }
}
