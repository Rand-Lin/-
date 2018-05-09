using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// SmartwlAssistantGetResponse.
    /// </summary>
    public class SmartwlAssistantGetResponse : TopResponse
    {
        /// <summary>
        /// 物流商编码
        /// </summary>
        [XmlElement("cp_code")]
        public string CpCode { get; set; }

        /// <summary>
        /// 物流商Id
        /// </summary>
        [XmlElement("cp_id")]
        public long CpId { get; set; }

        /// <summary>
        /// 物流商名称
        /// </summary>
        [XmlElement("cp_name")]
        public string CpName { get; set; }

    }
}
