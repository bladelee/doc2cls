using System;
using System.Xml.Serialization;

namespace Wms.Response.QM
{
/// <summary>
/// 发货单创建接口
/// taobao.qimen.deliveryorder.create
/// </summary>
[Serializable]
[XmlRoot("response")]
public class QMDeliveryOrderCreateResponse
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
/// 订单创建时间, YYYY-MM-DD HH:MM:SS
/// </summary>
[XmlElement("createTime", typeof(string))]
public string CreateTime { get; set; }
/// <summary>
/// 出库单仓储系统编码
/// </summary>
[XmlElement("deliveryOrderId", typeof(string))]
public string DeliveryOrderId { get; set; }
/// <summary>
/// 仓库编码(统仓统配使用)
/// </summary>
[XmlElement("warehouseCode", typeof(string))]
public string WarehouseCode { get; set; }
/// <summary>
/// 物流公司编码(统仓统配使用)
/// </summary>
[XmlElement("logisticsCode", typeof(string))]
public string LogisticsCode { get; set; }

[XmlArray("deliveryOrders")]
[XmlArrayItem("deliveryOrder", typeof(QMDeliveryOrderCreateResponseDeliveryOrder))]
public QMDeliveryOrderCreateResponseDeliveryOrder[] DeliveryOrders {get; set;}
}
[Serializable]
public class QMDeliveryOrderCreateResponseDeliveryOrder
{
/// <summary>
/// 出库单仓储系统编码
/// </summary>
[XmlElement("deliveryOrderId", typeof(string))]
public string DeliveryOrderId { get; set; }
/// <summary>
/// 仓库编码(统仓统配使用)
/// </summary>
[XmlElement("warehouseCode", typeof(string))]
public string WarehouseCode { get; set; }
/// <summary>
/// 物流公司编码(统仓统配使用)
/// </summary>
[XmlElement("logisticsCode", typeof(string))]
public string LogisticsCode { get; set; }

[XmlArray("orderLines")]
[XmlArrayItem("orderLine", typeof(QMDeliveryOrderCreateResponseDeliveryOrderOrderLine))]
public QMDeliveryOrderCreateResponseDeliveryOrderOrderLine[] OrderLines {get; set;}
/// <summary>
/// 订单创建时间, YYYY-MM-DD HH:MM:SS
/// </summary>
[XmlElement("createTime", typeof(string))]
public string CreateTime { get; set; }
}
[Serializable]
public class QMDeliveryOrderCreateResponseDeliveryOrderOrderLine
{
/// <summary>
/// 行号
/// </summary>
[XmlElement("orderLineNo", typeof(string))]
public string OrderLineNo { get; set; }
/// <summary>
/// ERP商品编码
/// </summary>
[XmlElement("itemCode", typeof(string))]
public string ItemCode { get; set; }
/// <summary>
/// WMS商品编码
/// </summary>
[XmlElement("itemId", typeof(string))]
public string ItemId { get; set; }
/// <summary>
/// 数量
/// </summary>
[XmlElement("quantity", typeof(string))]
public string Quantity { get; set; }
}
}
