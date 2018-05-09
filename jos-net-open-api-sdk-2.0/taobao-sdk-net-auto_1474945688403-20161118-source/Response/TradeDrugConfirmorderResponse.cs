using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TradeDrugConfirmorderResponse.
    /// </summary>
    public class TradeDrugConfirmorderResponse : TopResponse
    {
        /// <summary>
        /// life的返回值
        /// </summary>
        [XmlElement("result")]
        public LifeResultDoDomain Result { get; set; }

	/// <summary>
/// LifeResultDoDomain Data Structure.
/// </summary>
[Serializable]
public class LifeResultDoDomain : TopObject
{
	        /// <summary>
	        /// errorCode
	        /// </summary>
	        [XmlElement("error_code")]
	        public string ErrorCode { get; set; }
	
	        /// <summary>
	        /// RT
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// 描述信息
	        /// </summary>
	        [XmlElement("info")]
	        public string Info { get; set; }
	
	        /// <summary>
	        /// 1代表成功！
	        /// </summary>
	        [XmlElement("ret_code")]
	        public string RetCode { get; set; }
	
	        /// <summary>
	        /// 是不是成功！
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
