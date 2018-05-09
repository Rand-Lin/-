using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// LogisticsOrdersDetailGetResponse.
    /// </summary>
    public class LogisticsOrdersDetailGetResponse : TopResponse
    {
        /// <summary>
        /// 获取的物流订单详情列表.返回的Shipping包含的具体信息为入参fields请求的字段信息.
        /// </summary>
        [XmlArray("shippings")]
        [XmlArrayItem("shipping")]
        public List<Top.Api.Domain.Shipping> Shippings { get; set; }

        /// <summary>
        /// 搜索到的物流订单列表总数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }

    }
}
