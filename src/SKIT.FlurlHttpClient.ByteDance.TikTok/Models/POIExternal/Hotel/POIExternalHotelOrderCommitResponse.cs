﻿namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/ext/hotel/order/commit 接口的响应。</para>
    /// </summary>
    public class POIExternalHotelOrderCommitResponse : TikTokResponse<POIExternalHotelOrderCommitResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
            }
        }
        
        /// <summary>
        /// 获取或设置外部订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_ext_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_ext_id")]
        public string OrderExternalId { get; set; } = default!;
    }
}
