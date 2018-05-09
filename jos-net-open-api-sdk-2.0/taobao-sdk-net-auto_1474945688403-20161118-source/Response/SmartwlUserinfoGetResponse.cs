using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// SmartwlUserinfoGetResponse.
    /// </summary>
    public class SmartwlUserinfoGetResponse : TopResponse
    {
        /// <summary>
        /// 商家是否已经制定智选物流方案
        /// </summary>
        [XmlElement("solution_enabled")]
        public bool SolutionEnabled { get; set; }

        /// <summary>
        /// 商家是否已经开通智选物流
        /// </summary>
        [XmlElement("user_enabled")]
        public bool UserEnabled { get; set; }

    }
}
