using System;
using System.Xml.Serialization;
using Wms.Common;

namespace Wms.CallBack.Request
{
/// <summary>
/// 发货单SN通知接口
/// sn.report
/// </summary>
[Serializable]
[XmlRoot("request")]
public class QMSnReportRequest
{
/// <summary>
/// 总页数
/// </summary>
[XmlElement("totalPage", typeof(int?), IsNullable = true)]
public int? TotalPage { get; set; }
/// <summary>
/// 当前页, 从1开始
/// </summary>
[XmlElement("currentPage", typeof(int?), IsNullable = true)]
public int? CurrentPage { get; set; }
/// <summary>
/// 每页记录的条数
/// </summary>
[XmlElement("pageSize", typeof(int?), IsNullable = true)]
public int? PageSize { get; set; }

[XmlElement("deliveryOrder", typeof(QMSnReportRequestDeliveryOrder))]
public QMSnReportRequestDeliveryOrder DeliveryOrder {get; set;}

[XmlArray("items")]
[XmlArrayItem("item", typeof(QMSnReportRequestItem))]
public QMSnReportRequestItem[] Items {get; set;}
}
[Serializable]
public class QMSnReportRequestDeliveryOrder
{
/// <summary>
/// 出库单号
/// </summary>
[XmlElement("deliveryOrderCode", typeof(string))]
public string DeliveryOrderCode { get; set; }
/// <summary>
/// 仓储系统出库单号
/// </summary>
[XmlElement("deliveryOrderId", typeof(string))]
public string DeliveryOrderId { get; set; }
/// <summary>
/// 仓库编码
/// </summary>
[XmlElement("warehouseCode", typeof(string))]
public string WarehouseCode { get; set; }
/// <summary>
/// 货主编码
/// </summary>
[XmlElement("ownerCode", typeof(string))]
public string OwnerCode { get; set; }
/// <summary>
/// 出库单类型,JYCK=一般交易出库,HHCK=换货出库,BFCK=补发出库,PTCK=普通出库单,DBCK=调拨出库 ,QTCK=其他出库,B2BCK=B2B出库
/// </summary>
[XmlElement("orderType", typeof(string))]
public string OrderType { get; set; }
/// <summary>
/// string (50) , 外部业务编码, 消息ID, 用于去重, ISV对于同一请求,分配一个唯一性的编码。用来保证因为网络等原因导致重复传输,请求不会被重复处理,条件为一单需要多次确认, 外部业务编码, 消息ID, 用于去重, ISV对于同一请求,分配一个唯一性的编码。用来保证因为网络等原因导致重复传输,请求不会被重复处理,条件必填,条件为一单需要多次确认时
/// </summary>
[XmlElement("outBizCode", typeof(string))]
public string OutBizCode { get; set; }
}
[Serializable]
public class QMSnReportRequestItem
{
/// <summary>
/// 商品编码
/// </summary>
[XmlElement("itemCode", typeof(string))]
public string ItemCode { get; set; }
/// <summary>
/// 商品仓储系统编码
/// </summary>
[XmlElement("itemId", typeof(string))]
public string ItemId { get; set; }
/// <summary>
/// 商品序列号
/// </summary>
[XmlElement("sn", typeof(string))]
public string Sn { get; set; }
}
}
