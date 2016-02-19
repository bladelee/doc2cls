using System;
using System.Xml.Serialization;
using System.ComponentModel;
using Wms.Common;

namespace Wms.Request.QM
{
/// <summary>
/// 订单状态查询接口 （批量）
/// taobao.qimen.orderstatus.batchquery
/// </summary>
[Serializable]
[XmlRoot("request")]
public class QMOrderStatusBatchQueryRequest
{
/// <summary>
/// 货主编码
/// </summary>
[Required]
[Description("货主编码")]
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
/// 订单最后操作时间(查询起始时间点),YYYY-MM-DD hh:mm:ss
/// </summary>
[Required]
[Description("订单最后操作时间")]
[MaxLength(50)]
[XmlElement("startTime", typeof(string))]
public string StartTime { get; set; }
/// <summary>
/// 订单最后操作时间(查询截止时间点),默认当前时间,YYYY-MM-DD hh:mm:ss
/// </summary>
[MaxLength(50)]
[XmlElement("endTime", typeof(string))]
public string EndTime { get; set; }
/// <summary>
/// 单据类型,JYCK= 一般交易出库单,HHCK= 换货出库 ,BFCK= 补发出库,PTCK=普通出库单,DBCK=调拨出库 ,QTCK=其他出库,B2BRK=B2B入库,B2BCK=B2B出库,CGRK=采购入库 ,DBRK= 调拨入库 ,QTRK= 其他入库 ,XTRK= 销退入库,HHRK= 换货入库,CNJG= 仓内加工单
/// </summary>
[MaxLength(50)]
[XmlElement("orderType", typeof(string))]
public string OrderType { get; set; }
/// <summary>
/// 当前第几页,从1开始
/// </summary>
[Required]
[Description("当前第几页")]
[XmlElement("currentPage", typeof(int?), IsNullable = true)]
public int? CurrentPage { get; set; }
/// <summary>
/// 页面大小,建议不超过100条
/// </summary>
[Required]
[Description("页面大小")]
[XmlElement("pageSize", typeof(int?), IsNullable = true)]
public int? PageSize { get; set; }
}
}
