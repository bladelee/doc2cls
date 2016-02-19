using System;
using System.Xml.Serialization;

namespace Wms.Response.QM
{
/// <summary>
/// 菜鸟自动流转查询接口  （扩展）
/// taobao.qimen.autotransfer.query
/// </summary>
[Serializable]
[XmlRoot("response")]
public class QMAutoTransferQueryResponse
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

[XmlArray("orderLines")]
[XmlArrayItem("orderLine", typeof(QMAutoTransferQueryResponseOrderLine))]
public QMAutoTransferQueryResponseOrderLine[] OrderLines {get; set;}
}
[Serializable]
public class QMAutoTransferQueryResponseOrderLine
{
/// <summary>
/// 单据行号
/// </summary>
[XmlElement("orderLineNo", typeof(string))]
public string OrderLineNo { get; set; }
/// <summary>
/// 交易平台子订单编码
/// </summary>
[XmlElement("subSourceOrderCode", typeof(string))]
public string SubSourceOrderCode { get; set; }
/// <summary>
/// 仓库编码
/// </summary>
[XmlElement("warehouseCode", typeof(string))]
public string WarehouseCode { get; set; }
/// <summary>
/// 菜鸟物流编码(LBX号) 
/// </summary>
[XmlElement("deliveryOrderId", typeof(string))]
public string DeliveryOrderId { get; set; }
/// <summary>
/// 应发商品数量
/// </summary>
[XmlElement("planQty", typeof(int?), IsNullable = true)]
public int? PlanQty { get; set; }
/// <summary>
/// 订单路由状态 ,状态值：WAIT_ROUTE 待路由仓 ;ROUTE_TO_CN 路由到菜鸟仓发货 ;ROUTE_TO_ERP 路由到商家仓发货;STOP_ROUTE 终止分仓。如订单已取消时,不再发货。 注：待路由仓状态表示未做路由,不确定由哪个仓库发货,可于5分钟后再次查询
/// </summary>
[XmlElement("status", typeof(string))]
public string Status { get; set; }
}
}
