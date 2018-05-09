using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// OcEserviceAppointSaveResponse.
    /// </summary>
    public class OcEserviceAppointSaveResponse : TopResponse
    {
        /// <summary>
        /// 服务约定卡的唯一标识
        /// </summary>
        [XmlElement("model")]
        public long Model { get; set; }

    }
}
