using System;
using System.Xml.Serialization;
using System.ComponentModel;
using Wms.Common;

namespace Wms.Request.QM
{
/// <summary>
/// 退货入库单查询接口
/// taobao.qimen.returnorder.query
/// </summary>
[Serializable]
[XmlRoot("request")]
public class QMReturnOrderQueryRequest
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
/// 退货单编码
/// </summary>
[Required]
[Description("退货单编码")]
[MaxLength(50)]
[XmlElement("returnOrderCode", typeof(string))]
public string ReturnOrderCode { get; set; }
/// <summary>
/// 仓库系统订单编码
/// </summary>
[Required]
[Description("仓库系统订单编码")]
[MaxLength(50)]
[XmlElement("returnOrderId", typeof(string))]
public string ReturnOrderId { get; set; }
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
