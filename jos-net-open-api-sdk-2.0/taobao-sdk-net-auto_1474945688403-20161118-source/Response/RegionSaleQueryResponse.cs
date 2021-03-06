using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// RegionSaleQueryResponse.
    /// </summary>
    public class RegionSaleQueryResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public BaseResultDomain Result { get; set; }

	/// <summary>
/// BaseResultDomain Data Structure.
/// </summary>
[Serializable]
public class BaseResultDomain : TopObject
{
	        /// <summary>
	        /// data
	        /// </summary>
	        [XmlElement("data")]
	        public string Data { get; set; }
	
	        /// <summary>
	        /// errorCode
	        /// </summary>
	        [XmlElement("error_code")]
	        public string ErrorCode { get; set; }
	
	        /// <summary>
	        /// errorMsg
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// success
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
