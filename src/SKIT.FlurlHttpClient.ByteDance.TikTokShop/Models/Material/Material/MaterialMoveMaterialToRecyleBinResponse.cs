﻿using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /material/moveMaterialToRecycleBin 接口的响应。</para>
    /// </summary>
    public class MaterialMoveMaterialToRecyleBinResponse : TikTokShopResponse<MaterialMoveMaterialToRecyleBinResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class FailReason : MaterialDeleteMaterialResponse.Types.Data.Types.FailReason
                    {
                    }
                }

                /// <summary>
                /// 获取或设置删除成功的素材 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("success_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("success_ids")]
                public string[] SucceedObjectIdList { get; set; } = default!;

                /// <summary>
                /// 获取或设置删除失败的素材字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("failed_map")]
                [System.Text.Json.Serialization.JsonPropertyName("failed_map")]
                public IDictionary<string, Types.FailReason> FailedObjectMap { get; set; } = default!;
            }
        }
    }
}
