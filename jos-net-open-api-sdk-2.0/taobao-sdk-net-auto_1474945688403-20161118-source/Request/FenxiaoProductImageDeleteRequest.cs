using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.product.image.delete
    /// </summary>
    public class FenxiaoProductImageDeleteRequest : BaseTopRequest<Top.Api.Response.FenxiaoProductImageDeleteResponse>
    {
        /// <summary>
        /// 图片位置
        /// </summary>
        public Nullable<long> Position { get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        public Nullable<long> ProductId { get; set; }

        /// <summary>
        /// properties表示sku图片的属性。key:value形式，key是pid，value是vid。如果position是0的话，则properties需要是必传项
        /// </summary>
        public string Properties { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.fenxiao.product.image.delete";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("position", this.Position);
            parameters.Add("product_id", this.ProductId);
            parameters.Add("properties", this.Properties);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("position", this.Position);
            RequestValidator.ValidateRequired("product_id", this.ProductId);
        }

        #endregion
    }
}
