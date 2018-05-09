using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallItemCombineGetResponse.
    /// </summary>
    public class TmallItemCombineGetResponse : TopResponse
    {
        /// <summary>
        /// results
        /// </summary>
        [XmlArray("results")]
        [XmlArrayItem("json")]
        public List<string> Results { get; set; }

    }
}
