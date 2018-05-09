using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AlibabaAlitjOrderRealnamecardInfoSubmitResponse.
    /// </summary>
    public class AlibabaAlitjOrderRealnamecardInfoSubmitResponse : TopResponse
    {
        /// <summary>
        /// result
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
	        /// 目前暂无特殊作用
	        /// </summary>
	        [XmlElement("code")]
	        public string Code { get; set; }
	
	        /// <summary>
	        /// 保存操作失败原因
	        /// </summary>
	        [XmlElement("desc")]
	        public string Desc { get; set; }
	
	        /// <summary>
	        /// 操作成功或失败，只有当这个参数为True时，才表示数据已真正提交成功。
	        /// </summary>
	        [XmlElement("model")]
	        public bool Model { get; set; }
	
	        /// <summary>
	        /// 操作是否被正常处理
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
