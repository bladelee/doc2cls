using System;
using System.Xml.Serialization;
using Wms.Common;

namespace Wms.CallBack.Request
{
/// <summary>
/// 心跳接口
/// service.heartbeat
/// </summary>
[Serializable]
[XmlRoot("request")]
public class QMServiceHeartBeatRequest
{
/// <summary>
/// 序列号
/// </summary>
[XmlElement("serialNumber", typeof(string))]
public string SerialNumber { get; set; }
}
}
