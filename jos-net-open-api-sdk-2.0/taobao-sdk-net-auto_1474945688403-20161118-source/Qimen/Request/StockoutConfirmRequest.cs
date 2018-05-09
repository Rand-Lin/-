using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;
using Top.Api.Util;
using Top.Api;

namespace Qimen.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qimen.stockout.confirm
    /// </summary>
    public class StockoutConfirmRequest : QimenRequest<Qimen.Api.Response.StockoutConfirmResponse>
    {
        public DeliveryOrderDomain DeliveryOrder { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        public string ExtendProps { get; set; }

        public List<OrderLineDomain> OrderLines { get; set; }

        public List<PackageDomain> Packages { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.qimen.stockout.confirm";
        }


	/// <summary>
/// DeliveryOrderDomain Data Structure.
/// </summary>
[Serializable]
public class DeliveryOrderDomain
{
	        /// <summary>
	        /// 支持出库单多次发货的状态位
	        /// </summary>
	        [XmlElement("confirmType")]
	        public Nullable<long> ConfirmType { get; set; }
	
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
	        /// 运单号
	        /// </summary>
	        [XmlElement("expressCode")]
	        public string ExpressCode { get; set; }
	
	        /// <summary>
	        /// 物流公司编码
	        /// </summary>
	        [XmlElement("logisticsCode")]
	        public string LogisticsCode { get; set; }
	
	        /// <summary>
	        /// 物流公司名称
	        /// </summary>
	        [XmlElement("logisticsName")]
	        public string LogisticsName { get; set; }
	
	        /// <summary>
	        /// 订单完成时间
	        /// </summary>
	        [XmlElement("orderConfirmTime")]
	        public string OrderConfirmTime { get; set; }
	
	        /// <summary>
	        /// 出库单类型
	        /// </summary>
	        [XmlElement("orderType")]
	        public string OrderType { get; set; }
	
	        /// <summary>
	        /// 外部业务编码
	        /// </summary>
	        [XmlElement("outBizCode")]
	        public string OutBizCode { get; set; }
	
	        /// <summary>
	        /// 出库单状态
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 单据总行数
	        /// </summary>
	        [XmlElement("totalOrderLines")]
	        public Nullable<long> TotalOrderLines { get; set; }
	
	        /// <summary>
	        /// 仓库编码
	        /// </summary>
	        [XmlElement("warehouseCode")]
	        public string WarehouseCode { get; set; }
}

	/// <summary>
/// PackageMaterialDomain Data Structure.
/// </summary>
[Serializable]
public class PackageMaterialDomain
{
	        /// <summary>
	        /// 包材的数量
	        /// </summary>
	        [XmlElement("quantity")]
	        public Nullable<long> Quantity { get; set; }
	
	        /// <summary>
	        /// 包材型号
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
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
	        /// 包裹内该商品的数量
	        /// </summary>
	        [XmlElement("quantity")]
	        public Nullable<long> Quantity { get; set; }
}

	/// <summary>
/// PackageDomain Data Structure.
/// </summary>
[Serializable]
public class PackageDomain
{
	        /// <summary>
	        /// 运单号
	        /// </summary>
	        [XmlElement("expressCode")]
	        public string ExpressCode { get; set; }
	
	        /// <summary>
	        /// 包裹高度(厘米)
	        /// </summary>
	        [XmlElement("height")]
	        public string Height { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlArray("items")]
	        [XmlArrayItem("item")]
	        public List<ItemDomain> Items { get; set; }
	
	        /// <summary>
	        /// 包裹长度(厘米)
	        /// </summary>
	        [XmlElement("length")]
	        public string Length { get; set; }
	
	        /// <summary>
	        /// 物流公司名称
	        /// </summary>
	        [XmlElement("logisticsName")]
	        public string LogisticsName { get; set; }
	
	        /// <summary>
	        /// 包裹编号
	        /// </summary>
	        [XmlElement("packageCode")]
	        public string PackageCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlArray("packageMaterialList")]
	        [XmlArrayItem("package_material")]
	        public List<PackageMaterialDomain> PackageMaterialList { get; set; }
	
	        /// <summary>
	        /// 包裹体积(升)
	        /// </summary>
	        [XmlElement("volume")]
	        public string Volume { get; set; }
	
	        /// <summary>
	        /// 包裹重量(千克)
	        /// </summary>
	        [XmlElement("weight")]
	        public string Weight { get; set; }
	
	        /// <summary>
	        /// 包裹宽度(厘米)
	        /// </summary>
	        [XmlElement("width")]
	        public string Width { get; set; }
}

	/// <summary>
/// BatchDomain Data Structure.
/// </summary>
[Serializable]
public class BatchDomain
{
	        /// <summary>
	        /// 实发数量
	        /// </summary>
	        [XmlElement("actualQty")]
	        public Nullable<long> ActualQty { get; set; }
	
	        /// <summary>
	        /// 批次编号
	        /// </summary>
	        [XmlElement("batchCode")]
	        public string BatchCode { get; set; }
	
	        /// <summary>
	        /// 过期日期
	        /// </summary>
	        [XmlElement("expireDate")]
	        public string ExpireDate { get; set; }
	
	        /// <summary>
	        /// 库存类型
	        /// </summary>
	        [XmlElement("inventoryType")]
	        public string InventoryType { get; set; }
	
	        /// <summary>
	        /// 生产批号
	        /// </summary>
	        [XmlElement("produceCode")]
	        public string ProduceCode { get; set; }
	
	        /// <summary>
	        /// 生产日期
	        /// </summary>
	        [XmlElement("productDate")]
	        public string ProductDate { get; set; }
}

	/// <summary>
/// OrderLineDomain Data Structure.
/// </summary>
[Serializable]
public class OrderLineDomain
{
	        /// <summary>
	        /// 实发商品数量
	        /// </summary>
	        [XmlElement("actualQty")]
	        public Nullable<long> ActualQty { get; set; }
	
	        /// <summary>
	        /// 批次编号
	        /// </summary>
	        [XmlElement("batchCode")]
	        public string BatchCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlArray("batchs")]
	        [XmlArrayItem("batch")]
	        public List<BatchDomain> Batchs { get; set; }
	
	        /// <summary>
	        /// 过期日期
	        /// </summary>
	        [XmlElement("expireDate")]
	        public string ExpireDate { get; set; }
	
	        /// <summary>
	        /// 库存类型
	        /// </summary>
	        [XmlElement("inventoryType")]
	        public string InventoryType { get; set; }
	
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
	        /// 商品名称
	        /// </summary>
	        [XmlElement("itemName")]
	        public string ItemName { get; set; }
	
	        /// <summary>
	        /// 单据行号
	        /// </summary>
	        [XmlElement("orderLineNo")]
	        public string OrderLineNo { get; set; }
	
	        /// <summary>
	        /// 外部业务编码
	        /// </summary>
	        [XmlElement("outBizCode")]
	        public string OutBizCode { get; set; }
	
	        /// <summary>
	        /// 生产批号
	        /// </summary>
	        [XmlElement("produceCode")]
	        public string ProduceCode { get; set; }
	
	        /// <summary>
	        /// 生产日期
	        /// </summary>
	        [XmlElement("productDate")]
	        public string ProductDate { get; set; }
}

        #endregion
    }
}
