using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Responsewlbwmsstockinorderconfirm Data Structure.
    /// </summary>
    [Serializable]
    public class Responsewlbwmsstockinorderconfirm : TopObject
    {
        /// <summary>
        /// 错误编码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误详细
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
