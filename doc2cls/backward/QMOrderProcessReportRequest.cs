using System;
using System.Xml.Serialization;
using Wms.Common;

namespace Wms.CallBack.Request
{
/// <summary>
/// 订单流水通知接口
/// orderprocess.report
/// </summary>
[Serializable]
[XmlRoot("request")]
public class QMOrderProcessReportRequest
{

[XmlElement("order", typeof(QMOrderProcessReportRequestOrder))]
public QMOrderProcessReportRequestOrder Order {get; set;}

[XmlElement("process", typeof(QMOrderProcessReportRequestProcess))]
public QMOrderProcessReportRequestProcess Process {get; set;}
}
[Serializable]
public class QMOrderProcessReportRequestOrder
{
/// <summary>
/// 单据号
/// </summary>
[XmlElement("orderCode", typeof(string))]
public string OrderCode { get; set; }
/// <summary>
/// 仓储系统单据号
/// </summary>
[XmlElement("orderId", typeof(string))]
public string OrderId { get; set; }
/// <summary>
/// 单据类型, JYCK= 一般交易出库单,HHCK= 换货出库 ,BFCK= 补发出库,PTCK=普通出库单,DBCK=调拨出库 ,B2BRK=B2B入库,B2BCK=B2B出库,QTCK=其他出库,SCRK=生产入库,LYRK=领用入库,CCRK=残次品入库,CGRK=采购入库 ,DBRK= 调拨入库 ,QTRK= 其他入库 ,XTRK= 销退入库,HHRK= 换货入库,CNJG= 仓内加工单
/// </summary>
[XmlElement("orderType", typeof(string))]
public string OrderType { get; set; }
/// <summary>
/// 仓库编码
/// </summary>
[XmlElement("warehouseCode", typeof(string))]
public string WarehouseCode { get; set; }
}
[Serializable]
public class QMOrderProcessReportRequestProcess
{
/// <summary>
/// 单据状态, ACCEPT=仓库接单, PARTFULFILLED-部分收货完成,  FULFILLED-收货完成, PRINT = 打印,  PICK=捡货,  CHECK = 复核,  PACKAGE= 打包,  WEIGH= 称重, READY=待提货, DELIVERED=已发货,  REFUSE=买家拒签,EXCEPTION =异常 ,CLOSED= 关闭,  CANCELED= 取消,  REJECT=仓库拒单,SIGN=签收,TMSCANCELED=快递拦截,OTHER=其他,PARTDELIVERED=部分发货完成
/// </summary>
[XmlElement("processStatus", typeof(string))]
public string ProcessStatus { get; set; }
/// <summary>
/// 当前状态操作员编码
/// </summary>
[XmlElement("operatorCode", typeof(string))]
public string OperatorCode { get; set; }
/// <summary>
/// 当前状态操作员姓名
/// </summary>
[XmlElement("operatorName", typeof(string))]
public string OperatorName { get; set; }
/// <summary>
/// 当前状态操作时间, YYYY-MM-DD HH:MM:SS
/// </summary>
[XmlElement("operateTime", typeof(string))]
public string OperateTime { get; set; }
/// <summary>
/// 操作内容
/// </summary>
[XmlElement("operateInfo", typeof(string))]
public string OperateInfo { get; set; }
/// <summary>
/// 备注
/// </summary>
[XmlElement("remark", typeof(string))]
public string Remark { get; set; }

[XmlElement("extendProps", typeof(QMOrderProcessReportRequestProcessExtendProps))]
public QMOrderProcessReportRequestProcessExtendProps ExtendProps {get; set;}
}
[Serializable]
public class QMOrderProcessReportRequestProcessExtendProps
{
/// <summary>
/// value1
/// </summary>
[XmlElement("key1", typeof(string))]
public string Key1 { get; set; }
/// <summary>
/// value2
/// </summary>
[XmlElement("key2", typeof(string))]
public string Key2 { get; set; }
}
}
