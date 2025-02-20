﻿using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/ecpay/saas/get_app_merchant 接口的请求。</para>
    /// </summary>
    public class AppsECPaySaaSGetAppMerchantRequest : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// 获取或设置字节小程序的 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("component_access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("component_access_token")]
        public override string? AccessToken { get; set; }

        /// <summary>
        /// 获取或设置小程序第三方平台应用 ID。如果不指定将使用构造 <see cref="ByteDanceMicroAppClient"/> 时的 <see cref="ByteDanceMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("thirdparty_id")]
        [System.Text.Json.Serialization.JsonPropertyName("thirdparty_id")]
        public string? ComponentAppId { get; set; }

        /// <summary>
        /// 获取或设置小程序的 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置 URL 类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url_type")]
        [System.Text.Json.Serialization.JsonPropertyName("url_type")]
        public int UrlType { get; set; }

        /// <summary>
        /// 获取或设置签名。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign")]
        [System.Text.Json.Serialization.JsonPropertyName("sign")]
        public string? Signature { get; set; }
    }
}
