﻿using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/ecpay/saas/app_add_sub_merchant 接口的响应。</para>
    /// </summary>
    public class AppsECPaySaaSAppAddSubMerchantResponse : ByteDanceMicroAppResponse
    {
        /// <summary>
        /// 获取或设置请求页面链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_id")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; } = default!;
    }
}
