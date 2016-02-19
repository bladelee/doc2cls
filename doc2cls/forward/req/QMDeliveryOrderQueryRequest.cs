using System;
using System.Xml.Serialization;
using System.ComponentModel;
using Wms.Common;

namespace Wms.Request.QM
{
/// <summary>
/// 发货单查询接口
/// taobao.qimen.deliveryorder.query
/// </summary>
[Serializable]
[XmlRoot("request")]
public class QMDeliveryOrderQueryRequest
{
/// <summary>
/// 货主编码
/// </summary>
[MaxLength(50)]
[XmlElement("ownerCode", typeof(string))]
public string OwnerCode { get; set; }
/// <summary>
/// 仓库编码
/// </summary>
[MaxLength(50)]
[XmlElement("warehouseCode", typeof(string))]
public string WarehouseCode { get; set; }
/// <summary>
/// 发库单号
/// </summary>
[Required]
[Description("发库单号")]
[MaxLength(50)]
[XmlElement("orderCode", typeof(string))]
public string OrderCode { get; set; }
/// <summary>
/// 仓储系统发库单号
/// </summary>
[Required]
[Description("仓储系统发库单号")]
[MaxLength(50)]
[XmlElement("orderId", typeof(string))]
public string OrderId { get; set; }
/// <summary>
/// 当前页,从1开始
/// </summary>
[MaxLength(50)]
[XmlElement("page", typeof(string))]
public string Page { get; set; }
/// <summary>
/// 每页orderLine条数(最多100条)
/// </summary>
[MaxLength(50)]
[XmlElement("pageSize", typeof(string))]
public string PageSize { get; set; }
}
}
