using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AlibabaTianjiDistributorOrderSubmitResponse.
    /// </summary>
    public class AlibabaTianjiDistributorOrderSubmitResponse : TopResponse
    {
        /// <summary>
        /// 接口结果
        /// </summary>
        [XmlElement("result")]
        public CommonResultDomain Result { get; set; }

	/// <summary>
/// CommonResultDomain Data Structure.
/// </summary>
[Serializable]
public class CommonResultDomain : TopObject
{
	        /// <summary>
	        /// 错误码
	        /// </summary>
	        [XmlElement("code")]
	        public string Code { get; set; }
	
	        /// <summary>
	        /// 错误描述
	        /// </summary>
	        [XmlElement("desc")]
	        public string Desc { get; set; }
	
	        /// <summary>
	        /// 是否成功
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
