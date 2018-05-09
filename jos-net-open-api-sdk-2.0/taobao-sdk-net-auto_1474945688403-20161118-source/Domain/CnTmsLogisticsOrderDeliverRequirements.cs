using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// CnTmsLogisticsOrderDeliverRequirements Data Structure.
    /// </summary>
    [Serializable]
    public class CnTmsLogisticsOrderDeliverRequirements : TopObject
    {
        /// <summary>
        /// 配送类型： PTPS-普通配送 LLPS-冷链配送
        /// </summary>
        [XmlElement("delivery_type")]
        public string DeliveryType { get; set; }

        /// <summary>
        /// 送达日期（格式为 yyyy-MM-dd)
        /// </summary>
        [XmlElement("schedule_day")]
        public string ScheduleDay { get; set; }

        /// <summary>
        /// 送达结束时间（格式为 hh:mm）
        /// </summary>
        [XmlElement("schedule_end")]
        public string ScheduleEnd { get; set; }

        /// <summary>
        /// 送达开始时间（格式为 hh:mm）
        /// </summary>
        [XmlElement("schedule_start")]
        public string ScheduleStart { get; set; }

        /// <summary>
        /// 投递时延要求(1 工作日 2 节假日 104 预约达 )
        /// </summary>
        [XmlElement("schedule_type")]
        public string ScheduleType { get; set; }
    }
}
