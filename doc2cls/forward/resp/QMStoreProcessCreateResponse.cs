using System;
using System.Xml.Serialization;

namespace Wms.Response.QM
{
/// <summary>
/// 仓内加工单创建接口
/// taobao.qimen.storeprocess.create
/// </summary>
[Serializable]
[XmlRoot("response")]
public class QMStoreProcessCreateResponse
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
/// <summary>
/// 仓储系统处理单ID
/// </summary>
[XmlElement("processOrderId", typeof(string))]
public string ProcessOrderId { get; set; }
}
}
