﻿namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /video/part/upload 接口的请求。</para>
    /// </summary>
    public class VideoPartUploadRequest : VideoUploadRequest
    {
        /// <summary>
        /// 获取或设置上传 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string UploadId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置分片编号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int PartNumber { get; set; }
    }
}
