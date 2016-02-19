using System;
using System.Xml.Serialization;
using System.ComponentModel;
using Wms.Common;

namespace Wms.Request.QM
{
/// <summary>
/// 库存盘点查询接口
/// taobao.qimen.inventorycheck.query
/// </summary>
[Serializable]
[XmlRoot("request")]
public class QMInventoryCheckQueryRequest
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
/// 盘点单编码
/// </summary>
[Required]
[Description("盘点单编码")]
[MaxLength(50)]
[XmlElement("checkOrderCode", typeof(string))]
public string CheckOrderCode { get; set; }
/// <summary>
/// 仓储系统的盘点单编码
/// </summary>
[Required]
[Description("仓储系统的盘点单编码")]
[MaxLength(50)]
[XmlElement("checkOrderId", typeof(string))]
public string CheckOrderId { get; set; }
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
