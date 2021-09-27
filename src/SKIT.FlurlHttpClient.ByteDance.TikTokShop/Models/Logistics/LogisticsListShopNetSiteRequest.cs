﻿namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /logistics/listShopNetsite 接口的请求。</para>
    /// </summary>
    public class LogisticsListShopNetSiteRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置快递公司编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logistics_code")]
        [System.Text.Json.Serialization.JsonPropertyName("logistics_code")]
        public string LogisticsCompanyCode { get; set; } = string.Empty;

        internal protected override string GetApiMethod()
        {
            return string.Intern("logistics.listShopNetsite");
        }
    }
}
