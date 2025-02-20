﻿namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Events
{
    /// <summary>
    /// <para>表示 verify_webhook 事件的数据。</para>
    /// <para>REF: https://open.douyin.com/platform/doc/6850452582826067975 </para>
    /// </summary>
    public class VerifyWebhookEvent : TikTokEvent<VerifyWebhookEvent.Types.Content>
    {
        public static class Types
        {
            public class Content
            {
                /// <summary>
                /// 获取或设置验证信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("challenge")]
                [System.Text.Json.Serialization.JsonPropertyName("challenge")]
                public int Challenge { get; set; }
            }
        }
    }
}
