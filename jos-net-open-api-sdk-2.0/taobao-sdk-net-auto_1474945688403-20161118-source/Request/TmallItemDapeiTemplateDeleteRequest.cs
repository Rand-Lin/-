using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.item.dapei.template.delete
    /// </summary>
    public class TmallItemDapeiTemplateDeleteRequest : BaseTopRequest<Top.Api.Response.TmallItemDapeiTemplateDeleteResponse>
    {
        /// <summary>
        /// 搭配模板ID
        /// </summary>
        public Nullable<long> Id { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "tmall.item.dapei.template.delete";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("id", this.Id);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("id", this.Id);
        }

        #endregion
    }
}
