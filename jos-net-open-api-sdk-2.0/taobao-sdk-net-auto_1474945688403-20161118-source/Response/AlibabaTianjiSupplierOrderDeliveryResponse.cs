using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AlibabaTianjiSupplierOrderDeliveryResponse.
    /// </summary>
    public class AlibabaTianjiSupplierOrderDeliveryResponse : TopResponse
    {
        /// <summary>
        /// 发货是否成功
        /// </summary>
        [XmlElement("model")]
        public bool Model { get; set; }

    }
}
