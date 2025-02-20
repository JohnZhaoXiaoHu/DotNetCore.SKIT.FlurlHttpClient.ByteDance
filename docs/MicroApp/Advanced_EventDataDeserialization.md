﻿## 如何解析回调通知事件？

---

对于字节小程序推送过来的回调通知事件，本库封装了直接解析成事件模型的扩展方法，下面给出一个示例：

```csharp
/* 如果是 JSON 格式的通知内容，以 text 事件为例 */
string callbackJson = "{ ... }";
var callbackModel = client.DeserializeEventFromJson<Events.TextMessageEvent>(callbackJson);

/* 如果是 XML 格式的通知内容，以 text 事件为例 */
string callbackXml = "<xml> ... </xml>";
var callbackModel = client.DeserializeEventFromXml<Events.TextMessageEvent>(callbackXml);
```

完整的回调通知模型定义可以参考项目目录下的 _src/SKIT.FlurlHttpClient.ByteDance.MicroApp/Events_ 目录。

---

### 事件类型：

由于字节小程序会将全部事件推送到同一个回调通知地址上，开发者需要根据事件类型才能决定如何反序列化。

这里给出两种解决方案。

一种是利用 `System.Xml.Linq`：

```csharp
XDocument xDoc = XDocument.Parse(callbackXml);
string msgType = xDoc.Root?.Element("MsgType")?.Value?.ToUpper();
```

另一种是利用本库的扩展方法：

```csharp
ByteDanceMicroAppEvent eventModel = client.DeserializeEventFromXml(callbackXml);
string msgType = eventModel.MessageType?.ToUpper();

switch (msgType)
{
    case "TEXT":
        {
            var callbackModel = client.DeserializeEventFromXml<Events.TextMessageEvent>(callbackXml);
        }
        break;
    // 省略其他情况
}
```
