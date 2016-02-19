using System;
using System.Xml.Serialization;
using System.ComponentModel;
using Wms.Common;

namespace Wms.Request.QM
{
/// <summary>
/// 入库单查询接口
/// taobao.qimen.entryorder.query
/// </summary>
[Serializable]
[XmlRoot("request")]
public class QMEntryOrderQueryRequest
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
/// 入库单编码
/// </summary>
[Required]
[Description("入库单编码")]
[MaxLength(50)]
[XmlElement("entryOrderCode", typeof(string))]
public string EntryOrderCode { get; set; }
/// <summary>
/// 仓储系统入库单ID
/// </summary>
[Required]
[Description("仓储系统入库单ID")]
[MaxLength(50)]
[XmlElement("entryOrderId", typeof(string))]
public string EntryOrderId { get; set; }
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
