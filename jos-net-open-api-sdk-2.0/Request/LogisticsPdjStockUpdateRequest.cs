using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class LogisticsPdjStockUpdateRequest : IJdRequest<LogisticsPdjStockUpdateResponse>
{
		                                                                                                       
public   		string
   outerSkuId  { get; set; }

                  
                                                            
                                                          
public   		Nullable<long>
   skuId  { get; set; }

                  
                                                            
                                                          
public   		string
   stationNo  { get; set; }

                  
                                                            
                                                          
public   		string
   outerStationNo  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   stockNum  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   businessNo  { get; set; }

                  
                                                            

		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.logistics.pdj.stock.update";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("outerSkuId", this.outerSkuId);
			parameters.Add("skuId", this.skuId);
			parameters.Add("stationNo", this.stationNo);
			parameters.Add("outerStationNo", this.outerStationNo);
			parameters.Add("stockNum", this.stockNum);
			parameters.Add("businessNo", this.businessNo);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
        }

        public void AddOtherParameter(string key, string value)
        {
            if (this.otherParameters == null)
            {
                this.otherParameters = new JdDictionary();
            }
            this.otherParameters.Add(key, value);
        }

}
}








        
 

