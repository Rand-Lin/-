using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// DrugShopListResponse.
    /// </summary>
    public class DrugShopListResponse : TopResponse
    {
        /// <summary>
        /// 数据结果集
        /// </summary>
        [XmlElement("result")]
        public Top.Api.Domain.TakeoutShopPage Result { get; set; }

    }
}
