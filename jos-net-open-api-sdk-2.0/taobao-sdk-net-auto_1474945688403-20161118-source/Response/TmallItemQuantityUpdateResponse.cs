using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallItemQuantityUpdateResponse.
    /// </summary>
    public class TmallItemQuantityUpdateResponse : TopResponse
    {
        /// <summary>
        /// 库存更新结果，商品id
        /// </summary>
        [XmlElement("quantity_update_result")]
        public string QuantityUpdateResult { get; set; }

    }
}
