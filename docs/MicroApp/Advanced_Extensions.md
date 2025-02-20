﻿## 如何扩展额外的 API？

---

如果有某些接口本库尚未支持，你可按照下面的示例自行扩展：

```csharp
/* 继承 ByteDanceMicroAppRequest 实现自定义请求类 */
public class MyFakeRequest : ByteDanceMicroAppRequest
{
    [Newtonsoft.Json.JsonProperty("my_fake_props")]
    [System.Text.Json.Serialization.JsonPropertyName("my_fake_props")]
    public string MyFakeProps { get; set; }
}

/* 继承 ByteDanceMicroAppResponse 实现自定义响应类 */
public class MyFakeResponse : ByteDanceMicroAppResponse
{
    [Newtonsoft.Json.JsonProperty("my_fake_props")]
    [System.Text.Json.Serialization.JsonPropertyName("my_fake_props")]
    public string MyFakeProps { get; set; }
}

/* 扩展 ByteDanceMicroAppClient 方法 */
public static class MyFakeClientExtensions
{
    public static async Task<MyFakeResponse> ExecuteMyFakeAsync(this ByteDanceMicroAppClient client, MyFakeRequest request, CancellationToken cancellationToken = default)
    {
        if (client is null) throw new ArgumentNullException(nameof(client));
        if (request is null) throw new ArgumentNullException(nameof(request));

        IFlurlRequest flurlReq = client
            .CreateRequest(request, HttpMethod.Post, "my-fake-url")
            .SetQueryParam("access_token", request.AccessToken);

        return await client.SendRequestWithJsonAsync<MyFakeResponse>(flurlReq, request, cancellationToken);
    }
}
```

同样的，你也可自行扩展回调通知事件模型：

```csharp
/* 继承 ByteDanceMicroAppEvent 实现自定义的 JSON 格式的回调通知事件 */
public class MyFakeEvent : ByteDanceMicroAppEvent, ByteDanceMicroAppEvent.Serialization.IJsonSerializable
{
    [Newtonsoft.Json.JsonProperty("my_fake_props")]
    [System.Text.Json.Serialization.JsonPropertyName("my_fake_props")]
    public string MyFakeProps { get; set; }
}

/* 继承 ByteDanceMicroAppEvent 实现自定义的 XML 格式的回调通知事件 */
public class MyFakeEvent : ByteDanceMicroAppEvent, ByteDanceMicroAppEvent.Serialization.IXmlSerializable
{
    [System.Xml.Serialization.XmlElement("my_fake_props")]
    public string MyFakeProps { get; set; }
}
```
