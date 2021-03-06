using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// FenxiaoRefundMessageAddResponse.
    /// </summary>
    public class FenxiaoRefundMessageAddResponse : TopResponse
    {
        /// <summary>
        /// 退款是否创建成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

    }
}
