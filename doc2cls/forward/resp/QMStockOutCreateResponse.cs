using System;
using System.Xml.Serialization;

namespace Wms.Response.QM
{
/// <summary>
/// 出库单创建接口
/// taobao.qimen.stockout.create
/// </summary>
[Serializable]
[XmlRoot("response")]
public class QMStockOutCreateResponse
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
/// 出库单仓储系统编码
/// </summary>
[XmlElement("deliveryOrderId", typeof(string))]
public string DeliveryOrderId { get; set; }
/// <summary>
/// 订单创建时间, YYYY-MM-DD HH:MM:SS
/// </summary>
[XmlElement("createTime", typeof(string))]
public string CreateTime { get; set; }
}
}
