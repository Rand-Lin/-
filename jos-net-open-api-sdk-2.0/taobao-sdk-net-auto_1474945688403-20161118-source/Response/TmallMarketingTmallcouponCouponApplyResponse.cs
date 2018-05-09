using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallMarketingTmallcouponCouponApplyResponse.
    /// </summary>
    public class TmallMarketingTmallcouponCouponApplyResponse : TopResponse
    {
        /// <summary>
        /// 业务请求标识
        /// </summary>
        [XmlElement("instance_id")]
        public string InstanceId { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("succ")]
        public bool Succ { get; set; }

    }
}
