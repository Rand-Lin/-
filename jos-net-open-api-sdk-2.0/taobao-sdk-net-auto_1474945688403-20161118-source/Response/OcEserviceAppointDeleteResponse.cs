using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// OcEserviceAppointDeleteResponse.
    /// </summary>
    public class OcEserviceAppointDeleteResponse : TopResponse
    {
        /// <summary>
        /// 删除的记录的数目
        /// </summary>
        [XmlElement("model")]
        public long Model { get; set; }

    }
}
