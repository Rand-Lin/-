using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TmcMessageProduceResponse.
    /// </summary>
    public class TmcMessageProduceResponse : TopResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 投递目标数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }

    }
}
