using System;
using System.Xml.Serialization;

namespace Wms.Response.QM
{
/// <summary>
/// 单据挂起（恢复）接口
/// taobao.qimen.order.pending
/// </summary>
[Serializable]
[XmlRoot("response")]
public class QMOrderPendingResponse
{
/// <summary>
/// success|failure
/// </summary>
[XmlElement("flag", typeof(string))]
public string Flag { get; set; }
/// <summary>
/// 响应码
/// </summary>
[XmlElement("code", typeof(string))]
public string Code { get; set; }
/// <summary>
/// 响应信息
/// </summary>
[XmlElement("message", typeof(string))]
public string Message { get; set; }
}
}
