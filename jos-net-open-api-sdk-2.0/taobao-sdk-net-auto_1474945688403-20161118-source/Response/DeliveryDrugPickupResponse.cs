using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// DeliveryDrugPickupResponse.
    /// </summary>
    public class DeliveryDrugPickupResponse : TopResponse
    {
        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("result")]
        public DdDeliveryResultDomain Result { get; set; }

	/// <summary>
/// DdDeliveryResultDomain Data Structure.
/// </summary>
[Serializable]
public class DdDeliveryResultDomain : TopObject
{
	        /// <summary>
	        /// 错误码
	        /// </summary>
	        [XmlElement("msg_code")]
	        public string MsgCode { get; set; }
	
	        /// <summary>
	        /// 错误信息
	        /// </summary>
	        [XmlElement("msg_info")]
	        public string MsgInfo { get; set; }
	
	        /// <summary>
	        /// 是否成功！
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
