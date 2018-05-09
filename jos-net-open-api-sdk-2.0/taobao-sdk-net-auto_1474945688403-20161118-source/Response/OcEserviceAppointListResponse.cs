using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// OcEserviceAppointListResponse.
    /// </summary>
    public class OcEserviceAppointListResponse : TopResponse
    {
        /// <summary>
        /// 返回的预约信息，多个预约信息按照预约时间升序排序
        /// </summary>
        [XmlArray("models")]
        [XmlArrayItem("o2o_appoint_info_dto")]
        public List<O2oAppointInfoDtoDomain> Models { get; set; }

        /// <summary>
        /// 返回的预约信息数目
        /// </summary>
        [XmlElement("total_number")]
        public long TotalNumber { get; set; }

	/// <summary>
/// O2oAppointInfoParamDomain Data Structure.
/// </summary>
[Serializable]
public class O2oAppointInfoParamDomain : TopObject
{
	        /// <summary>
	        /// 预约属性名信息
	        /// </summary>
	        [XmlElement("param_name")]
	        public string ParamName { get; set; }
	
	        /// <summary>
	        /// 预约属性值信息
	        /// </summary>
	        [XmlElement("param_value")]
	        public string ParamValue { get; set; }
}

	/// <summary>
/// O2oAppointInfoDtoDomain Data Structure.
/// </summary>
[Serializable]
public class O2oAppointInfoDtoDomain : TopObject
{
	        /// <summary>
	        /// 预约信息唯一编码，如果使用此参数，customer_nick和mall_code参数不会使用
	        /// </summary>
	        [XmlElement("appoint_code")]
	        public long AppointCode { get; set; }
	
	        /// <summary>
	        /// 预约属性信息列表
	        /// </summary>
	        [XmlArray("appoint_info_params")]
	        [XmlArrayItem("o2o_appoint_info_param")]
	        public List<O2oAppointInfoParamDomain> AppointInfoParams { get; set; }
}

    }
}
