using System;
using System.Xml.Serialization;

namespace Wms.Response.QM
{
/// <summary>
/// 退货入库单创建接口
/// taobao.qimen.returnorder.create
/// </summary>
[Serializable]
[XmlRoot("response")]
public class QMReturnOrderCreateResponse
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
/// 仓储系统退货单编码
/// </summary>
[XmlElement("returnOrderId", typeof(string))]
public string ReturnOrderId { get; set; }
}
}
