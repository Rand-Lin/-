using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallItemDapeiTemplateGetResponse.
    /// </summary>
    public class TmallItemDapeiTemplateGetResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public ResultDomain Result { get; set; }

	/// <summary>
/// DapeiTemplateItemDomain Data Structure.
/// </summary>
[Serializable]
public class DapeiTemplateItemDomain : TopObject
{
	        /// <summary>
	        /// img
	        /// </summary>
	        [XmlElement("img")]
	        public string Img { get; set; }
	
	        /// <summary>
	        /// itemId
	        /// </summary>
	        [XmlElement("item_id")]
	        public long ItemId { get; set; }
}

	/// <summary>
/// DapeiDomain Data Structure.
/// </summary>
[Serializable]
public class DapeiDomain : TopObject
{
	        /// <summary>
	        /// desc
	        /// </summary>
	        [XmlElement("desc")]
	        public string Desc { get; set; }
	
	        /// <summary>
	        /// id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// items
	        /// </summary>
	        [XmlArray("items")]
	        [XmlArrayItem("dapei_template_item")]
	        public List<DapeiTemplateItemDomain> Items { get; set; }
	
	        /// <summary>
	        /// title
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// url
	        /// </summary>
	        [XmlElement("url")]
	        public string Url { get; set; }
}

	/// <summary>
/// ResultDomain Data Structure.
/// </summary>
[Serializable]
public class ResultDomain : TopObject
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
	        [XmlArray("results")]
	        [XmlArrayItem("dapei")]
	        public List<DapeiDomain> Results { get; set; }
}

    }
}
