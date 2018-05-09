using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AlibabaWttOrderContractSubscribeResponse.
    /// </summary>
    public class AlibabaWttOrderContractSubscribeResponse : TopResponse
    {
        /// <summary>
        /// 合约产生陈宫
        /// </summary>
        [XmlElement("issuccess")]
        public bool Issuccess { get; set; }

    }
}
