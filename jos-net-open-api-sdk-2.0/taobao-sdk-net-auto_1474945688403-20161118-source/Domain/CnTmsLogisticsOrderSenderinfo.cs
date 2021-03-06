using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// CnTmsLogisticsOrderSenderinfo Data Structure.
    /// </summary>
    [Serializable]
    public class CnTmsLogisticsOrderSenderinfo : TopObject
    {
        /// <summary>
        /// 发件人地址
        /// </summary>
        [XmlElement("sender_address")]
        public string SenderAddress { get; set; }

        /// <summary>
        /// 发件人区县
        /// </summary>
        [XmlElement("sender_area")]
        public string SenderArea { get; set; }

        /// <summary>
        /// 发件人城市
        /// </summary>
        [XmlElement("sender_city")]
        public string SenderCity { get; set; }

        /// <summary>
        /// 发件人手机，手机与电话必须有一值不为空
        /// </summary>
        [XmlElement("sender_mobile")]
        public string SenderMobile { get; set; }

        /// <summary>
        /// 发件人姓名
        /// </summary>
        [XmlElement("sender_name")]
        public string SenderName { get; set; }

        /// <summary>
        /// 发件人电话，手机与电话必须有一值不为空
        /// </summary>
        [XmlElement("sender_phone")]
        public string SenderPhone { get; set; }

        /// <summary>
        /// 发件人省份
        /// </summary>
        [XmlElement("sender_province")]
        public string SenderProvince { get; set; }

        /// <summary>
        /// 发件人邮编
        /// </summary>
        [XmlElement("sender_zip_code")]
        public string SenderZipCode { get; set; }
    }
}
