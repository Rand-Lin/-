using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: alibaba.tianji.supplier.order.delivery
    /// </summary>
    public class AlibabaTianjiSupplierOrderDeliveryRequest : BaseTopRequest<Top.Api.Response.AlibabaTianjiSupplierOrderDeliveryResponse>
    {
        /// <summary>
        /// 物流信息
        /// </summary>
        public string ParamDistributionOrderLogisticsModel { get; set; }

        public DistributionOrderLogisticsModelDomain ParamDistributionOrderLogisticsModel_ { set { this.ParamDistributionOrderLogisticsModel = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "alibaba.tianji.supplier.order.delivery";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("param_distribution_order_logistics_model", this.ParamDistributionOrderLogisticsModel);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

	/// <summary>
/// IdCardModelDomain Data Structure.
/// </summary>
[Serializable]
public class IdCardModelDomain : TopObject
{
	        /// <summary>
	        /// 身份证反面照
	        /// </summary>
	        [XmlElement("back_cert_pic")]
	        public string BackCertPic { get; set; }
	
	        /// <summary>
	        /// 证件失效时间
	        /// </summary>
	        [XmlElement("card_expire_date")]
	        public Nullable<DateTime> CardExpireDate { get; set; }
	
	        /// <summary>
	        /// 证件号码
	        /// </summary>
	        [XmlElement("card_number")]
	        public string CardNumber { get; set; }
	
	        /// <summary>
	        /// 证件类型
	        /// </summary>
	        [XmlElement("card_type")]
	        public string CardType { get; set; }
	
	        /// <summary>
	        /// 身份证正面照
	        /// </summary>
	        [XmlElement("face_cert_pic")]
	        public string FaceCertPic { get; set; }
	
	        /// <summary>
	        /// 手持身份证照
	        /// </summary>
	        [XmlElement("hold_cert_pic")]
	        public string HoldCertPic { get; set; }
	
	        /// <summary>
	        /// 证件名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

	/// <summary>
/// DistributionOrderLogisticsModelDomain Data Structure.
/// </summary>
[Serializable]
public class DistributionOrderLogisticsModelDomain : TopObject
{
	        /// <summary>
	        /// 需要变更的订购状态, NOT_ORDER(1, "未订购"), 未订购； ORDER_AUDIT(2, "订购中"), 无订购接口，提交给供应商，线下受理中； ON_ORDER(3, "订购中"), 有订购接口，线上受理中； FAILURE(4, "订购失败")，订购失败； SUCCESS(5, "订购成功")，订购成功； CANCEL(6, "订购取消")，订购取消
	        /// </summary>
	        [XmlElement("contract_order_status")]
	        public string ContractOrderStatus { get; set; }
	
	        /// <summary>
	        /// 分销商编号
	        /// </summary>
	        [XmlElement("distributor_id")]
	        public Nullable<long> DistributorId { get; set; }
	
	        /// <summary>
	        /// 快递公司编码
	        /// </summary>
	        [XmlElement("express_code")]
	        public string ExpressCode { get; set; }
	
	        /// <summary>
	        /// 快递名称
	        /// </summary>
	        [XmlElement("express_name")]
	        public string ExpressName { get; set; }
	
	        /// <summary>
	        /// 快递单号
	        /// </summary>
	        [XmlElement("express_number")]
	        public string ExpressNumber { get; set; }
	
	        /// <summary>
	        /// iccid
	        /// </summary>
	        [XmlElement("iccid")]
	        public string Iccid { get; set; }
	
	        /// <summary>
	        /// 身份证相关信息
	        /// </summary>
	        [XmlElement("id_card_model")]
	        public IdCardModelDomain IdCardModel { get; set; }
	
	        /// <summary>
	        /// 商品编码
	        /// </summary>
	        [XmlElement("item_serial_no")]
	        public string ItemSerialNo { get; set; }
	
	        /// <summary>
	        /// 操作时间
	        /// </summary>
	        [XmlElement("operate_time")]
	        public Nullable<DateTime> OperateTime { get; set; }
	
	        /// <summary>
	        /// 淘宝交易订单号
	        /// </summary>
	        [XmlElement("order_no")]
	        public string OrderNo { get; set; }
	
	        /// <summary>
	        /// 产品编码，如ICCID
	        /// </summary>
	        [XmlElement("product_serial_no")]
	        public string ProductSerialNo { get; set; }
	
	        /// <summary>
	        /// 失败原因
	        /// </summary>
	        [XmlElement("reason")]
	        public string Reason { get; set; }
}

        #endregion
    }
}
