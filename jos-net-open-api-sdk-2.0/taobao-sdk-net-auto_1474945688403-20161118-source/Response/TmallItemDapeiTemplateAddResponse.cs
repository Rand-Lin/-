using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallItemDapeiTemplateAddResponse.
    /// </summary>
    public class TmallItemDapeiTemplateAddResponse : TopResponse
    {
        /// <summary>
        /// 新创建搭配模板的ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

    }
}
