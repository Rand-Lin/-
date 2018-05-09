using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.item.dapei.template.get
    /// </summary>
    public class TmallItemDapeiTemplateGetRequest : BaseTopRequest<Top.Api.Response.TmallItemDapeiTemplateGetResponse>
    {
        #region ITopRequest Members

        public override string GetApiName()
        {
            return "tmall.item.dapei.template.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

        #endregion
    }
}
