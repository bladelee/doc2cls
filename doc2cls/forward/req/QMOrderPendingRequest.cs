using System;
using System.Xml.Serialization;
using System.ComponentModel;
using Wms.Common;

namespace Wms.Request.QM
{
/// <summary>
/// 单据挂起（恢复）接口
/// taobao.qimen.order.pending
/// </summary>
[Serializable]
[XmlRoot("request")]
public class QMOrderPendingRequest
{
/// <summary>
/// 操作类型,pending=挂起,restore=恢复
/// </summary>
[Required]
[Description("操作类型")]
[MaxLength(50)]
[XmlElement("actionType", typeof(string))]
public string ActionType { get; set; }
/// <summary>
/// 仓库编码,统仓统配等无需ERP指定仓储编码的情况填OTHER
/// </summary>
[Required]
[Description("仓库编码")]
[MaxLength(50)]
[XmlElement("warehouseCode", typeof(string))]
public string WarehouseCode { get; set; }
/// <summary>
/// 货主编码
/// </summary>
[MaxLength(50)]
[XmlElement("ownerCode", typeof(string))]
public string OwnerCode { get; set; }
/// <summary>
/// 单据编码
/// </summary>
[Required]
[Description("单据编码")]
[MaxLength(50)]
[XmlElement("orderCode", typeof(string))]
public string OrderCode { get; set; }
/// <summary>
/// 仓储系统单据编码
/// </summary>
[Required]
[Description("仓储系统单据编码")]
[MaxLength(50)]
[XmlElement("orderId", typeof(string))]
public string OrderId { get; set; }
/// <summary>
/// 单据类型,  JYCK= 一般交易出库单,HHCK= 换货出库 ,BFCK= 补发出库 PTCK=普通出库单,DBCK=调拨出库 ,B2BRK=B2B入库,B2BCK=B2B出库,QTCK=其他出库, SCRK=生产入库,LYRK=领用入库,CCRK=残次品入库,CGRK=采购入库 ,DBRK= 调拨入库 ,QTRK= 其他入库 ,XTRK= 销退入库,THRK=退货入库, HHRK= 换货入库 CNJG= 仓内加工单
/// </summary>
[MaxLength(50)]
[XmlElement("orderType", typeof(string))]
public string OrderType { get; set; }
/// <summary>
/// 挂起(恢复)原因
/// </summary>
[MaxLength(500)]
[XmlElement("reason", typeof(string))]
public string Reason { get; set; }
}
}
