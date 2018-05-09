using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// RegionPriceManageResponse.
    /// </summary>
    public class RegionPriceManageResponse : TopResponse
    {
        /// <summary>
        /// success
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// errorCode
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// errorMsg
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }

    }
}
