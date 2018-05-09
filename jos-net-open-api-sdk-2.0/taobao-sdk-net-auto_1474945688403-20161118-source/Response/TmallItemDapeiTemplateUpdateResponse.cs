using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallItemDapeiTemplateUpdateResponse.
    /// </summary>
    public class TmallItemDapeiTemplateUpdateResponse : TopResponse
    {
        /// <summary>
        /// 被更新模板ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

    }
}
