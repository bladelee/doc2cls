using System;
using System.Xml.Serialization;
using System.ComponentModel;
using Wms.Common;

namespace Wms.Request.QM
{
/// <summary>
/// 订单流水查询接口
/// taobao.qimen.orderprocess.query
/// </summary>
[Serializable]
[XmlRoot("request")]
public class QMOrderProcessQueryRequest
{
/// <summary>
/// 单据类型,JYCK= 一般交易出库单,HHCK= 换货出库 ,BFCK= 补发出库,PTCK=普通出库单,DBCK=调拨出库 ,QTCK=其他出库,B2BRK=B2B入库,B2BCK=B2B出库,CGRK=采购入库 ,DBRK= 调拨入库 ,QTRK= 其他入库 ,XTRK= 销退入库,HHRK= 换货入库,CNJG= 仓内加工单
/// </summary>
[MaxLength(50)]
[XmlElement("orderType", typeof(string))]
public string OrderType { get; set; }
/// <summary>
/// 单据号
/// </summary>
[Required]
[Description("单据号")]
[MaxLength(50)]
[XmlElement("orderCode", typeof(string))]
public string OrderCode { get; set; }
/// <summary>
/// 仓储系统单据号
/// </summary>
[Required]
[Description("仓储系统单据号")]
[MaxLength(50)]
[XmlElement("orderId", typeof(string))]
public string OrderId { get; set; }
/// <summary>
/// 仓库编码
/// </summary>
[MaxLength(50)]
[XmlElement("warehouseCode", typeof(string))]
public string WarehouseCode { get; set; }
}
}
