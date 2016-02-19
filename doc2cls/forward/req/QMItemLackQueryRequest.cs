using System;
using System.Xml.Serialization;
using System.ComponentModel;
using Wms.Common;

namespace Wms.Request.QM
{
/// <summary>
/// 发货单缺货查询接口
/// taobao.qimen.itemlack.query
/// </summary>
[Serializable]
[XmlRoot("request")]
public class QMItemLackQueryRequest
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
/// 出库单号
/// </summary>
[Required]
[Description("出库单号")]
[MaxLength(50)]
[XmlElement("deliveryOrderCode", typeof(string))]
public string DeliveryOrderCode { get; set; }
/// <summary>
/// 仓储系统出库单号
/// </summary>
[Required]
[Description("仓储系统出库单号")]
[MaxLength(50)]
[XmlElement("deliveryOrderId", typeof(string))]
public string DeliveryOrderId { get; set; }
/// <summary>
/// 当前页,从1开始
/// </summary>
[Required]
[Description("当前页")]
[MaxLength(50)]
[XmlElement("page", typeof(string))]
public string Page { get; set; }
/// <summary>
/// 每页orderLine条数(最多100条)
/// </summary>
[Required]
[Description("每页orderLine条数")]
[MaxLength(50)]
[XmlElement("pageSize", typeof(string))]
public string PageSize { get; set; }
}
}
