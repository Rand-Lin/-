using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// DeliveryTemplateUpdateResponse.
    /// </summary>
    public class DeliveryTemplateUpdateResponse : TopResponse
    {
        /// <summary>
        /// 表示修改是否成功
        /// </summary>
        [XmlElement("complete")]
        public bool Complete { get; set; }

    }
}
