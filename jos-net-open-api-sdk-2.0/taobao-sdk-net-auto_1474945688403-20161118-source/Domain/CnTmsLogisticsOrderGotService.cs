using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// CnTmsLogisticsOrderGotService Data Structure.
    /// </summary>
    [Serializable]
    public class CnTmsLogisticsOrderGotService : TopObject
    {
        /// <summary>
        /// 揽收日期yyyyMMdd
        /// </summary>
        [XmlElement("got_date")]
        public string GotDate { get; set; }

        /// <summary>
        /// 揽收时间段 09:00-10:00
        /// </summary>
        [XmlElement("got_range")]
        public string GotRange { get; set; }
    }
}
