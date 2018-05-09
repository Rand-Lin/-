using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// DistributionOrderModel Data Structure.
    /// </summary>
    [Serializable]
    public class DistributionOrderModel : TopObject
    {
        /// <summary>
        /// 分销商用户ID
        /// </summary>
        [XmlElement("distributor_id")]
        public Nullable<long> DistributorId { get; set; }

        /// <summary>
        /// 手机串码
        /// </summary>
        [XmlElement("item_serial_no")]
        public string ItemSerialNo { get; set; }

        /// <summary>
        /// 订单号码
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
