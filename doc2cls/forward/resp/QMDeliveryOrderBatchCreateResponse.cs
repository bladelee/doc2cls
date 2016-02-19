using System;
using System.Xml.Serialization;

namespace Wms.Response.QM
{
/// <summary>
/// 发货单创建接口 （批量）
/// taobao.qimen.deliveryorder.batchcreate
/// </summary>
[Serializable]
[XmlRoot("response")]
public class QMDeliveryOrderBatchCreateResponse
{
/// <summary>
/// success|failure,只要有一个失败flag就置为failure,如果是success,就忽略下面的orders节点
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

[XmlArray("orders")]
[XmlArrayItem("order", typeof(QMDeliveryOrderBatchCreateResponseOrder))]
public QMDeliveryOrderBatchCreateResponseOrder[] Orders {get; set;}
}
[Serializable]
public class QMDeliveryOrderBatchCreateResponseOrder
{
/// <summary>
/// 出错的出库单号
/// </summary>
[XmlElement("deliveryOrderCode", typeof(string))]
public string DeliveryOrderCode { get; set; }
/// <summary>
/// 出错信息
/// </summary>
[XmlElement("message", typeof(string))]
public string Message { get; set; }
}
}
