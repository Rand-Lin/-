using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallItemDapeiTemplateDeleteResponse.
    /// </summary>
    public class TmallItemDapeiTemplateDeleteResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public ResultSetDomain Result { get; set; }

	/// <summary>
/// ResultSetDomain Data Structure.
/// </summary>
[Serializable]
public class ResultSetDomain : TopObject
{
	        /// <summary>
	        /// error
	        /// </summary>
	        [XmlElement("error")]
	        public bool Error { get; set; }
	
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
	        /// firstResult
	        /// </summary>
	        [XmlElement("first_result")]
	        public long FirstResult { get; set; }
}

    }
}
