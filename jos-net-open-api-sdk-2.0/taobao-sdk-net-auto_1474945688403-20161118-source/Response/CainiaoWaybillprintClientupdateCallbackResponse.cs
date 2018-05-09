using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// CainiaoWaybillprintClientupdateCallbackResponse.
    /// </summary>
    public class CainiaoWaybillprintClientupdateCallbackResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }

    }
}
