using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wlb.inventory.detail.get
    /// </summary>
    public class WlbInventoryDetailGetRequest : BaseTopRequest<Top.Api.Response.WlbInventoryDetailGetResponse>
    {
        /// <summary>
        /// 库存类型列表，值包括：  VENDIBLE--可销售库存  FREEZE--冻结库存  ONWAY--在途库存  DEFECT--残次品库存  ENGINE_DAMAGE--机损  BOX_DAMAGE--箱损  EXPIRATION--过保
        /// </summary>
        public string InventoryTypeList { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public Nullable<long> ItemId { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        public string StoreCode { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.wlb.inventory.detail.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("inventory_type_list", this.InventoryTypeList);
            parameters.Add("item_id", this.ItemId);
            parameters.Add("store_code", this.StoreCode);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("inventory_type_list", this.InventoryTypeList, 20);
            RequestValidator.ValidateRequired("item_id", this.ItemId);
        }

        #endregion
    }
}
